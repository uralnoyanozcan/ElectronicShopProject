using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.App_Code;

namespace WebApplication1.Pages.Account
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            UserModel1 db = new UserModel1();
            List<UserTable> users = getAllUsers();
            foreach(UserTable user in users)
            {
                

                if (user.userName == txtUsername.Text)
                {
                    string enteredPassword = "" + txtPasswordLog.Text;
                    string userPassword = "" + user.password.TrimEnd();
                    if(string.Equals(userPassword, enteredPassword))
                    {
                        lblResult.Text = "Log in successful!";
                        Session["user"] = user.userID;
                        Response.Redirect("/Index.aspx");
                        return;
                    }
                    else
                    {
                        lblResult.Text = userPassword.Length +" "+ enteredPassword.Length;
                        return;
                    }
                }
            }
            lblResult.Text = "user not found";

        }

        public List<UserTable> getAllUsers()
        {
            try
            {
                using (UserModel1 db = new UserModel1())
                {
                    List<UserTable> users = (from x in db.UserTable select x).ToList();
                    return users;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}