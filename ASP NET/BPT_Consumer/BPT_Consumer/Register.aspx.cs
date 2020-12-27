using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BPT_Consumer.BPT_Service;

namespace BPT_Consumer
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            BPT_Service.User user = new User();

            string email = inputEmail.Value;
            string password = inputPassword.Value;
            string confirmPassword = inputConfirmPassword.Value;

            if (password != confirmPassword)
            {
                AlertBox.InnerText = "passwords don't match !";
                AlertBox.Visible = true;

                return;
            }
            else
            {
                user.email = email;
                user.password = password;
            }

            AlertBox.Visible = false;

            try
            {
                user = Global.service.CreateUser(user);
                Global.user = user;

                Server.Transfer("Home.aspx", false);
            }
            catch (Exception ex)
            {
                AlertBox.InnerText = "Something when wrong please check the email and password !";
                AlertBox.Visible = true;
            }
        }
    }
}