using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Collections;
using WebApplication1.App_Code;
using WebApplication1.App_Code.Models;

namespace WebApplication1.Pages.Management
{
    public partial class ManageProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getImages();
                if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    FillPage(id);


                }
                    
            }

        }

        private void FillPage(int id)
        {
            ProductModel productModel = new ProductModel();
            Products product = productModel.GetProduct(id);

            txtDescription.Text = product.Description;
            txtName.Text = product.Name;
            txtPrice.Text = product.Price.ToString();

            ddlImage.SelectedValue = product.Image;
            ddlType.SelectedValue = product.TypeID.ToString();

        }

        private void getImages()
        {
            try
            {
                string[] images = Directory.GetFiles(Server.MapPath("~/Images/Products/"));

                ArrayList imageList = new ArrayList();
                foreach(string image in images)
                {
                    string imageName = image.Substring(image.LastIndexOf(@"\", StringComparison.Ordinal) + 1);
                    imageList.Add(imageName);
                }

                ddlImage.DataSource = imageList;
                ddlImage.AppendDataBoundItems = true;
                ddlImage.DataBind();

            }
            catch(Exception e)
            {
                lblResult.Text = e.ToString();
            }
        }

        private Products createProduct()
        {
            Products product = new Products();

            product.Name = txtName.Text;
            product.Price = Convert.ToDecimal(txtPrice.Text);
            product.TypeID = Convert.ToInt32(ddlType.SelectedValue);
            product.Description = txtDescription.Text;
            product.Image = ddlImage.SelectedValue;

            return product;
        } 






        protected void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ProductModel productModel = new ProductModel();
            Products product = createProduct();

            if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                //ID exist
                int id = Convert.ToInt32(Request.QueryString["id"]);
                lblResult.Text = productModel.UpdateProduct(id, product);
            }
            else
            {
                lblResult.Text = productModel.InsertProduct(product);
            }
        }
    }
}