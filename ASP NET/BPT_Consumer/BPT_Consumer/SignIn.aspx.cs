using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

            BPT_Service.User user = Global.service.SignIn(email, password);           
            BPT_Service.UserInfo userInfo = Global.service.GetUserInfoById(user.id);
            
            if(user != null && userInfo != null)
            {
                Global.user = user;
                Global.userInfo = userInfo;
                Server.Transfer("Home.aspx", false);
            }
            else
            {
                AlertBox.Visible = true;
            }
        }
    }
}