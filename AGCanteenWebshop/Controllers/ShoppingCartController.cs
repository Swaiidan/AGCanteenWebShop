using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AGCanteenWebshop.Models;


namespace AGCanteenWebshop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private AGCanteenWebShopEntities db = new AGCanteenWebShopEntities();

        public ActionResult Cart()
        {
            return View("Cart");
        }

        //If Item exist, create new in same row
        private int Exist (int id)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            for (int i = 0; i<cart.Count; i++)
                if (cart[i].Product.Fld_ProductID== id)
                    return i;
            return -1;
        }

        //Delete an item from the Cart
        public ActionResult Delete(int id)
        {
            int index = Exist(id);
            List<Item> cart = (List<Item>)Session["cart"];
            cart.RemoveAt(index);
            Session["cart"] = cart;
            return View("Cart");
        }


        //Add an item to the cart
        public ActionResult Buy(int id)
        {
            if (Session["cart"] == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item(db.Tbl_Product.Find(id), 1));
                Session["cart"] = cart;

            }
            else
            {
                List<Item> cart = (List<Item>)Session["cart"];
                int index = Exist(id);
                if (index == -1)
                    cart.Add(new Item(db.Tbl_Product.Find(id), 1));
                else
                    cart[index].Quantity++;
                Session["cart"] = cart;
            }
            return View("Cart");
        }
    }
}
