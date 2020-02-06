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
            //var produk = from a in _AppDbContext.items select a;
            if (!_AppDbContext.carts.Any ()) {
                Carts cart = new Carts ()
                    {
                        total = 0,
                        price = 0
                    };         
                _AppDbContext.carts.Add (cart);
                _AppDbContext.SaveChanges ();
            }
            var ca = _AppDbContext.carts.Find(1);
            
            var item = _AppDbContext.items.Find(id);
            item.CartsID = ca.id;
            _AppDbContext.Add(item);
            _AppDbContext.Attach(item);
            _AppDbContext.SaveChanges();
                   
            ;
            var display = from x in _AppDbContext.carts from y in _AppDbContext.items where y.CartsID == x.id select y;
            ViewBag.items = display;
            return View ("Cart");
        }
        // Carts cart = null;

        //     cart = new Carts();

        // public IActionResult Add(int id)
        // {
        //     var item = _AppDbContext.items.Find(id);
        //     var obj = new 
        // }

        public IActionResult Privacy () {
            return View ();
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}