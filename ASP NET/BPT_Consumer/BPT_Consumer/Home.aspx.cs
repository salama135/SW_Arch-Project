using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
namespace BPT_Consumer
{
    public partial class Home : System.Web.UI.Page
    {
      


        string clientid = "497837756181-9pc27o2lso0jv5a782611ij4qadmfj7v.apps.googleusercontent.com";
        string clientsecret = "sMuPu_q3gBhT8JTXJ7jMelog";
        string redirection_url = "https://localhost:44304/Home";
        string url = "https://accounts.google.com/o/oauth2/token";

        protected void Page_Load(object sender, EventArgs e)
        {
            
         

            if (!IsPostBack)
            {
                if (Request.QueryString["code"] != null)
                {
                    GetToken(Request.QueryString["code"].ToString());
                }
            }

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void GetToken(string code)
        {
            string poststring = "grant_type=authorization_code&code=" + code + "&client_id=" + clientid + "&client_secret=" + clientsecret + "&redirect_uri=" + redirection_url + "";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/x-www-form-urlencoded";
            request.Method = "POST";
            UTF8Encoding utfenc = new UTF8Encoding();
            byte[] bytes = utfenc.GetBytes(poststring);
            Stream outputstream = null;
            try
            {
                request.ContentLength = bytes.Length;
                outputstream = request.GetRequestStream();
                outputstream.Write(bytes, 0, bytes.Length);
            }
            catch { }
            var response = (HttpWebResponse)request.GetResponse();
            var streamReader = new StreamReader(response.GetResponseStream());
            string responseFromServer = streamReader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Tokenclass obj = js.Deserialize<Tokenclass>(responseFromServer);
            GetuserProfile(obj.access_token);
        }
        public void GetuserProfile(string accesstoken)
        {
            string url = "https://www.googleapis.com/oauth2/v1/userinfo?alt=json&access_token=" + accesstoken + "";
            WebRequest request = WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            response.Close();

           
            
            JavaScriptSerializer js = new JavaScriptSerializer();
            googleUser googleUserInfo = js.Deserialize<googleUser>(responseFromServer);


          


             if(googleUser.register)
            {
                if(Global.service.Register(googleUserInfo.email, md5.MD5Hash(googleUserInfo.email)) == false)
                {
                    googleUser.login = true;
                }
                else
                {
                    BPT_Service.User user = new BPT_Service.User();
                    BPT_Service.UserInfo userInfo = new BPT_Service.UserInfo();
                    user.email = googleUserInfo.email;
                    user.password = md5.MD5Hash(googleUserInfo.email);

                    user = Global.service.CreateUser(user);
                    Global.user = user;
                 
                    userInfo.id = user.id;
                    userInfo.name = googleUserInfo.given_name + " " + googleUserInfo.family_name;
                    userInfo.gender = "";
                    userInfo.age = 0;
                    userInfo.weight = 0;
                    userInfo.bloodPressure = 0;

                  

                    userInfo = Global.service.CreateUserInfo(userInfo);

                    Global.userInfo = userInfo;
                }
                googleUser.register = false;
            }
            if(googleUser.login)
            {
                BPT_Service.User user = new BPT_Service.User();
                BPT_Service.UserInfo userInfo = new BPT_Service.UserInfo();

                user = Global.service.SignIn(googleUserInfo.email, md5.MD5Hash(googleUserInfo.email));

                if (user != null)
                {
                    userInfo = Global.service.GetUserInfoById(user.id);
                }
                else
                {
                    Server.Transfer("SignIn.aspx", false);
                }

                googleUser.login = false;
            }

          
        }

      
    }
}