using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BPT_Consumer
{
    public partial class UserInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            inputUsername.Value = Global.userInfo.name;
            inputAge.Value = Global.userInfo.age.ToString();
            inputWeight.Value = Global.userInfo.weight.ToString();
            inputHeight.Value = Global.userInfo.height.ToString();

            inputEmail.Value = Global.user.email;
            inputPassword.Value = Global.user.password;

            if (Global.userInfo.gender == "Male")
                inputMale.Checked = true;
            else
                inputMale.Checked = false;
                
            if (Global.userInfo.gender == "Female")
                inputFemale.Checked = true;
            else
                inputFemale.Checked = false;
        }

        protected void SignOut(object sender, EventArgs e)
        {
            Global.user = null;
            Global.userInfo = null;
            Response.Redirect("Default.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BPT_Service.User user = new BPT_Service.User();
            BPT_Service.UserInfo userInfo = new BPT_Service.UserInfo();

            user.email = String.Format("{0}", Request.Form["inputEmail"]);
            user.password = String.Format("{0}", Request.Form["inputPassword"]);

            userInfo.name = String.Format("{0}", Request.Form["inputUsername"]);
            userInfo.age = int.Parse(String.Format("{0}", Request.Form["inputAge"]));
            userInfo.weight = int.Parse(String.Format("{0}", Request.Form["inputWeight"]));
            userInfo.weight = int.Parse(String.Format("{0}", Request.Form["inputHeight"]));

            if (inputMale.Checked)
                userInfo.gender = "Male";
            else if (inputFemale.Checked)
                userInfo.gender = "Female";
            else
                userInfo.gender = " ";

            try
            {                
                Global.user = Global.service.UpdateUser(Global.user.id, user);
                Global.userInfo = Global.service.UpdateUserInfo(Global.user.id, userInfo);
            }
            catch (Exception ex)
            {
                AlertBox.InnerText = "Something went wrong!";
                AlertBox.Visible = true;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Global.service.DeleteUser(Global.user.id);
                Global.service.DeleteUserInfo(Global.user.id);
            }
            catch (Exception ex)
            {
                AlertBox.InnerText = "Something went wrong!";
                AlertBox.Visible = true;
            }

            Server.Transfer("Default.aspx", false);
        }
    }
}