using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.App_Code;
using WebApplication1.App_Code.Models;

namespace WebApplication1.Pages
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillPage();
        }

        private void FillPage()
        {
            if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                ProductModel productModel = new ProductModel();
                Products product = productModel.GetProduct(id);

                lblPrice.Text = "Price per unit: <br/> " + product.Price + " TRY";
                lblTitle.Text = product.Name;
                lblDescription.Text = product.Description;
                lblItemNr.Text = id.ToString();
                imgProduct.ImageUrl = "~/Images/Products/" + product.Image;

                int[] amount = Enumerable.Range(1, 20).ToArray();
                ddlAmount.DataSource = amount;
                ddlAmount.AppendDataBoundItems = true;
                ddlAmount.DataBind();

            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                int clientID = Convert.ToInt32(Session["user"]);
                int id = Convert.ToInt32(Request.QueryString["id"]);
                int amount = Convert.ToInt32(ddlAmount.SelectedValue);

                Cart cart = new Cart();
                cart.Amount = amount;
                cart.ClientID = clientID;
                cart.IsInCart = true;
                cart.ProductID = id;
                cart.Date = DateTime.Now;

                

                CartModel cartModel = new CartModel();
                
                lblResult.Text = cartModel.InsertCart(cart);
               
            }
        }
    }
}