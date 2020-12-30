using System;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Collections.Generic;
using System.Windows;

namespace BPT_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1 
    {
        private static SqlConnection connection = new SqlConnection("Data Source=database-1.cldtga9gznom.eu-central-1.rds.amazonaws.com;Initial Catalog=SWDA_Project;Persist Security Info=True;User ID=admin;Password=adminadmin");

        public User SignIn(string email, string password)
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();

            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            User user = new User();

            string passwordInDB = "";

            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
            
            if (connection.State == System.Data.ConnectionState.Closed)       
                connection.Open();

            try
            {
                SqlCommand sqlCommand = new SqlCommand("select * from Users where email=@h", connection);
                sqlCommand.Parameters.AddWithValue("@h", email);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    passwordInDB = reader["password"].ToString();
                    user.id = int.Parse(reader["id"].ToString());
                }

                if(password == passwordInDB)
                {
                    user.email = email;
                    user.password = password;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }

            connection.Close();
            return user;
        }

        public bool Register(string email, string password)
        {
            int count = 0;

            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();

            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            try
            {
                SqlCommand sqlCommand = new SqlCommand("select * from Users where email=@h", connection);
                sqlCommand.Parameters.AddWithValue("@h", email);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    count++;
                }                
            }
            catch (Exception ex)
            {
                return false;
            }

            connection.Close();

            return count == 0;
        }

        public User GetUserById(int id)
        {
            User user = new User();

            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();

            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
            
            try
            {
                SqlCommand sqlCommand = new SqlCommand("select * from Users where id=@h", connection);
                sqlCommand.Parameters.AddWithValue("@h", id);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    user.id = id;
                    user.email = reader["email"].ToString();
                    user.password = reader["password"].ToString();
                }

            }catch(Exception ex)
            {
                return null;
            }

            connection.Close();
            return user;
        }

        public UserInfo GetUserInfoById(int id)
        {
            UserInfo userInfo = new UserInfo();

            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();

            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            try
            {
                SqlCommand sqlCommand = new SqlCommand("select * from UsersInfo where id=@a", connection);
                sqlCommand.Parameters.AddWithValue("@a", id);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    userInfo.id = id;
                    userInfo.name = reader["name"].ToString();
                    userInfo.age = int.Parse(reader["age"].ToString());
                    userInfo.weight = int.Parse(reader["weight"].ToString());
                    userInfo.height = int.Parse(reader["height"].ToString());
                    userInfo.bloodPressure = int.Parse(reader["bloodPressure"].ToString());
                    userInfo.gender = reader["gender"].ToString();
                }
            }
            catch (Exception ex)
            {
                return null;
            }

            connection.Close();
            return userInfo;
        }

        public User CreateUser(User user)
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();

            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            SqlCommand sqlCommand = new SqlCommand("insert into Users (email, password) output INSERTED.ID VALUES (@f, @g)", connection);
            sqlCommand.Parameters.AddWithValue("@f", user.email);
            sqlCommand.Parameters.AddWithValue("@g", user.password);
            int modified = (int)sqlCommand.ExecuteScalar();
            user.id = modified;

            connection.Close();

            return user;
        }

        public UserInfo CreateUserInfo(UserInfo user)
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();

            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            SqlCommand sqlCommand = new SqlCommand("insert into UsersInfo (id, name, gender, age, weight, bloodPressure, height) VALUES (@a, @b, @c, @d, @e, @f, @g)", connection);
            sqlCommand.Parameters.AddWithValue("@a", user.id);
            sqlCommand.Parameters.AddWithValue("@b", user.name);
            sqlCommand.Parameters.AddWithValue("@c", user.gender);
            sqlCommand.Parameters.AddWithValue("@d", user.age);
            sqlCommand.Parameters.AddWithValue("@e", user.weight);
            sqlCommand.Parameters.AddWithValue("@f", user.bloodPressure);
            sqlCommand.Parameters.AddWithValue("@g", user.height);
            sqlCommand.ExecuteNonQuery();
            connection.Close();

            return user;
        }

        public User UpdateUser(int id, User user)
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();

            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            SqlCommand sqlCommand = new SqlCommand("update Users set email=@a, password=@b where id=@c", connection);
            sqlCommand.Parameters.AddWithValue("@a", user.email);
            sqlCommand.Parameters.AddWithValue("@b", user.password);
            sqlCommand.Parameters.AddWithValue("@c", id);
            sqlCommand.ExecuteNonQuery();
            connection.Close();

            user.id = id;

            return user;
        }

        public UserInfo UpdateUserInfo(int id, UserInfo user)
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();

            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            SqlCommand sqlCommand = new SqlCommand("update UsersInfo set name=@b, gender=@c, age=@d, weight=@e, bloodPressure=@f, height=@g where id=@a", connection);
            sqlCommand.Parameters.AddWithValue("@a", id);
            sqlCommand.Parameters.AddWithValue("@b", user.name);
            sqlCommand.Parameters.AddWithValue("@c", user.gender);
            sqlCommand.Parameters.AddWithValue("@d", user.age);
            sqlCommand.Parameters.AddWithValue("@e", user.weight);
            sqlCommand.Parameters.AddWithValue("@f", user.bloodPressure);
            sqlCommand.Parameters.AddWithValue("@g", user.height);
            sqlCommand.ExecuteNonQuery();
            connection.Close();

            user.id = id;

            return user;
        }

        public void DeleteUser(int id)
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();

            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            SqlCommand sqlCommand = new SqlCommand("delete from Users where id=@h", connection);
            sqlCommand.Parameters.AddWithValue("@h", id);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteUserInfo(int id)
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();

            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            SqlCommand sqlCommand = new SqlCommand("delete from UsersInfo where id=@h", connection);
            sqlCommand.Parameters.AddWithValue("@h", id);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteUserBloodRecoreds(int id)
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();

            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            SqlCommand sqlCommand = new SqlCommand("delete from Blood_Pressure_Records where id=@h", connection);
            sqlCommand.Parameters.AddWithValue("@h", id);
            sqlCommand.ExecuteNonQuery();
            connection.Close();           
        }

        public string SendEmail(string recipientEmail, string subject, string body, bool isHtml, string senderEmail, string senderPassword)
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();

            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            try
            {
                //Smpt Client Details
                //gmail >> smtp server : smtp.gmail.com, port : 587 , ssl required
                //yahoo >> smtp server : smtp.mail.yahoo.com, port : 587 , ssl required
                SmtpClient clientDetails = new SmtpClient();
                clientDetails.Port = 587;
                clientDetails.Host = "smtp.gmail.com";
                clientDetails.EnableSsl = true;
                clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
                clientDetails.UseDefaultCredentials = false;
                clientDetails.Credentials = new NetworkCredential(senderEmail, senderPassword);

                //Message Details
                MailMessage mailDetails = new MailMessage();
                mailDetails.From = new MailAddress(senderEmail);
                mailDetails.To.Add(recipientEmail.Trim());
                //for multiple recipients
                //mailDetails.To.Add("another recipient email address");
                //for bcc
                //mailDetails.Bcc.Add("bcc email address")
                mailDetails.Subject = subject;
                mailDetails.IsBodyHtml = isHtml;
                mailDetails.Body = body;

                clientDetails.Send(mailDetails);
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }

            return " ok ";
        }

        public bool SendReminder(string subject, string body, bool isHtml, string senderEmail, string senderPassword)
        {
            bool OK = true;

            User user = new User();

            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();

            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            string email;

            try
            {
                SqlCommand sqlCommand = new SqlCommand("select email from Users", connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    email = reader["email"].ToString();
                    SendEmail(email, "Blood Pressure reminder", "please meassure your blood pressure!", false, senderEmail, senderPassword);
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            connection.Close();

            return OK;
        }

        public void AddBP(int BP, int UserID)
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();

            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            SqlCommand sqlCmd = new SqlCommand("insert into Blood_Pressure_Records (id, Blood_Pressure, Day, mTime) values (@i, @b, @d, @t)", connection);
            sqlCmd.Parameters.AddWithValue("@i", UserID);
            sqlCmd.Parameters.AddWithValue("@b", BP);
            sqlCmd.Parameters.AddWithValue("@d", DateTime.Today.ToString("d"));
            sqlCmd.Parameters.AddWithValue("@t", DateTime.Now.ToShortTimeString());
            sqlCmd.ExecuteNonQuery();
            connection.Close();
        }
   
        public List<BloodPressure> GetBloodPressures(int id)
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();

            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            List<BloodPressure> bloodPressures = new List<BloodPressure>();
            SqlCommand sqlCommand = new SqlCommand("select * from Blood_Pressure_Records where id=@h", connection);
            sqlCommand.Parameters.AddWithValue("@h", id);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                BloodPressure bloodPressure = new BloodPressure();
                bloodPressure.Value = int.Parse(reader["Blood_Pressure"].ToString());
                bloodPressure.Date = reader["Day"].ToString();
                bloodPressures.Add(bloodPressure);
            }

            connection.Close();

            return bloodPressures;
        }
    }
}
