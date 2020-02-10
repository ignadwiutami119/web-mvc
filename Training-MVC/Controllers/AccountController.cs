using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Task_Web_Product.Models;

namespace Task_Web_Product.Controllers {
    [Route ("account")]
    [ApiController]
    public class AccountControllers : ControllerBase {

        public AppDbContext _appDbContext;
        private IConfiguration Configuration;
        public AccountControllers (AppDbContext appDBContext, IConfiguration configuration) {
            _appDbContext = appDBContext;
            Configuration = configuration;
        }

        [Authorize]
        [HttpGet ("welcome")]
        public IActionResult welcome () {
            var token = System.IO.File.ReadAllText ("Token.txt");
            var JwtSecurityTokenHandler = new JwtSecurityTokenHandler ();
            var securityToken = JwtSecurityTokenHandler.ReadToken (token) as JwtSecurityToken;
            var email = securityToken?.Claims.First (Claim => Claim.Type == "email").Value;
            var sub = securityToken?.Claims.First (Claim => Claim.Type == "sub").Value;
            var jti = securityToken?.Claims.First (Claim => Claim.Type == "jti").Value;

            if (securityToken == null) {
                return Unauthorized ();
            }

            return Ok (new {
                message = "Welcome"
            });
        }


        [HttpPost ("login")]
        public IActionResult Login ([FromBody] AccountModel input) {
            IActionResult response = Unauthorized ();
            var user = AuthenticatedUser (input);
            if (user != null) {
                var token = GenerateJwtToken (user);
                TextWriter tkn = new StreamWriter ("Token.txt", true);
                tkn.WriteLine (token);
                tkn.Close ();
                return Ok (new { token = token });
            }
            return View ("Login");
        }

        private IActionResult View(string v)
        {
            throw new NotImplementedException();
        }

        private AccountModel AuthenticatedUser (AccountModel input) {
            AccountModel user = null;
            var db = from x in _appDbContext.account select new { id = x.id, uname = x.username, pass = x.password };
            foreach (var data in db) {
                if (input.username == data.uname && input.password == data.pass) {
                    user = new AccountModel {
                    id = data.id,
                    username = input.username,
                    password = input.password
                    };
                    return user;
                }
            }
            return user;
        }

        private object GenerateJwtToken (AccountModel user) {
            var securityKey = new SymmetricSecurityKey (System.Text.Encoding.UTF8.GetBytes (Configuration["Jwt:Key"]));
            var credentials = new SigningCredentials (securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new [] {
                new Claim (JwtRegisteredClaimNames.Sub, Convert.ToString (user.id)),
                new Claim (JwtRegisteredClaimNames.Jti, Guid.NewGuid ().ToString ()),
            };
            var token = new JwtSecurityToken (
                issuer: Configuration["Jwt:Issuer"],
                audience : Configuration["Jwt:Audience"],
                claims,
                expires : DateTime.Now.AddMinutes (120),
                signingCredentials : credentials
            );

            var encodedToken = new JwtSecurityTokenHandler ().WriteToken (token);
            return encodedToken;
        }
    }
}