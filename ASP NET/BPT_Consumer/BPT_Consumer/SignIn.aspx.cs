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

        protected void SignInButton_Click(object sender, EventArgs e)
        {
            string email = inputEmail.Value;
            string password = inputPassword.Value;
            try
            {
                BPT_Service.User user = new BPT_Service.User();
                BPT_Service.UserInfo userInfo = new BPT_Service.UserInfo();

                
                user = Global.service.SignIn(email, password);



                if (user != null)
                {
                    userInfo = Global.service.GetUserInfoById(user.id);
                }
                else
                {
                    AlertBox.Visible = true;
                    return;
                }




                if (user != null && userInfo != null)
                { 
                    Global.user = user;
                    Global.userInfo = userInfo;
                    //Server.Transfer("Home.aspx", false);
                    Response.Redirect("Home.aspx", false);
                }

            }catch(Exception ex)
            {
                AlertBox.Visible = true;
                return;
            }
 
        }
    }
}