//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/severnew")]
    public partial class CompositeType : object
    {
        
        private bool BoolValueField;
        
        private string StringValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue
        {
            get
            {
                return this.BoolValueField;
            }
            set
            {
                this.BoolValueField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue
        {
            get
            {
                return this.StringValueField;
            }
            set
            {
                this.StringValueField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Blogpost", Namespace="http://schemas.datacontract.org/2004/07/severnew")]
    public partial class Blogpost : object
    {
        
        private bool PostApprovedField;
        
        private string PostDescriptionField;
        
        private string PostTitleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool PostApproved
        {
            get
            {
                return this.PostApprovedField;
            }
            set
            {
                this.PostApprovedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PostDescription
        {
            get
            {
                return this.PostDescriptionField;
            }
            set
            {
                this.PostDescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PostTitle
        {
            get
            {
                return this.PostTitleField;
            }
            set
            {
                this.PostTitleField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        ServiceReference1.CompositeType GetDataUsingDataContract(ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<ServiceReference1.CompositeType> GetDataUsingDataContractAsync(ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getPost", ReplyAction="http://tempuri.org/IService1/getPostResponse")]
        ServiceReference1.Blogpost getPost(int PostId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getPost", ReplyAction="http://tempuri.org/IService1/getPostResponse")]
        System.Threading.Tasks.Task<ServiceReference1.Blogpost> getPostAsync(int PostId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getPosts", ReplyAction="http://tempuri.org/IService1/getPostsResponse")]
        ServiceReference1.Blogpost[] getPosts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getPosts", ReplyAction="http://tempuri.org/IService1/getPostsResponse")]
        System.Threading.Tasks.Task<ServiceReference1.Blogpost[]> getPostsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addPost", ReplyAction="http://tempuri.org/IService1/addPostResponse")]
        void addPost(ServiceReference1.Blogpost post);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addPost", ReplyAction="http://tempuri.org/IService1/addPostResponse")]
        System.Threading.Tasks.Task addPostAsync(ServiceReference1.Blogpost post);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletePost", ReplyAction="http://tempuri.org/IService1/deletePostResponse")]
        void deletePost(int a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletePost", ReplyAction="http://tempuri.org/IService1/deletePostResponse")]
        System.Threading.Tasks.Task deletePostAsync(int a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/savePost", ReplyAction="http://tempuri.org/IService1/savePostResponse")]
        void savePost(ServiceReference1.Blogpost post, int index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/savePost", ReplyAction="http://tempuri.org/IService1/savePostResponse")]
        System.Threading.Tasks.Task savePostAsync(ServiceReference1.Blogpost post, int index);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface IService1Channel : ServiceReference1.IService1, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ServiceReference1.IService1>, ServiceReference1.IService1
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
        
        public string GetData(int value)
        {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value)
        {
            return base.Channel.GetDataAsync(value);
        }
        
        public ServiceReference1.CompositeType GetDataUsingDataContract(ServiceReference1.CompositeType composite)
        {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.CompositeType> GetDataUsingDataContractAsync(ServiceReference1.CompositeType composite)
        {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public ServiceReference1.Blogpost getPost(int PostId)
        {
            return base.Channel.getPost(PostId);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.Blogpost> getPostAsync(int PostId)
        {
            return base.Channel.getPostAsync(PostId);
        }
        
        public ServiceReference1.Blogpost[] getPosts()
        {
            return base.Channel.getPosts();
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.Blogpost[]> getPostsAsync()
        {
            return base.Channel.getPostsAsync();
        }
        
        public void addPost(ServiceReference1.Blogpost post)
        {
            base.Channel.addPost(post);
        }
        
        public System.Threading.Tasks.Task addPostAsync(ServiceReference1.Blogpost post)
        {
            return base.Channel.addPostAsync(post);
        }
        
        public void deletePost(int a)
        {
            base.Channel.deletePost(a);
        }
        
        public System.Threading.Tasks.Task deletePostAsync(int a)
        {
            return base.Channel.deletePostAsync(a);
        }
        
        public void savePost(ServiceReference1.Blogpost post, int index)
        {
            base.Channel.savePost(post, index);
        }
        
        public System.Threading.Tasks.Task savePostAsync(ServiceReference1.Blogpost post, int index)
        {
            return base.Channel.savePostAsync(post, index);
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
                return new System.ServiceModel.EndpointAddress("http://localhost:52818/Service1.svc");
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
