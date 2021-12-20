using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AGCanteenWebshop.Models;

namespace AGCanteenWebshop.Controllers
{
    public class Item
    {
        private Tbl_Product product = new Tbl_Product();
        private int quantity;

        public Item()
        {

        }
        public Item(Tbl_Product product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }

        public Tbl_Product Product { get => product; set => product=value; }
        public int Quantity { get => quantity; set => quantity=value; }

    }
}
