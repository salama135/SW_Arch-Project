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
        User GetById(int id);

        [OperationContract]
        User Create(User user);

        [OperationContract]
        void Update(int id, User user);

        [OperationContract]
        void Delete(int id);
    }
}
