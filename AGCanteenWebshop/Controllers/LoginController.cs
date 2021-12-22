using AGCanteenWebshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AGCanteenWebshop.Controllers
{
    public class LoginController : Controller
    {
        private AGCanteenWebShopEntities db = new AGCanteenWebShopEntities();

        // GET: Login
       
        public ActionResult Login(Tbl_Customer log)
        {
            var customer = db.Tbl_Customer.Where(x => x.Fld_CustomerID == log.Fld_CustomerID).Count();

            if (customer > 0)
            {

                return RedirectToAction("AllProduct", "Product");
            }
            else
            {
                return View();
            }
        }
        public ActionResult Register()
        {
            return View();
        
        }
        [HttpPost]
        [Authorize]
        public ActionResult Register(Tbl_Customer customer)
        {
            using (var db = new AGCanteenWebShopEntities())
            {
                db.Tbl_Customer.Add(customer);
                ModelState.Clear();
            }
                return View();

        }
    }
}