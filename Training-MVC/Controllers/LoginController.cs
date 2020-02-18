using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Task_Web_Product.Controllers;
using Task_Web_Product.Models;

namespace MVC.Controllers {
    public class AdminController : Controller {
        private readonly ILogger<HomeController> _logger;
        public IConfiguration Configuration;
        private AppDbContext _appDbContext;

        public AdminController (ILogger<HomeController> logger, AppDbContext appDbContext, IConfiguration configuration) {
            _logger = logger;
            _appDbContext = appDbContext;
            Configuration = configuration;
        }

        public IActionResult Index () {
            return View ("Login");
        }

        public IActionResult Login (string Username, string Password) {
            IActionResult response = Unauthorized ();

            var user = AuthenticatedUser (Username, Password);
            if (user != null) {
                var token = GenerateJwtToken (user);
                HttpContext.Session.SetString ("JWTToken", token);
                var get = HttpContext.Session.GetString ("JWTToken");
                var cek = from x in _appDbContext.account select x;
                foreach (var item in cek) {
                    if (item.username == Username && item.password == Password && item.role == "admin") {
                        return RedirectToAction ("DataAdmin", "Admin");
                    } else if (item.username == Username && item.password == Password && item.role == "user") {
                        return RedirectToAction ("DataUser", "Admin");
                    }
                }
                return RedirectToAction ("DataAdmin", "Admin");
            }
            return View ();
        }

        private string GenerateJwtToken (AccountModel user) {
            var secuityKey = new SymmetricSecurityKey (Encoding.UTF8.GetBytes (Configuration["Jwt:Key"]));
            var credentials = new SigningCredentials (secuityKey, SecurityAlgorithms.HmacSha256);

            var claims = new [] {
                new Claim (JwtRegisteredClaimNames.Sub, Convert.ToString (user.username)),
                new Claim (JwtRegisteredClaimNames.Jti, Guid.NewGuid ().ToString ())
            };

            var token = new JwtSecurityToken (
                issuer: Configuration["Jwt:Issuer"],
                audience : Configuration["Jwt:Audience"],
                claims,
                expires : DateTime.Now.AddHours (2),
                signingCredentials : credentials);
            var encodedToken = new JwtSecurityTokenHandler ().WriteToken (token);
            return encodedToken;
        }

        private AccountModel AuthenticatedUser (string Username, string Password) {
            AccountModel user = null;
            var get = from i in _appDbContext.account select i;
            foreach (var i in get) {
                if (i.username == Username && i.password == Password) {
                    user = new AccountModel {
                    username = Username,
                    password = Password,
                    };
                }
            }
            return user;
        }

        [Authorize]
        public IActionResult DataAdmin (string role) {
            var token = HttpContext.Session.GetString ("JWTToken");
            var jwtSec = new JwtSecurityTokenHandler ();
            var securityToken = jwtSec.ReadToken (token) as JwtSecurityToken;
            var sub = securityToken?.Claims.First (Claim => Claim.Type == "sub").Value;
            var items = from i in _appDbContext.items select i;
            ViewBag.items = items;
            return RedirectToAction ("AdminPage", "Home");
        }

        [Authorize]
        public IActionResult DataUser (string role) {
            var token = HttpContext.Session.GetString ("JWTToken");
            var jwtSec = new JwtSecurityTokenHandler ();
            var securityToken = jwtSec.ReadToken (token) as JwtSecurityToken;
            var sub = securityToken?.Claims.First (Claim => Claim.Type == "sub").Value;
            var items = from i in _appDbContext.items select i;
            ViewBag.items = items;
            return RedirectToAction ("Welcomepage", "Home");
        }
        
        [Authorize]
        public IActionResult Logout () {
            HttpContext.Session.Remove ("JWTToken");
            return RedirectToAction ("Index","Home");
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}