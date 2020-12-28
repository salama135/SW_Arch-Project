﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BPT_Service
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/BPT_Service")]
    public partial class User : object
    {
        
        private string emailField;
        
        private int idField;
        
        private string passwordField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserInfo", Namespace="http://schemas.datacontract.org/2004/07/BPT_Service")]
    public partial class UserInfo : object
    {
        
        private int ageField;
        
        private int bloodPressureField;
        
        private string genderField;
        
        private int idField;
        
        private string nameField;
        
        private int weightField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int age
        {
            get
            {
                return this.ageField;
            }
            set
            {
                this.ageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int bloodPressure
        {
            get
            {
                return this.bloodPressureField;
            }
            set
            {
                this.bloodPressureField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BPT_Service.IService1")]
    public interface IService1
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SignIn", ReplyAction="http://tempuri.org/IService1/SignInResponse")]
        System.Threading.Tasks.Task<BPT_Service.User> SignInAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Register", ReplyAction="http://tempuri.org/IService1/RegisterResponse")]
        System.Threading.Tasks.Task<bool> RegisterAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SendEmail", ReplyAction="http://tempuri.org/IService1/SendEmailResponse")]
        System.Threading.Tasks.Task<string> SendEmailAsync(string recipientEmail, string subject, string body, bool isHtml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SendReminder", ReplyAction="http://tempuri.org/IService1/SendReminderResponse")]
        System.Threading.Tasks.Task<bool> SendReminderAsync(string recipientEmail, string subject, string body, bool isHtml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUserById", ReplyAction="http://tempuri.org/IService1/GetUserByIdResponse")]
        System.Threading.Tasks.Task<BPT_Service.User> GetUserByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUserInfoById", ReplyAction="http://tempuri.org/IService1/GetUserInfoByIdResponse")]
        System.Threading.Tasks.Task<BPT_Service.UserInfo> GetUserInfoByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateUser", ReplyAction="http://tempuri.org/IService1/CreateUserResponse")]
        System.Threading.Tasks.Task<BPT_Service.User> CreateUserAsync(BPT_Service.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateUserInfo", ReplyAction="http://tempuri.org/IService1/CreateUserInfoResponse")]
        System.Threading.Tasks.Task<BPT_Service.UserInfo> CreateUserInfoAsync(BPT_Service.UserInfo user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateUser", ReplyAction="http://tempuri.org/IService1/UpdateUserResponse")]
        System.Threading.Tasks.Task<BPT_Service.User> UpdateUserAsync(int id, BPT_Service.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateUserInfo", ReplyAction="http://tempuri.org/IService1/UpdateUserInfoResponse")]
        System.Threading.Tasks.Task<BPT_Service.UserInfo> UpdateUserInfoAsync(int id, BPT_Service.UserInfo user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteUser", ReplyAction="http://tempuri.org/IService1/DeleteUserResponse")]
        System.Threading.Tasks.Task DeleteUserAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteUserInfo", ReplyAction="http://tempuri.org/IService1/DeleteUserInfoResponse")]
        System.Threading.Tasks.Task DeleteUserInfoAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IService1Channel : BPT_Service.IService1, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class Service1Client : System.ServiceModel.ClientBase<BPT_Service.IService1>, BPT_Service.IService1
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public Service1Client() : 
                base(Service1Client.GetDefaultBinding(), Service1Client.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IService1.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), Service1Client.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<BPT_Service.User> SignInAsync(string email, string password)
        {
            return base.Channel.SignInAsync(email, password);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterAsync(string email, string password)
        {
            return base.Channel.RegisterAsync(email, password);
        }
        
        public System.Threading.Tasks.Task<string> SendEmailAsync(string recipientEmail, string subject, string body, bool isHtml)
        {
            return base.Channel.SendEmailAsync(recipientEmail, subject, body, isHtml);
        }
        
        public System.Threading.Tasks.Task<bool> SendReminderAsync(string recipientEmail, string subject, string body, bool isHtml)
        {
            return base.Channel.SendReminderAsync(recipientEmail, subject, body, isHtml);
        }
        
        public System.Threading.Tasks.Task<BPT_Service.User> GetUserByIdAsync(int id)
        {
            return base.Channel.GetUserByIdAsync(id);
        }
        
        public System.Threading.Tasks.Task<BPT_Service.UserInfo> GetUserInfoByIdAsync(int id)
        {
            return base.Channel.GetUserInfoByIdAsync(id);
        }
        
        public System.Threading.Tasks.Task<BPT_Service.User> CreateUserAsync(BPT_Service.User user)
        {
            return base.Channel.CreateUserAsync(user);
        }
        
        public System.Threading.Tasks.Task<BPT_Service.UserInfo> CreateUserInfoAsync(BPT_Service.UserInfo user)
        {
            return base.Channel.CreateUserInfoAsync(user);
        }
        
        public System.Threading.Tasks.Task<BPT_Service.User> UpdateUserAsync(int id, BPT_Service.User user)
        {
            return base.Channel.UpdateUserAsync(id, user);
        }
        
        public System.Threading.Tasks.Task<BPT_Service.UserInfo> UpdateUserInfoAsync(int id, BPT_Service.UserInfo user)
        {
            return base.Channel.UpdateUserInfoAsync(id, user);
        }
        
        public System.Threading.Tasks.Task DeleteUserAsync(int id)
        {
            return base.Channel.DeleteUserAsync(id);
        }
        
        public System.Threading.Tasks.Task DeleteUserInfoAsync(int id)
        {
            return base.Channel.DeleteUserInfoAsync(id);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:59074/Service1.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return Service1Client.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IService1);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return Service1Client.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IService1);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IService1,
        }
    }
}
