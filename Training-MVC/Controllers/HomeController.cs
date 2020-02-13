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
using CSVLibraryAK;
using Microsoft.AspNetCore.Authorization;

namespace Task_Web_Product.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;
        private AppDbContext _AppDbContext;
        public HomeController (ILogger<HomeController> logger, AppDbContext appDbContext) {
            _logger = logger;
            _AppDbContext = appDbContext;
        }

        public IActionResult Index () {
            var items = from item in _AppDbContext.items where item.rate > 6 select item;
            ViewBag.items = items;
            return View ();
        }

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

        public IActionResult Import ([FromForm (Name = "file")] IFormFile file) {
            string filePath = string.Empty;
            if (file != null) {
                try {
                    string fileExtension = Path.GetExtension (file.FileName);
                    if (fileExtension != ".csv") {
                        ViewBag.Message = "Please select the csv file";
                        return View ("Admin");
                    }
                    using (var reader = new StreamReader (file.OpenReadStream ())) {
                        string[] header = reader.ReadLine ().Split (',');
                        while (!reader.EndOfStream) {
                            Console.WriteLine ("HOMEEE");
                            string[] rows = reader.ReadLine ().Split (',');
                            Items objek = new Items {
                                title = rows[0].ToString (),
                                desc = rows[1].ToString (),
                                price = Convert.ToInt32 (rows[2]),
                                rate = Convert.ToInt32 (rows[3]),
                                image = rows[4].ToString (),
                                CartsID = 1,
                                total = 0,
                                id = 100
                            };
                            _AppDbContext.items.Add (objek);
                        }
                        _AppDbContext.SaveChanges ();
                    }
                    return View ("Admin");
                } catch (Exception e) {
                    ViewBag.Message = e.Message;
                }
            }
            return View ("Admin");
        }

        public IActionResult Search (string val) {
            var show = from a in _AppDbContext.items where (a.title.Contains (val) || a.desc.Contains (val)) select a;
            ViewBag.items = show;
            return View ("Product");
        }

        public IActionResult Product () {
            var items = from a in _AppDbContext.items select a;
            ViewBag.items = items;
            return View ("Product");
        }
        public IActionResult Paging (int val, int set = 4) {
            var take = set;
            if (val == 1) {
                var show = from a in _AppDbContext.items.Take (take) select a;
                ViewBag.items = show;
            } else if (val == 2) {
                var show = from a in _AppDbContext.items.Skip (take).Take (take) select a;
                ViewBag.items = show;
            } else if (val == 3) {
                var show = from a in _AppDbContext.items.Skip (take * 2).Take (take) select a;
                ViewBag.items = show;
            } else if (val == 4) {
                var show = from a in _AppDbContext.items.Skip (take * 3).Take (take) select a;
                ViewBag.items = show;
            }
            return View ("Product");
        }
        public IActionResult Sort (string val) {
            if (val == "default") {
                var obj = from x in _AppDbContext.items select x;
                ViewBag.items = obj;
            } else if (val == "name_asc") {
                var obj = from x in _AppDbContext.items orderby x.title select x;
                ViewBag.items = obj;
            } else if (val == "name_desc") {
                var obj = from x in _AppDbContext.items orderby x.title descending select x;
                ViewBag.items = obj;
            } else if (val == "price_asc") {
                var obj = from x in _AppDbContext.items orderby x.price select x;
                ViewBag.items = obj;
            } else if (val == "price_desc") {
                var obj = from x in _AppDbContext.items orderby x.price descending select x;
                ViewBag.items = obj;
            }
            return View ("Product");
        }

        public IActionResult Detail (int Id) {
            var items = from i in _AppDbContext.items where i.id == Id select i;
            ViewBag.items = items;
            return View ("Detail");
        }
        public IActionResult Addproduct (string title, string image, string desc, int price, int rate) {
            Items obj = new Items {
                title = title,
                image = image,
                desc = desc,
                price = price,
                rate = rate,
                total = 0,
                CartsID = 1

            };
            _AppDbContext.Add (obj);
            _AppDbContext.SaveChanges ();
            return View ();
        }

        public IActionResult Editproduct () {
            var items = from item in _AppDbContext.items select item;
            ViewBag.items = items;
            return View ("Editproduct");
        }

        public IActionResult RemoveProduct (int id) {
            if (id != 0) {
                var obj = _AppDbContext.items.Find (id);
                _AppDbContext.items.Remove (obj);
                _AppDbContext.SaveChanges ();
            }
            var items = from item in _AppDbContext.items select item;
            ViewBag.items = items;
            return View ("Editproduct");
        }

        public IActionResult Editform (int id) {
            var selected_item = from item in _AppDbContext.items where item.id == id select item;
            ViewBag.items = selected_item;
            return View ("Editform");
        }
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
            return View ("Editproduct");
        }

        public IActionResult Login (string username, string password) {
            var items = from item in _AppDbContext.account select item;
            foreach (var x in items) {
                if (x.username == username) {
                    if (Convert.ToString (x.password) == password) {
                        HttpContext.Session.SetString ("username", username);
                        var _get = from item in _AppDbContext.items where item.rate > 8 select item;
                        ViewBag.items = _get;
                        return View ("Admin");
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

        public IActionResult Cart (int id) {
            var display = from x in _AppDbContext.carts from y in x.produk where y.CartsID == 1 select y;
            ViewBag.items = display;
            return View ("Cart");
        }
        public IActionResult Purchase (int total) {
            ViewBag.items = total;
            return View ("Purchaseform");
        }
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

        public IActionResult Privacy () {
            return View ();
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}