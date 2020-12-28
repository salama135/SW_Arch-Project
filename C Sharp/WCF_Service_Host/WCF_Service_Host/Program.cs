using System;

namespace WCF_Service_Host
{
    class Program
    {
        public static BPT_Service.Service1Client service1Client = new BPT_Service.Service1Client();
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            

            string senderPassword;
            string senderEmail;

            Console.WriteLine("Enter Sender Email!");
            senderEmail = Console.ReadLine();

            Console.WriteLine("Enter Sender Password!");
            senderPassword = Console.ReadLine();


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

                    service1Client.SendReminderAsync("Blood Pressure Reminder", "Please meassure your blodd pressure reminder", false, senderEmail, senderPassword);
                }

                if (DateTime.Now.Hour == 1)
                {
                    resetSend = true;
                }
            }
        }
    }
}
