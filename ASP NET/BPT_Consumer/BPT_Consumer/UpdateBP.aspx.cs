using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BPT_Consumer
{
    public partial class UpdateBP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Save_btn.Width = 250;
            Save_btn.Height = 35;
        }

        protected void SignOut(object sender, EventArgs e)
        {
            Global.user = null;
            Global.userInfo = null;
            Response.Redirect("Default.aspx");
        }

        protected void Save_btn_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Trim().Length != 0)
            {
                try
                {
                    int BP = int.Parse(TextBox1.Text);
                    Global.service.AddBP(BP, Global.user.id);

                    Server.Transfer("Home.aspx", false);
                }
                catch (Exception ex)
                {
                    AlertBox.Visible = true;
                    return;
                }

            }
        }
    }
}