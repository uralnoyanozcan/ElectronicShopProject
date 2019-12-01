using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using WebApplication1.App_Code;
using WebApplication1.App_Code.Models;

namespace WebApplication1.Pages.Management
{
    
    public partial class ManageProductTypes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ProductTypeModel model = new ProductTypeModel();
            ProductType pt = createProductType();
            lblResult.Text = model.InsertProductType(pt);
        }

        private ProductType createProductType()
        {
            ProductType p = new ProductType();
            p.Name = txtName.Text;
            return p;
        }

        
    }






}
