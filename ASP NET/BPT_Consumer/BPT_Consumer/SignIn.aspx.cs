using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace BPT_Consumer
{
    public partial class SignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignInGoogle_Click(object sender, EventArgs e)
        {
            googleUser.login = true;
            string clientid = "497837756181-9pc27o2lso0jv5a782611ij4qadmfj7v.apps.googleusercontent.com";
            string clientsecret = "sMuPu_q3gBhT8JTXJ7jMelog";
            string redirection_url = "https://localhost:44304/Home";
            string url = "https://accounts.google.com/o/oauth2/v2/auth?scope=profile&include_granted_scopes=true&redirect_uri=" + redirection_url + "&response_type=code&client_id=" + clientid + "";
            Response.Redirect(url);
        }

        protected void SignInButton_Click(object sender, EventArgs e)
        {
            string email = inputEmail.Value;
            string password = inputPassword.Value;

            try
            {
                BPT_Service.UserInfo userInfo;
                BPT_Service.User user = user = Global.service.SignIn(email, password);

                if (user != null)
                {
                    userInfo = Global.service.GetUserInfoById(user.id);
                }
                else
                {
                    AlertBox.Visible = true;
                    return;
                }

                if (user.email != "" && user.password != "")
                {
                    Global.user = user;
                    Global.userInfo = userInfo;
                    Response.Redirect("Home.aspx", false);
                }
            }
            catch (Exception ex)
            {
                AlertBox.Visible = true;
                return;
            }
        }
    }
}