using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;


namespace BPT_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1 
    {
        private static SqlConnection connection = new SqlConnection("Data Source=database-1.cldtga9gznom.eu-central-1.rds.amazonaws.com;Initial Catalog=SWDA_Project;Persist Security Info=True;User ID=admin;Password=adminadmin");

        public User SignIn(string email, string password)
        {
            User user = new User();

            string passwordInDB = "";

            connection.Open();

            try
            {
                SqlCommand sqlCommand = new SqlCommand("select password from Users where email=@h", connection);
                sqlCommand.Parameters.Add("@h", email);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    passwordInDB = reader["password"].ToString();
                }

                if(password == passwordInDB)
                {
                    user.email = email;
                    user.id = int.Parse(reader["id"].ToString());
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

        public User GetUserById(int id)
        {
            User user = new User();

            connection.Open();

            try
            {
                SqlCommand sqlCommand = new SqlCommand("select * from Users where id=@h", connection);
                sqlCommand.Parameters.Add("@h", id);
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

            connection.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("select * from UsersInfo where id=@h", connection);
                sqlCommand.Parameters.Add("@h", id);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    userInfo.id = id;
                    userInfo.name = reader["name"].ToString();
                    userInfo.age = int.Parse(reader["age"].ToString());
                    userInfo.weight = int.Parse(reader["weight"].ToString());
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
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into Users (email, password) VALUES (@f, @g)", connection);
            sqlCommand.Parameters.Add("@f", user.email);
            sqlCommand.Parameters.Add("@g", user.password);
            sqlCommand.ExecuteNonQuery();
            connection.Close();

            return user;
        }

        public UserInfo CreateUserInfo(UserInfo user)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into UsersInfo (name, age, weight, bloodPressure, gender) VALUES (@a, @b, @c, @d, @e)", connection);
            sqlCommand.Parameters.Add("@a", user.name);
            sqlCommand.Parameters.Add("@b", user.age);
            sqlCommand.Parameters.Add("@c", user.weight);
            sqlCommand.Parameters.Add("@d", user.bloodPressure);
            sqlCommand.Parameters.Add("@e", user.gender);
            sqlCommand.ExecuteNonQuery();
            connection.Close();

            return user;
        }

        public void UpdateUser(int id, User user)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("update Users set email=@f, password=@g where id=@h", connection);
            sqlCommand.Parameters.Add("@f", user.email);
            sqlCommand.Parameters.Add("@g", user.password);
            sqlCommand.Parameters.Add("@h", user.id);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateUserInfo(int id, UserInfo user)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("update UsersTable set name=@a, age=@b, weight=@c, bloodPressure=@d, gender=@e where id=@h", connection);
            sqlCommand.Parameters.Add("@a", user.name);
            sqlCommand.Parameters.Add("@b", user.age);
            sqlCommand.Parameters.Add("@c", user.weight);
            sqlCommand.Parameters.Add("@d", user.bloodPressure);
            sqlCommand.Parameters.Add("@e", user.gender);
            sqlCommand.Parameters.Add("@h", user.id);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteUser(int id)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("delete from Users where id=@h", connection);
            sqlCommand.Parameters.Add("@h", id);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteUserInfo(int id)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("delete from UsersInfo where id=@h", connection);
            sqlCommand.Parameters.Add("@h", id);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }
    }
}
