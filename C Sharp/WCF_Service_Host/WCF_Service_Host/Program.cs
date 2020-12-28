using System;

namespace WCF_Service_Host
{
    class Program
    {
        public static BPT_Service.Service1Client service1Client = new BPT_Service.Service1Client();
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            bool send = false;
            bool resetSend = true;

            while (true)
            {

                if (DateTime.Now.Hour == 2 && resetSend == true)
                {
                    send = true;
                    resetSend = false;
                }

                if(send == true)
                {
                    send = false;
                    Console.WriteLine(DateTime.Now.Hour.ToString());

                    service1Client.SendEmailAsync("ahmedsalamaahmedsayed@gmail.com", "Test mail", "this is a test email from ahmed salama", false);
                }

                if (DateTime.Now.Hour == 1)
                {
                    resetSend = true;
                }

            }
        }
    }
}
