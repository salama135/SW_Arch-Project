using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BPT_Consumer
{
    public partial class Workout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Global.userInfo.height == 0) return;

            double bmi = (Global.userInfo.weight / Global.userInfo.height / Global.userInfo.height) * 10000;
            //double bmi = 23.4;
            if (bmi < 18.5)
            {
                //under weight
                tabel2.Rows[2].Cells[1].InnerText = "Chest press 4x12 ,Bench press 3x12,cabel cross 4x12,incline dumbell press 3x10";
                tabel2.Rows[3].Cells[1].InnerText = "latpull down 4x12, T-bar 4x12,bentover row 10x3,dead lift 10x3,Row 4x12";
                tabel2.Rows[4].Cells[1].InnerText = "dumbell shoulder press 4x12,up right row 4x12,Row machine 4x12";
                tabel2.Rows[5].Cells[1].InnerText = "z bar curl 6x12,cable biceps 4x12,skull cruch 5x15";
                tabel2.Rows[6].Cells[1].InnerText = "squats 4x12,leg extensions 4x12,lunges 4x12,calfs 10x4";

            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                //normal weight
                tabel2.Rows[2].Cells[1].InnerText = " 10 min cardio,Chest press 4x12 ,Bench press 3x12,cabel cross 4x12,incline dumbell press 3x10";
                tabel2.Rows[3].Cells[1].InnerText = "leg raises,side plank,half crunches (4x12),latpull down 4x12, T-bar 4x12,bentover row 10x3,dead lift 10x3,Row 4x12";
                tabel2.Rows[4].Cells[1].InnerText = "10 min cardio,dumbell shoulder press 4x12,up right row 4x12,Row machine 4x12";
                tabel2.Rows[5].Cells[1].InnerText = "leg raises,side plank,half crunches (4x12),z bar curl 6x12,cable biceps 4x12,skull cruch 5x15";
                tabel2.Rows[6].Cells[1].InnerText = "10 min cardio,squats 4x12,leg extensions 4x12,lunges 4x12,calfs 10x4";
            }
            else
            {
                //over weight
                tabel2.Rows[2].Cells[1].InnerText = " 30 min cardio,Chest press 4x12 ,Bench press 3x12,cabel cross 4x12,incline dumbell press 3x10";
                tabel2.Rows[3].Cells[1].InnerText = "leg raises,side plank,half crunches (6x12),latpull down 4x12, T-bar 4x12,bentover row 10x3,dead lift 10x3,Row 4x12";
                tabel2.Rows[4].Cells[1].InnerText = "30 min cardio,dumbell shoulder press 4x12,up right row 4x12,Row machine 4x12";
                tabel2.Rows[5].Cells[1].InnerText = "leg raises,side plank,half crunches (6x12),z bar curl 6x12,cable biceps 4x12,skull cruch 5x15";
                tabel2.Rows[6].Cells[1].InnerText = "30 min cardio,squats 4x12,leg extensions 4x12,lunges 4x12,calfs 10x4";
            }
        }

        protected void SignOut(object sender, EventArgs e)
        {
            Global.user = null;
            Global.userInfo = null;
            Response.Redirect("Default.aspx");
        }
    }
}