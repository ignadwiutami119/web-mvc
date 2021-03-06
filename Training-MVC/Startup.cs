using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using MVC.Data;
using Newtonsoft.Json;
using SignalR.SignalR;
using Stripe;
using Task_Web_Product.Controllers;
using Task_Web_Product.Models;

namespace MVC {
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices (IServiceCollection services) {
            services.Configure<StripeSettings> (Configuration.GetSection ("Stripe"));
            services.AddSignalR ();
            services.AddSession (options => {
                options.IdleTimeout = TimeSpan.FromMinutes (60);
            });
            services.AddMvc ().SetCompatibilityVersion (CompatibilityVersion.Version_3_0);

            // services.AddControllers().AddNewtonsoftJson(options =>
            // {
            //     options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            // });

            services.AddDbContext<AppDbContext> (options => {
                options.UseSqlServer (Configuration.GetConnectionString ("localhost"));
            });

            //Authentication
            services.AddAuthentication (options => {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer (options => {
                    options.RequireHttpsMetadata = false;
                    options.SaveToken = true;
                    options.TokenValidationParameters = new TokenValidationParameters () {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey (Encoding.UTF8.GetBytes (Configuration["Jwt:Key"])),
                        ValidateIssuer = false,
                        ValidateAudience = false,
                    };
                });

            services.AddControllersWithViews ();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IWebHostEnvironment env) {
            StripeConfiguration.SetApiKey (Configuration.GetSection ("Stripe") ["SecretKey"]);
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            } else {
                app.UseExceptionHandler ("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts ();
            }
            app.UseHttpsRedirection ();
            app.UseStaticFiles ();
            app.UseRouting ();

            app.UseCookiePolicy ();

            //Add User session
            app.UseSession ();

            //Add JWToken to all incoming HTTP Request Header
            app.Use (async (context, next) => {
                var JWToken = context.Session.GetString ("JWTToken");
                Console.WriteLine ("==================================");
                Console.WriteLine (JWToken);
                Console.WriteLine ("==================================");

                if (!string.IsNullOrEmpty (JWToken)) {
                    context.Request.Headers.Add ("Authorization", "Bearer " + JWToken);
                }
                await next ();
            });

            app.UseAuthentication ();
            app.UseAuthorization ();

            app.UseEndpoints (endpoints => {
                endpoints.MapControllerRoute (
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");;

                endpoints.MapHub<ChatHub> ("/chatHub");
                endpoints.MapHub<PaymentHub> ("/paymentHub");
            });
        }
    }
}