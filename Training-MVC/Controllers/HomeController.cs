using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Task_Web_Product.Models;

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

        public IActionResult Editform (int id) {
            var selected_item = from item in _AppDbContext.items where item.id == id select item;
            ViewBag.items = selected_item;
            return View("Editform");
        }
        public IActionResult EditData (int id, string title, string image, string desc, int price, int rate) {
            var objek = _AppDbContext.items.Find(id);
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
        public IActionResult RemoveProduct (int id) {
            var obj = _AppDbContext.items.Find (id);
            _AppDbContext.items.Remove (obj);
            _AppDbContext.SaveChanges ();
            var items = from item in _AppDbContext.items select item;
            ViewBag.items = items;
            return View ("Editproduct");
        }
        public IActionResult Editproduct () {
            var items = from item in _AppDbContext.items select item;
            ViewBag.items = items;
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

        public IActionResult Detail (int Id) {
            var items = from i in _AppDbContext.items where i.id == Id select i;
            ViewBag.items = items;
            return View ("Detail");
        }

        public IActionResult Product () {
            var items = from i in _AppDbContext.items select i;
            ViewBag.items = items;
            return View ("Product");
        }

        public IActionResult Cart (int id) {
            var display = from x in _AppDbContext.carts from y in x.produk where y.CartsID == 1 select y;
            ViewBag.items = display;
            return View ("Cart");
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
            item.total = 0;
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
            _AppDbContext.Add (item);
            _AppDbContext.Attach (item);
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