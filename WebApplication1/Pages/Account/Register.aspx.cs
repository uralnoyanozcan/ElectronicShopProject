using System;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using WebApplication1.App_Code;
using WebApplication1.App_Code.Models;

namespace WebApplication1.Pages.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                
                UserModel1 db = new UserModel1();
                UserTable user = new UserTable();
                user.userName = txtUserName.Text;
                user.password = txtPassword.Text;
                db.UserTable.Add(user);
                db.SaveChanges();
                lblResult.Text = "succesfully registered";
                Response.Write("You can log in now");
                Response.Redirect("/Pages/Account/Login.aspx");
            }
            else
            {
                lblResult.Text = "Passwords do not match";
            }

        }
    }
}