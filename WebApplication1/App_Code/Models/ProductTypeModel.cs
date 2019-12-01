using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.App_Code.Models
{
    public class ProductTypeModel
    {
        public string InsertProductType(ProductType productType)
        {
            try
            {
                Model db = new Model();
                db.ProductType.Add(productType);
                db.SaveChanges();

                return productType.Name + " successfully inserted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public string UpdateProductType(int id, ProductType productType)
        {
            try
            {
                Model db = new Model();
                ProductType p = db.ProductType.Find(id);
                p.Name = productType.Name;
                

                db.SaveChanges();

                return productType.Name + " successfully updated";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public string DeleteProductType(int id, ProductType productType)
        {
            try
            {
                Model db = new Model();
                ProductType p = db.ProductType.Find(id);

                db.ProductType.Attach(productType);
                db.ProductType.Remove(productType);
                db.SaveChanges();

                return productType.Name + " successfully deleted";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }
    }
}