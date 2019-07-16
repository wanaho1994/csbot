//------------------------------------------------------------------------------
// <自动生成>
//     此代码由工具生成。
//     //
//     对此文件的更改可能导致不正确的行为，并在以下条件下丢失:
//     代码重新生成。
// </自动生成>
//------------------------------------------------------------------------------

namespace TaskCenterService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TaskCenterService.ServiceSoap")]
    public interface ServiceSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/QueryEncryptedBteUrl", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> QueryEncryptedBteUrlAsync(string userUid, string pwd, string bteUrl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchTasksNew", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<TaskCenterService.MuMobileTaskEntityResult> SearchTasksNewAsync(string userUid, string pwd, int pageIndex, int pageSize, bool isToDoTask, string taskKindCode, string taskSource, string searchKey, string searchCreator, string startDay, string endDay);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchTasks", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<TaskCenterService.SearchTasksResponse> SearchTasksAsync(TaskCenterService.SearchTasksRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/QueryToDoTasks", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<TaskCenterService.MuMobileTaskEntityResult> QueryToDoTasksAsync(string userUid, string pwd, int pageIndex, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/QueryDoneTasks", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<TaskCenterService.MuMobileTaskEntityResult> QueryDoneTasksAsync(string userUid, string pwd, int pageIndex, int pageSize);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class MuMobileTaskEntityResult
    {
        
        private MuMobileTaskEntity[] itemsField;
        
        private int pageIndexField;
        
        private int pageSizeField;
        
        private int totalCountField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        public MuMobileTaskEntity[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int PageIndex
        {
            get
            {
                return this.pageIndexField;
            }
            set
            {
                this.pageIndexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int PageSize
        {
            get
            {
                return this.pageSizeField;
            }
            set
            {
                this.pageSizeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int TotalCount
        {
            get
            {
                return this.totalCountField;
            }
            set
            {
                this.totalCountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class MuMobileTaskEntity
    {
        
        private string titleField;
        
        private string taskSourceField;
        
        private System.DateTime beginTimeField;
        
        private System.DateTime expireTimeField;
        
        private string taskLevelField;
        
        private string actionUrlField;
        
        private bool isSupportField;
        
        private int supportTypeField;
        
        private string taskKindCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string TaskSource
        {
            get
            {
                return this.taskSourceField;
            }
            set
            {
                this.taskSourceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public System.DateTime BeginTime
        {
            get
            {
                return this.beginTimeField;
            }
            set
            {
                this.beginTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public System.DateTime ExpireTime
        {
            get
            {
                return this.expireTimeField;
            }
            set
            {
                this.expireTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string TaskLevel
        {
            get
            {
                return this.taskLevelField;
            }
            set
            {
                this.taskLevelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string ActionUrl
        {
            get
            {
                return this.actionUrlField;
            }
            set
            {
                this.actionUrlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public bool IsSupport
        {
            get
            {
                return this.isSupportField;
            }
            set
            {
                this.isSupportField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public int SupportType
        {
            get
            {
                return this.supportTypeField;
            }
            set
            {
                this.supportTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string TaskKindCode
        {
            get
            {
                return this.taskKindCodeField;
            }
            set
            {
                this.taskKindCodeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SearchTasks", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SearchTasksRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string userUid;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string pwd;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public int pageIndex;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public int pageSize;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public bool isToDoTask;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        public string taskKindCode;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=6)]
        public string taskSource;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=7)]
        public string searchKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=8)]
        public string searchCreator;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=9)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> startDay;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=10)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> endDay;
        
        public SearchTasksRequest()
        {
        }
        
        public SearchTasksRequest(string userUid, string pwd, int pageIndex, int pageSize, bool isToDoTask, string taskKindCode, string taskSource, string searchKey, string searchCreator, System.Nullable<System.DateTime> startDay, System.Nullable<System.DateTime> endDay)
        {
            this.userUid = userUid;
            this.pwd = pwd;
            this.pageIndex = pageIndex;
            this.pageSize = pageSize;
            this.isToDoTask = isToDoTask;
            this.taskKindCode = taskKindCode;
            this.taskSource = taskSource;
            this.searchKey = searchKey;
            this.searchCreator = searchCreator;
            this.startDay = startDay;
            this.endDay = endDay;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SearchTasksResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SearchTasksResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public TaskCenterService.MuMobileTaskEntityResult SearchTasksResult;
        
        public SearchTasksResponse()
        {
        }
        
        public SearchTasksResponse(TaskCenterService.MuMobileTaskEntityResult SearchTasksResult)
        {
            this.SearchTasksResult = SearchTasksResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface ServiceSoapChannel : TaskCenterService.ServiceSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class ServiceSoapClient : System.ServiceModel.ClientBase<TaskCenterService.ServiceSoap>, TaskCenterService.ServiceSoap
    {
        
    /// <summary>
    /// 实现此分部方法，配置服务终结点。
    /// </summary>
    /// <param name="serviceEndpoint">要配置的终结点</param>
    /// <param name="clientCredentials">客户端凭据</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ServiceSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(ServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), ServiceSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<string> QueryEncryptedBteUrlAsync(string userUid, string pwd, string bteUrl)
        {
            return base.Channel.QueryEncryptedBteUrlAsync(userUid, pwd, bteUrl);
        }
        
        public System.Threading.Tasks.Task<TaskCenterService.MuMobileTaskEntityResult> SearchTasksNewAsync(string userUid, string pwd, int pageIndex, int pageSize, bool isToDoTask, string taskKindCode, string taskSource, string searchKey, string searchCreator, string startDay, string endDay)
        {
            return base.Channel.SearchTasksNewAsync(userUid, pwd, pageIndex, pageSize, isToDoTask, taskKindCode, taskSource, searchKey, searchCreator, startDay, endDay);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TaskCenterService.SearchTasksResponse> TaskCenterService.ServiceSoap.SearchTasksAsync(TaskCenterService.SearchTasksRequest request)
        {
            return base.Channel.SearchTasksAsync(request);
        }
        
        public System.Threading.Tasks.Task<TaskCenterService.SearchTasksResponse> SearchTasksAsync(string userUid, string pwd, int pageIndex, int pageSize, bool isToDoTask, string taskKindCode, string taskSource, string searchKey, string searchCreator, System.Nullable<System.DateTime> startDay, System.Nullable<System.DateTime> endDay)
        {
            TaskCenterService.SearchTasksRequest inValue = new TaskCenterService.SearchTasksRequest();
            inValue.userUid = userUid;
            inValue.pwd = pwd;
            inValue.pageIndex = pageIndex;
            inValue.pageSize = pageSize;
            inValue.isToDoTask = isToDoTask;
            inValue.taskKindCode = taskKindCode;
            inValue.taskSource = taskSource;
            inValue.searchKey = searchKey;
            inValue.searchCreator = searchCreator;
            inValue.startDay = startDay;
            inValue.endDay = endDay;
            return ((TaskCenterService.ServiceSoap)(this)).SearchTasksAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<TaskCenterService.MuMobileTaskEntityResult> QueryToDoTasksAsync(string userUid, string pwd, int pageIndex, int pageSize)
        {
            return base.Channel.QueryToDoTasksAsync(userUid, pwd, pageIndex, pageSize);
        }
        
        public System.Threading.Tasks.Task<TaskCenterService.MuMobileTaskEntityResult> QueryDoneTasksAsync(string userUid, string pwd, int pageIndex, int pageSize)
        {
            return base.Channel.QueryDoneTasksAsync(userUid, pwd, pageIndex, pageSize);
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
            if ((endpointConfiguration == EndpointConfiguration.ServiceSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.ServiceSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ServiceSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://btetingyun.ceair.com/service/service.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.ServiceSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://btetingyun.ceair.com/service/service.asmx");
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            ServiceSoap,
            
            ServiceSoap12,
        }
    }
}
