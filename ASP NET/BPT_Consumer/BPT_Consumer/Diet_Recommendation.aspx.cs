using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BPT_Consumer
{
    public partial class Diet_Recommendation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            TableRow r = new TableRow();
            TableCell c = new TableCell();
            c.Text = "Days";
            r.Cells.Add(c);
            c = new TableCell();
            c.Text = "Meal 1";
            r.Cells.Add(c);
            c = new TableCell();
            c.Text = "Meal 2";
            r.Cells.Add(c);
            c = new TableCell();
            c.Text = "Meal 3";
            r.Cells.Add(c);
            Table1.Rows.Add(r);



            int blood_pressure = Global.user.bloodPressure;
            if (blood_pressure <= 90)
            {
                //low pressure plan
                r = new TableRow();
                c = new TableCell();
                c.Text = "Day 1";
                r.Cells.Add(c);
                c = new TableCell();
                c.Text = "1 cup milk and 1 apple ";
                r.Cells.Add(c);
                c = new TableCell();
                c.Text = "300gm meat and 300gm rice";
                r.Cells.Add(c);
                c = new TableCell();
                c.Text = "8 ricecake 20gm peanut";
                r.Cells.Add(c);
                Table1.Rows.Add(r);


                r = new TableRow();
                c = new TableCell();
                c.Text = "Day 2";
                r.Cells.Add(c);
                c = new TableCell();
                c.Text = "1 cup milk and 1 apple ";
                r.Cells.Add(c);
                c = new TableCell();
                c.Text = "300gm chicken and 300gm potato";
                r.Cells.Add(c);
                c = new TableCell();
                c.Text = "8 ricecake 20gm raw almonds";
                r.Cells.Add(c);
                Table1.Rows.Add(r);

                r = new TableRow();
                c = new TableCell();
                c.Text = "Day 3";
                r.Cells.Add(c);
                c = new TableCell();
                c.Text = "1 cup milk and 1 apple and 20gm nuts ";
                r.Cells.Add(c);
                c = new TableCell();
                c.Text = "300gm meat and 300gm sweet potato";
                r.Cells.Add(c);
                c = new TableCell();
                c.Text = "8 ricecake 20gm peanut";
                r.Cells.Add(c);
                Table1.Rows.Add(r);
               
            }
            else if (blood_pressure > 90 && blood_pressure <= 140)
            {
                //normal 
                r = new TableRow();
                c = new TableCell();
                c.Text = "Day 1";
                r.Cells.Add(c);
                c = new TableCell();
                c.Text = "2 cup milk and 2 apples ";
                r.Cells.Add(c);
                c = new TableCell();
                c.Text = "500gm meat and 400gm rice";
                r.Cells.Add(c);
                c = new TableCell();
                c.Text = "10 ricecake 30gm peanut";
                r.Cells.Add(c);
                Table1.Rows.Add(r);


                r = new TableRow();
                c = new TableCell();
                c.Text = "Day 2";
                r.Cells.Add(c);
                c = new TableCell();
                c.Text = "2 cup milk and 2 apples ";
                r.Cells.Add(c);
                c = new TableCell();
                c.Text = "500gm chicken and 400gm potato";
                r.Cells.Add(c);
                c = new TableCell();
                c.Text = "10 ricecake 40gm raw almonds";
                r.Cells.Add(c);
                Table1.Rows.Add(r);

                r = new TableRow();
                c = new TableCell();
                c.Text = "Day 3";
                r.Cells.Add(c);
                c = new TableCell();
                c.Text = "2 cup milk and 2 apples and 30gm nuts ";
                r.Cells.Add(c);
                c = new TableCell();
                c.Text = "400gm meat and 400gm sweet potato";
                r.Cells.Add(c);
                c = new TableCell();
                c.Text = "10 ricecake 30gm peanut";
                r.Cells.Add(c);
                Table1.Rows.Add(r);
            }
            else
            {
                //abnormal
                r = new TableRow();
                c = new TableCell();
                c.Text = "Day 1";
                r.Cells.Add(c);
                c = new TableCell();
                c.Text = "1 cup milk and 2 apples ";
                r.Cells.Add(c);
                c = new TableCell();
                c.Text = "200gm meat and 400gm rice";
                r.Cells.Add(c);
                c = new TableCell();
                c.Text = "5 ricecake 30gm peanut";
                r.Cells.Add(c);
                Table1.Rows.Add(r);


                r = new TableRow();
                c = new TableCell();
                c.Text = "Day 2";
                r.Cells.Add(c);
                c = new TableCell();
                c.Text = "1 cup milk and 2 apples ";
                r.Cells.Add(c);
                c = new TableCell();
                c.Text = "200gm chicken and 400gm potato";
                r.Cells.Add(c);
                c = new TableCell();
                c.Text = "5 ricecake 40gm raw almonds";
                r.Cells.Add(c);
                Table1.Rows.Add(r);

                r = new TableRow();
                c = new TableCell();
                c.Text = "Day 3";
                r.Cells.Add(c);
                c = new TableCell();
                c.Text = "1 cup milk and 2 apples and 30gm nuts ";
                r.Cells.Add(c);
                c = new TableCell();
                c.Text = "200gm meat and 400gm sweet potato";
                r.Cells.Add(c);
                c = new TableCell();
                c.Text = "5 ricecake 30gm peanut";
                r.Cells.Add(c);
                Table1.Rows.Add(r);
            }

        }

        protected void Back_btn_Click(object sender, EventArgs e)
        {
            //go to main form 
         //   Server.Transfer(".aspx", false);
            Table1.Rows.Clear();

        }
    }
}