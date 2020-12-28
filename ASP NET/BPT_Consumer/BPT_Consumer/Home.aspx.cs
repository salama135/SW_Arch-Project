using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using System.Windows;

namespace BPT_Consumer
{
    public partial class Home : System.Web.UI.Page
    {
        public List<int> cols = new List<int>();
        public List<string> rows = new List<string>();

        protected void SignOut(object sender, EventArgs e)
        {
            Global.user = null;
            Global.userInfo = null;
            Response.Redirect("Default.aspx");
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            var x = Global.service.GetBloodPressures(Global.user.id);
            var sortedList = x.OrderBy(si => si.Date).ToList();


            foreach (var pressure in sortedList)
            {
                rows.Add(pressure.Date.ToString());
                cols.Add(pressure.Value);
            }

            

            JavaScriptSerializer jss = new JavaScriptSerializer();
            this.Hidden_cols.Value = jss.Serialize(cols);
            this.Hidden_rows.Value = jss.Serialize(rows);
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}