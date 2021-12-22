using AGCanteenWebshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace AGCanteenWebshop
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            using (var db = new AGCanteenWebShopEntities()) 
            {
                if (db.Tbl_CustomerRole.Count()==0)
                {
                    var role1 = new Tbl_CustomerRole();
                    var role2 = new Tbl_CustomerRole();
                    role1.Fld_RoleName = "User";
                    role2.Fld_RoleName = "Admin";
                    db.Tbl_CustomerRole.Add(role1);
                    db.Tbl_CustomerRole.Add(role2);
                   
                }
            
            }


                AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
