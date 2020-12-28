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


        protected void SignUpGoogle_Click(object sender, EventArgs e)
        {

            googleUser.register = true;
            string clientid = "497837756181-9pc27o2lso0jv5a782611ij4qadmfj7v.apps.googleusercontent.com";
            string clientsecret = "sMuPu_q3gBhT8JTXJ7jMelog";
            string redirection_url = "https://localhost:44304/Home";
            string url = "https://accounts.google.com/o/oauth2/v2/auth?scope=profile&include_granted_scopes=true&redirect_uri=" + redirection_url + "&response_type=code&client_id=" + clientid + "";
            Response.Redirect(url);

           
        }


        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            string email = inputEmail.Value;
            string password = inputPassword.Value;
            string confirmPassword = inputConfirmPassword.Value;

            if (Global.service.Register(email, password) == false)
            {
                AlertBox.InnerText = "Email already registered !";
                AlertBox.Visible = true;
                return;
            }

            BPT_Service.User user = new BPT_Service.User();
            BPT_Service.UserInfo userInfo = new BPT_Service.UserInfo();

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
                
                userInfo.id = user.id;
                userInfo.name = "";
                userInfo.gender = "";
                userInfo.age = 0;
                userInfo.weight = 0;
                userInfo.bloodPressure = 0;

                userInfo = Global.service.CreateUserInfo(userInfo);
                Global.userInfo = userInfo;

                Server.Transfer("Home.aspx", false);
            }
            catch (Exception ex)
            {
                AlertBox.InnerText = "Something went wrong please check the email and password !";
                AlertBox.Visible = true;
                return;
            }
        }
    }
}