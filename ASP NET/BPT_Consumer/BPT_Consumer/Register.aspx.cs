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

        protected void Button1_Click1(object sender, EventArgs e)
        {
            BPT_Service.User user = new User();
           
            user.name = TextBox1.Text;
            user.age = int.Parse(TextBox2.Text);
            user.weight = int.Parse(TextBox3.Text);
            user.bloodPressure = int.Parse(TextBox4.Text);
            user.gender = TextBox5.Text;
            user.email = TextBox6.Text;
            user.password = TextBox7.Text;

            bool OK = true;

            try
            {
                Global.service.Create(user);
            }
            catch (Exception ex)
            {
                OK = false;

            }

            if (OK)
            {
                Global.user = user;
                Server.Transfer("Home.aspx", false);
            }
            else
            {
                Server.Transfer("Register.aspx", false);
            }
        }
    }
}