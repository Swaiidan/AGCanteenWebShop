using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AGCanteenWebshop.Models;

namespace AGCanteenWebshop.Controllers
{
    public class ProductController : Controller
    {
        private AGCanteenWebShopEntities db = new AGCanteenWebShopEntities();

        // GET: AllProdcts
        public ActionResult AllProduct()
        {
            var tbl_Product = db.Tbl_Product.Include(t => t.Tbl_ProductCategory);
            return View(tbl_Product.ToList());
        }


        //Get BreakFast from Category
        //[Authorize]
        public ViewResult BreakFast()
        {
            using (var context = new AGCanteenWebShopEntities())
            {
                var categoryid = from p in context.Tbl_Product
                                 where p.Fld_ProductCategoryID==3
                                 select p;
                return View(categoryid.ToList());
            }
        }


        //Get Cake from Category
       // [Authorize]
        public ActionResult Cake()
        {
            using (var context = new AGCanteenWebShopEntities())
            {
                var categoryid = from p in context.Tbl_Product
                                 where p.Fld_ProductCategoryID==2
                                 select p;
                return View(categoryid.ToList());
            }
        }



     //Get Fruit from Category
     //[Authorize]
     public ActionResult Fruit()
        {
            using (var context = new AGCanteenWebShopEntities())
            {
                var categoryid = from p in context.Tbl_Product
                                 where p.Fld_ProductCategoryID==1
                                 select p;
                return View(categoryid.ToList());
            }
        }



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
