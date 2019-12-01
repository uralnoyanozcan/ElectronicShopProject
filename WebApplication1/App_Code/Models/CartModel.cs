using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.App_Code.Models
{
    public class CartModel
    {
        public string InsertCart(Cart cart)
        {
            try
            {
                Model db = new Model();
                db.Cart.Add(cart);
                db.SaveChanges();

                return cart.Date + " successfully inserted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public string UpdateCart(int id, Cart cart)
        {
            try
            {
                Model db = new Model();
                Cart p = db.Cart.Find(id);
                p.Date = cart.Date;
                p.ID = cart.ID;
                p.IsInCart = cart.IsInCart;
                p.Product = cart.Product;
                p.ProductID = cart.ProductID;
                p.ClientID = cart.ClientID;
                p.Amount = cart.Amount;

                db.SaveChanges();

                return cart.Date + " successfully updated";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public string DeleteCart(int id, Cart cart)
        {
            try
            {
                Model db = new Model();
                Cart p = db.Cart.Find(id);

                db.Cart.Attach(cart);
                db.Cart.Remove(cart);
                db.SaveChanges();

                return cart.Date + " successfully deleted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

    }
}