using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BPT_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        // TODO: Add your service operations here

        [OperationContract]
        User SignIn(string email, string password);


        [OperationContract]
        User GetUserById(int id);
        
        [OperationContract]
        UserInfo GetUserInfoById(int id);


        [OperationContract]
        User CreateUser(User user);

        [OperationContract]
        UserInfo CreateUserInfo(UserInfo user);


        [OperationContract]
        void UpdateUser(int id, User user);

        [OperationContract]
        void UpdateUserInfo(int id, UserInfo user);


        [OperationContract]
        void DeleteUser(int id);

        [OperationContract]
        void DeleteUserInfo(int id);
    }
}
