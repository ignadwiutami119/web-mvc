using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
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
            var items = from item in _AppDbContext.items select item;
            ViewBag.items = items;
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
            return RedirectToAction ("Cart","Home");
        }
        public IActionResult Remove (int id) {
            var item = _AppDbContext.items.Find (id);
            item.total = 0;
            _AppDbContext.Add (item);
            _AppDbContext.Attach (item);
            _AppDbContext.SaveChanges ();
            var display = from x in _AppDbContext.carts from y in x.produk where y.CartsID == 1 select y;
            ViewBag.items = display;
            return RedirectToAction ("Cart","Home");
        }
        public IActionResult Checkout (int total) {
            var item = _AppDbContext.carts.Find (1);
            item.TotalPrice = total;
            _AppDbContext.Add (item);
            _AppDbContext.Attach (item);
            _AppDbContext.SaveChanges ();
            var display = from x in _AppDbContext.carts from y in x.produk where y.CartsID == 1 select y;
            ViewBag.items = display;
            return RedirectToAction ("Cart","Home");
        }

        public IActionResult Add(int id)
        {
            var ca = _AppDbContext.carts.Find(1);
            var item = _AppDbContext.items.Find(id);
            if (!_AppDbContext.carts.Any())
            {
                Carts cart = new Carts();
                _AppDbContext.carts.Add(cart);
                _AppDbContext.SaveChanges();
            }
            
            item.total+=1;
            item.CartsID = ca.id;
            _AppDbContext.Add(item);
            _AppDbContext.Attach(item);
            _AppDbContext.SaveChanges();
 
            var display = from x in _AppDbContext.carts from y in x.produk where y.CartsID==1 && y.total>0 select y;
            ViewBag.items = display;
            return RedirectToAction("Cart","Home");
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