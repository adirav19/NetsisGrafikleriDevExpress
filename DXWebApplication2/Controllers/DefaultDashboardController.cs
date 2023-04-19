﻿using DevExpress.DashboardAspNetCore;
using DevExpress.DashboardWeb;
using DXWebApplication2.Models;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace DXWebApplication2.Controllers {
    public class DefaultDashboardController : DashboardController {
        public DefaultDashboardController(DashboardConfigurator configurator, IDataProtectionProvider? dataProtectionProvider = null)
            : base(configurator, dataProtectionProvider) {
        }

        public IActionResult Index()
        {

            return View();
        }
        /*[HttpPost]

        public async Task<IActionResult> Index(Giris p)
        {
            Context c = new Context();
            var datavalue = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail
            && x.WriterPass == p.WriterPass);
            if (datavalue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.WriterMail)
                };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                return View();
            }
        }*/
    }
}



