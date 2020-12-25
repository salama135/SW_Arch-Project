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
        private static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KIVQJ67;Initial Catalog=BPT_SERVICE;Persist Security Info=True;User ID=Mekawy;Password=Admin@12345");

        public User GetById(int id)
        {
            User user = new User();

            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from UsersTable where id=@h", connection);
            sqlCommand.Parameters.Add("@h", id);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                user.id = id;
                user.name = reader["name"].ToString();
                user.age = int.Parse(reader["age"].ToString());
                user.weight = int.Parse(reader["weight"].ToString());
                user.bloodPressure = int.Parse(reader["bloodPressure"].ToString());
                user.gender = reader["gender"].ToString();
                user.email = reader["email"].ToString();
                user.password = reader["password"].ToString();
            }

            connection.Close();
            return user;
        }
        
        public User Create(User user)
        {
            connection.Open();            
            SqlCommand sqlCommand = new SqlCommand("insert into UsersTable (name, age, weight, bloodPressure, gender, email, password) VALUES (@a, @b, @c, @d, @e, @f, @g)", connection);
            sqlCommand.Parameters.Add("@a", user.name);
            sqlCommand.Parameters.Add("@b", user.age);
            sqlCommand.Parameters.Add("@c", user.weight);
            sqlCommand.Parameters.Add("@d", user.bloodPressure);
            sqlCommand.Parameters.Add("@e", user.gender);
            sqlCommand.Parameters.Add("@f", user.email);
            sqlCommand.Parameters.Add("@g", user.password);
            sqlCommand.ExecuteNonQuery();
            connection.Close();

            return user;
        }
        
        public void Update(int id, User user)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("update UsersTable set name=@a, age=@b, weight=@c, bloodPressure=@d, gender=@e, email=@f, password=@g where id=@h", connection);
            sqlCommand.Parameters.Add("@a", user.name);
            sqlCommand.Parameters.Add("@b", user.age);
            sqlCommand.Parameters.Add("@c", user.weight);
            sqlCommand.Parameters.Add("@d", user.bloodPressure);
            sqlCommand.Parameters.Add("@e", user.gender);
            sqlCommand.Parameters.Add("@f", user.email);
            sqlCommand.Parameters.Add("@g", user.password);
            sqlCommand.Parameters.Add("@h", user.id);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        public void Delete(int id)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("delete from UsersTable where id=@h", connection);
            sqlCommand.Parameters.Add("@h", id);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }
    }
}
