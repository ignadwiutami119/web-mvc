using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using JW;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Protocols;
using Task_Web_Product.Models;
// using System.Web.Mvc;  
using System.Net;
using System.Net.Mail;
using CSVLibraryAK;
using MailKit;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using MimeKit;
using Stripe;

namespace Task_Web_Product.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;
        private AppDbContext _AppDbContext;
        public HomeController (ILogger<HomeController> logger, AppDbContext appDbContext) {
            _logger = logger;
            _AppDbContext = appDbContext;
        }

        public IActionResult Index () {
            return View ();
        }

        [Authorize]
        public IActionResult Welcomepage () {
            var items = from item in _AppDbContext.items where item.rate > 6 select item;
            ViewBag.items = items;
            return View ();
        }

        [Authorize]
        public IActionResult Export () {
            var comlumHeadrs = new string[] {
                "Items Id",
                "Name",
                "Description",
                "Price",
                "Rate",
                "URL Image"
            };
            var itemRecord = (from x in _AppDbContext.items select new object[] {
                x.id,
                    $"{x.title}",
                    $"\"{x.desc}\"",
                    x.price,
                    x.rate,
                    x.image
            }).ToList ();
            var ItemCsv = new StringBuilder ();
            itemRecord.ForEach (line => {
                ItemCsv.AppendLine (string.Join (",", line));
            });
            byte[] buffer = Encoding.ASCII.GetBytes ($"{string.Join(",", comlumHeadrs)}\r\n{ItemCsv.ToString()}");
            return File (buffer, "text/csv", $"Item.csv");
        }

        [Authorize]
        public IActionResult Import ([FromForm (Name = "file")] IFormFile file) {
            string filePath = string.Empty;
            if (file != null) {
                try {
                    string fileExtension = Path.GetExtension (file.FileName);
                    if (fileExtension != ".csv") {
                        ViewBag.Message = "only csv file allowed";
                        return View ("AdminPage");
                    }
                    using (var reader = new StreamReader (file.OpenReadStream ())) {
                        string[] headers = reader.ReadLine ().Split (',');
                        while (!reader.EndOfStream) {
                            string[] rows = reader.ReadLine ().Split (',');
                            Items objek = new Items {
                                title = rows[0].ToString (),
                                desc = rows[1].ToString (),
                                price = Convert.ToInt32 (rows[2]),
                                rate = Convert.ToInt32 (rows[3]),
                                image = rows[4].ToString (),
                                CartsID = 1,
                                total = 0,
                            };
                            _AppDbContext.items.Add (objek);
                        }
                        _AppDbContext.SaveChanges ();
                    }
                    return View ("Csv");
                } catch (Exception e) {
                    ViewBag.Message = e.Message;
                }
            }
            return View ("Csv");
        }

        [Authorize]
        public IActionResult TransactionList () {
            var get = from a in _AppDbContext.purchases select a;
            ViewBag.items = get;
            return View ("Transaction");
        }

        [Authorize]
        public IActionResult Search (string val) {
            var show = from a in _AppDbContext.items where (a.title.Contains (val) || a.desc.Contains (val)) select a;
            ViewBag.items = show;
            return View ("Product");
        }

        [Authorize]
        public IActionResult Product () {
            if (!_AppDbContext.paging.Any ()) {
                Paging page = new Paging ();
                _AppDbContext.paging.Add (page);
                _AppDbContext.SaveChanges ();
            }
            var set_page = _AppDbContext.paging.Find (1);
            var take = set_page.showitem;
            var show = from a in _AppDbContext.items.Take (take) select a;
            ViewBag.items = show;
            return View ("Product");
        }

        [Authorize]
        public IActionResult Paging (string set, int _crntpage = 1, int val = 1, int next = 0, int prev = 0) {
            if (!_AppDbContext.paging.Any ()) {
            Paging page = new Paging () {
            showitem = Convert.ToInt32 (set),
            curent_page = _crntpage
                };
                _AppDbContext.paging.Add (page);
                _AppDbContext.SaveChanges ();
            } else {
                if (set != null) {
                    var getpage = from x in _AppDbContext.paging select x;
                    foreach (var item in getpage) {
                        item.showitem = Convert.ToInt32 (set);
                    }
                    _AppDbContext.SaveChanges ();
                }
            }

            //ganti nilai curent page
            // if (next==1) {
            //     var getpage = _AppDbContext.paging.Find(1);
            //     var pagenow = getpage.curent_page;
            //     getpage.curent_page = 3;
            //     _AppDbContext.SaveChanges ();
            // }

            // if (prev==1) {
            //     var getpage = from x in _AppDbContext.paging select x;
            //     foreach (var item in getpage) {
            //         item.curent_page--;
            //     }
            //     _AppDbContext.SaveChanges ();
            // }

            var get = from x in _AppDbContext.paging select x;
            foreach (var item in get) {
                item.curent_page = _crntpage;
            }
            _AppDbContext.SaveChanges ();
            var set_page = _AppDbContext.paging.Find (1);
            if (set_page.curent_page == 1) {
                var take = set_page.showitem;
                var show = from a in _AppDbContext.items.Take (take) select a;
                ViewBag.items = show;
            } else {
                var take = set_page.showitem;
                var show = from a in _AppDbContext.items.Skip (take * (set_page.curent_page - 1)).Take (take) select a;
                ViewBag.items = show;
            }
            return View ("Product");
        }

        [Authorize]
        public IActionResult Sort (string val) {
            if (!_AppDbContext.paging.Any ()) {
                Paging page = new Paging ();
                _AppDbContext.paging.Add (page);
                _AppDbContext.SaveChanges ();
            }
            var set_page = _AppDbContext.paging.Find (1);
            if (val == "default") {
                var take = set_page.showitem;
                var show = from a in _AppDbContext.items.Skip (take * (set_page.curent_page - 1)).Take (take) select a;
                ViewBag.items = show;
            } else if (val == "name_asc") {
                var take = set_page.showitem;
                var show = from a in _AppDbContext.items.Skip (take * (set_page.curent_page - 1)).Take (take) orderby a.title select a;
                ViewBag.items = show;
            } else if (val == "name_desc") {
                var take = set_page.showitem;
                var show = from a in _AppDbContext.items.Skip (take * (set_page.curent_page - 1)).Take (take) orderby a.title descending select a;
                ViewBag.items = show;
            } else if (val == "price_asc") {
                var take = set_page.showitem;
                var show = from a in _AppDbContext.items.Skip (take * (set_page.curent_page - 1)).Take (take) orderby a.price select a;
                ViewBag.items = show;
            } else if (val == "price_desc") {
                var take = set_page.showitem;
                var show = from a in _AppDbContext.items.Skip (take * (set_page.curent_page - 1)).Take (take) orderby a.price descending select a;
                ViewBag.items = show;
            }
            return View ("Product");
        }

        [Authorize]
        public IActionResult Detail (int Id) {
            var items = from i in _AppDbContext.items where i.id == Id select i;
            ViewBag.items = items;
            return View ("Detail");
        }

        [Authorize]
        public IActionResult Addproduct () {
            return View ();
        }

        //untuk menambahkan produk ke database
        [Authorize]
        public IActionResult Add_Data_Product (string title, string image, string desc, int price, int rate) {
            if (title != null) {
                Items obj = new Items {
                title = title,
                image = image,
                desc = desc,
                price = price,
                rate = rate,
                total = 0,
                CartsID = null
                };
                _AppDbContext.Add (obj);
                _AppDbContext.SaveChanges ();
            }
            var get = from a in _AppDbContext.items select a;
            ViewBag.items = get;
            return View ("AdminPage");
        }

        [Authorize]
        public IActionResult RemoveProduct (int id) {
            if (id != 0) {
                var obj = _AppDbContext.items.Find (id);
                _AppDbContext.items.Remove (obj);
                _AppDbContext.SaveChanges ();
            }
            var items = from item in _AppDbContext.items select item;
            ViewBag.items = items;
            return View ("AdminPage");
        }

        //return view untuk edit produk
        [Authorize]
        public IActionResult Editform (int id) {
            var selected_item = from item in _AppDbContext.items where item.id == id select item;
            ViewBag.items = selected_item;
            return View ("Editform");
        }

        //eskekusi query untuk mengubah data product
        [Authorize]
        public IActionResult EditData (int id, string title, string image, string desc, int price, int rate) {
            var objek = _AppDbContext.items.Find (id);
            objek.title = title;
            objek.image = image;
            objek.desc = desc;
            objek.price = price;
            objek.rate = rate;
            objek.total = 0;
            objek.CartsID = 1;
            _AppDbContext.Add (objek);
            _AppDbContext.Attach (objek);
            _AppDbContext.SaveChanges ();
            var selected_item = from item in _AppDbContext.items select item;
            ViewBag.items = selected_item;
            return View ("AdminPage");
        }

        [Authorize]
        public IActionResult csv () {
            return View ();
        }

        [Authorize]
        public IActionResult AdminPage () {
            var get = from a in _AppDbContext.items select a;
            ViewBag.items = get;
            return View ();
        }

        public IActionResult Login (string username, string password) {
            var acc = from item in _AppDbContext.account select item;
            var _get = from item in _AppDbContext.items where item.rate > 5 select item;
            foreach (var x in acc) {
                if (x.username == username) {
                    if (Convert.ToString (x.password) == password) {
                        HttpContext.Session.SetString ("username", username);
                        if (x.role == "admin") {
                            return View ("Admin");
                        } else if (x.role == "user") {
                            ViewBag.items = _get;
                            return View ("Welcomepage");
                        }
                    } else {
                        ViewBag.error = "Invalid Password";
                    }
                } else {
                    ViewBag.error = "Invalid Username";
                }
            }
            var get = from item in _AppDbContext.items where item.rate > 8 select item;
            ViewBag.items = get;
            return View ();
        }

        [Authorize]
        public IActionResult Cart (int id) {
            var display = from x in _AppDbContext.carts from y in x.produk where y.CartsID == 1 select y;
            ViewBag.items = display;
            return View ("Cart");
        }

        [Authorize]
        public IActionResult CheckoutForm (int total) {
            var PurchasedItem = from x in _AppDbContext.items where x.CartsID != null select x;
            ViewBag.items = PurchasedItem;
            ViewBag.total = total;
            return View ("Purchaseform");
        }

        [Authorize]
        public IActionResult Pay (string fullname, string email, string phone, string address, int total, string zip) {
            var objek = new Purchase {
                nama = fullname,
                email = email,
                address = address,
                phone_number = phone,
                totalPurchase = total,
                Zipcode = zip,
                payment_method = "Card"
            };
            var obj = _AppDbContext.carts.Find (1);
            obj.TotalPrice = total;
            ViewBag.total = total;
            _AppDbContext.Add (objek);
            _AppDbContext.SaveChanges ();
            return View ("Pay");
        }

        [Authorize]
        public IActionResult Update (int id, int val) {
            var item = _AppDbContext.items.Find (id);
            item.total = val;
            _AppDbContext.Add (item);
            _AppDbContext.Attach (item);
            _AppDbContext.SaveChanges ();
            var display = from x in _AppDbContext.carts from y in x.produk where y.CartsID == 1 select y;
            ViewBag.items = display;
            return RedirectToAction ("Cart", "Home");
        }

        [Authorize]
        public IActionResult RemoveCart (int id) {
            var item = _AppDbContext.items.Find (id);
            var total = item.total = 0;
            item.CartsID = null;
            _AppDbContext.Add (item);
            _AppDbContext.Attach (item);
            _AppDbContext.SaveChanges ();
            var display = from x in _AppDbContext.carts from y in x.produk where y.CartsID == 1 select y;
            ViewBag.items = display;
            return RedirectToAction ("Cart", "Home");
        }

        [Authorize]
        public IActionResult Checkout (int total) {
            var item = _AppDbContext.carts.Find (1);
            item.TotalPrice = total;
            _AppDbContext.Add (item);
            _AppDbContext.Attach (item);
            _AppDbContext.SaveChanges ();
            var display = from x in _AppDbContext.carts select x.TotalPrice;
            ViewBag.items = display;
            return View ("Checkout");
        }

        [Authorize]
        public IActionResult Add (int id) {
            var ca = _AppDbContext.carts.Find (1);
            var item = _AppDbContext.items.Find (id);
            if (!_AppDbContext.carts.Any ()) {
                Carts cart = new Carts ();
                _AppDbContext.carts.Add (cart);
                _AppDbContext.SaveChanges ();
            }
            item.total += 1;
            item.CartsID = ca.id;
            _AppDbContext.SaveChanges ();
            var display = from x in _AppDbContext.carts from y in x.produk where y.CartsID == 1 && y.total > 0 select y;
            ViewBag.items = display;
            return RedirectToAction ("Cart", "Home");
        }

        [Authorize]
        public IActionResult Stripe_payment (string stripeEmail, string stripeToken) {
            var customer = new CustomerService ();
            var charges = new ChargeService ();
            var customers = customer.Create (new CustomerCreateOptions {
                Email = stripeEmail,
                    Source = stripeToken
            });
            var get = from i in _AppDbContext.purchases.OrderBy(i => i.id) select i;
            var last = get.LastOrDefault();
                var charge = charges.Create (new ChargeCreateOptions {
                    Amount = last.totalPurchase,
                        Description = "Test Payment",
                        Currency = "idr",
                        Customer = customers.Id
                });
                if (charge.Status == "succeeded") {
                    string BalanceTransactionId = charge.BalanceTransactionId;
                    return RedirectToAction ("Mail","Home");
            }
            return View ("Pay");
        }

        [Authorize]
        public IActionResult Mail () {
            var message = new MimeMessage ();
            message.From.Add (new MailboxAddress ("bellroy", "bellroy@bellroy.com"));
            message.To.Add (new MailboxAddress ("igna", "ignadwiutami@gmail.com"));
            message.Subject = "Invoice From Bellroy";
            var get = from i in _AppDbContext.purchases.OrderBy(i => i.id) select i;
            var last = get.LastOrDefault();
            message.Body = new TextPart ("plain") {
                Text = @"Hello "+last.nama+
                "\nThanks for purchasing our best collection \n" +
                "Here is your purchase details :\n" +
                "Amount : Rp. "+last.totalPurchase
            };
            using (var emailClient = new MailKit.Net.Smtp.SmtpClient ()) {
                emailClient.ServerCertificateValidationCallback = (s, c, h, e) => true;
                emailClient.Connect ("smtp.mailtrap.io", 587, false);
                emailClient.Authenticate ("31e443602f2a8a", "187ef92862e63c");
                emailClient.Send (message);
            }
            return View ("Success");
        }

        [Authorize]
        public IActionResult Privacy () {
            return View ();
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}