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


            table1.Rows[2].Cells[1].InnerText = "test";
             

            //int blood_pressure = Global.userInfo.bloodPressure;
            int blood_pressure = 50;
            if (blood_pressure <= 90)
            {
                //low pressure plan
                //day1

                table1.Rows[2].Cells[1].InnerText = "1 cup milk and 1 apple ";

                table1.Rows[2].Cells[2].InnerText = "300gm meat and 300gm rice";
                table1.Rows[2].Cells[3].InnerText = "100gm rice and 100gm fish ";

                table1.Rows[2].Cells[4].InnerText  = "8 ricecake 20gm peanut";

                //day2

                table1.Rows[3].Cells[1].InnerText = "1 cup milk and 1 apple ";

                table1.Rows[3].Cells[2].InnerText = "300gm chicken and 300gm potato";
                table1.Rows[3].Cells[3].InnerText = "50gm rice and 100gm bean";

                table1.Rows[3].Cells[4].InnerText = "8 ricecake 20gm raw almonds";

                //day3

                table1.Rows[4].Cells[1].InnerText = "1 cup milk and 1 apple and 20gm nuts ";

                table1.Rows[4].Cells[2].InnerText = "300gm meat and 300gm sweet potato";

                table1.Rows[4].Cells[3].InnerText = "60gm beans and 50gm rice ";

                table1.Rows[4].Cells[4].InnerText = "8 ricecake 20gm peanut";

                //day4
                table1.Rows[5].Cells[1].InnerText = "1 cup milk and 1 apple ";

                table1.Rows[5].Cells[2].InnerText = "200gm fish and 100gm rice";
                table1.Rows[5].Cells[3].InnerText = "100gm rice and 100gm potato ";

                table1.Rows[5].Cells[4].InnerText = "8 ricecake 20gm peanut";


            }
            else if (blood_pressure > 90 && blood_pressure <= 140)
            {
                //normal 


                table1.Rows[2].Cells[1].InnerText = "2 cup milk and 2 apples ";

                table1.Rows[2].Cells[2].InnerText = "500gm meat and 400gm rice";

                table1.Rows[2].Cells[3].InnerText = "150gm rice and 150gm fish "; 

                table1.Rows[2].Cells[4].InnerText = "10 ricecake 30gm peanut";



                table1.Rows[3].Cells[1].InnerText = "2 cup milk and 2 apples ";

                table1.Rows[3].Cells[2].InnerText = "250gm chicken and 90gm potato";

                table1.Rows[3].Cells[3].InnerText = "100gm rice and 100gm bean";

                table1.Rows[3].Cells[4].InnerText = "10 ricecake 40gm raw almonds";



                table1.Rows[4].Cells[1].InnerText = "2 cup milk and 2 apples and 30gm nuts ";

                table1.Rows[4].Cells[2].InnerText = "200gm meat and 100gm sweet potato";

                table1.Rows[4].Cells[3].InnerText = "80gm beans and 90gm rice ";

                table1.Rows[4].Cells[4].InnerText = "10 ricecake 30gm peanut";



                table1.Rows[5].Cells[1].InnerText = "2 cup milk and 2 apples ";

                table1.Rows[5].Cells[2].InnerText = "200gm meat and 100gm sweet potato";

                table1.Rows[5].Cells[3].InnerText = "80gm beans  ";

                table1.Rows[5].Cells[4].InnerText = "10 ricecake 30gm peanut";
            }
            else
            {
                //abnormal

                table1.Rows[2].Cells[1].InnerText = "1 cup milk and 2 apples ";

                table1.Rows[2].Cells[2].InnerText = "100gm meat and 300gm rice";

                table1.Rows[2].Cells[3].InnerText = "150gm rice";

                table1.Rows[2].Cells[4].InnerText = "5 ricecake 30gm peanut";




                table1.Rows[3].Cells[1].InnerText = "1 cup milk and 2 apples ";

                table1.Rows[3].Cells[2].InnerText = "50gm chicken and 400gm potato";
                table1.Rows[3].Cells[3].InnerText = "80gm beans and 90gm rice ";

                table1.Rows[3].Cells[4].InnerText ="5 ricecake 40gm raw almonds";



                table1.Rows[4].Cells[1].InnerText ="1 cup milk and 2 apples and 30gm nuts ";

                table1.Rows[4].Cells[2].InnerText = "100gm meat and 300gm sweet potato";

                table1.Rows[4].Cells[3].InnerText = "100gm rice and 100gm bean";
                table1.Rows[4].Cells[4].InnerText = "5 ricecake 30gm peanut";

                table1.Rows[5].Cells[1].InnerText = "1 cup milk and 1 apples ";

                table1.Rows[5].Cells[2].InnerText = "50gm chicken and 200gm sweet potato";
                table1.Rows[5].Cells[3].InnerText = "80gm beans and 90gm rice ";

                table1.Rows[5].Cells[4].InnerText = "5 ricecake ";

            }
            

        }

        /*
        protected void Back_btn_Click(object sender, EventArgs e)
        {
            //go to main form 
            //Server.Transfer(".aspx", false);
            Table1.Rows.Clear();
        }
        */
    }
}