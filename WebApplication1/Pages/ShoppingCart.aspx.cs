using Microsoft.AspNet.Identity;
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
    public partial class ShoppingCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userId = User.Identity.GetUserId();
            GetPurchacesInCart(userId);
        }
        private void GetPurchacesInCart(string userId)
        {
            CartModel model = new CartModel();
            double subTotal = 0;

            List<Cart> pList = model.GetOrdesInCart(userId);
            CreateShopTable(pList,out double subTotal);

            double vat = subTotal*0.21;
        }
    }
}