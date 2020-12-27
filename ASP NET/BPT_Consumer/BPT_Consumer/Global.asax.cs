using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using BPT_Consumer.BPT_Service;

namespace BPT_Consumer
{
    public class Global : HttpApplication
    {
        public static BPT_Service.Service1Client service;
        public static User user;
        public static UserInfo userInfo;

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            service = new Service1Client();            
        }
    }
}