using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.App_Code.Models
{

    public class ProductModel
    {
        public string InsertProduct(Products product)
        {
            try
            {
                Model db = new Model();
                db.Product.Add(product);
                db.SaveChanges();

                return product.Name + " successfully inserted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public string UpdateProduct(int id,Products product)
        {
            try
            {
                Model db = new Model();
                Products p = db.Product.Find(id);
                p.Name = product.Name;
                p.Price = product.Price;
                p.Description = product.Description;
                p.Image = product.Image;
                db.SaveChanges();

                return product.Name + " successfully updated";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public string DeleteProduct(int id, Products product)
        {
            try
            {
                Model db = new Model();
                Products p = db.Product.Find(id);

                db.Product.Attach(product);
                db.Product.Remove(product);
                db.SaveChanges();

                return product.Name + " successfully deleted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public Products GetProduct(int id)
        {
            try
            {
                using (Model db = new Model())
                {
                    Products product = db.Product.Find(id);
                    return product;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Products> getAllProducts()
        {
            try
            {
                using (Model db = new Model())
                {
                    List<Products> products = (from x in db.Product select x).ToList();
                    return products;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public  List<Products> GetProductsByType(int typeId)
        {
            try
            {
                using (Model db = new Model())
                {
                    List<Products> products = (from x in db.Product where x.TypeID == typeId select x).ToList();
                    return products;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}