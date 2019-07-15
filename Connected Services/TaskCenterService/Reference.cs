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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TaskCenterService.QueryTasksSoap")]
    public interface QueryTasksSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/QueryDoneList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<TaskCenterService.SplitPageResultOfTW_TaskEntity> QueryDoneListAsync(string userUid, int pageIndex, int pageSize, string taskKindCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Query", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<TaskCenterService.SplitPageResultOfTW_TaskEntity> QueryAsync(string userUid, int pageIndex, int pageSize, string taskKindCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/QueryMergedToDoList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<TaskCenterService.SplitPageResultOfTW_TaskEntity> QueryMergedToDoListAsync(string userUid, int pageIndex, int pageSize, string taskKindCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Search", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<TaskCenterService.SearchResponse> SearchAsync(TaskCenterService.SearchRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class SplitPageResultOfTW_TaskEntity
    {
        
        private TW_TaskEntity[] itemsField;
        
        private int pageIndexField;
        
        private int pageSizeField;
        
        private int totalCountField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        public TW_TaskEntity[] Items
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
    public partial class TW_TaskEntity
    {
        
        private string titleField;
        
        private string task_SourceField;
        
        private System.DateTime beginTimeField;
        
        private System.DateTime expireTimeField;
        
        private string taskLevelField;
        
        private int taskcenterIDField;
        
        private string clientTxSeqField;
        
        private string taskKindCodeField;
        
        private string appCodeField;
        
        private string actionUrlField;
        
        private string taskStepField;
        
        private string creatorField;
        
        private string creatorNameField;
        
        private string actionUrl2Field;
        
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
        public string Task_Source
        {
            get
            {
                return this.task_SourceField;
            }
            set
            {
                this.task_SourceField = value;
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
        public int TaskcenterID
        {
            get
            {
                return this.taskcenterIDField;
            }
            set
            {
                this.taskcenterIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string ClientTxSeq
        {
            get
            {
                return this.clientTxSeqField;
            }
            set
            {
                this.clientTxSeqField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string AppCode
        {
            get
            {
                return this.appCodeField;
            }
            set
            {
                this.appCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string TaskStep
        {
            get
            {
                return this.taskStepField;
            }
            set
            {
                this.taskStepField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public string Creator
        {
            get
            {
                return this.creatorField;
            }
            set
            {
                this.creatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public string CreatorName
        {
            get
            {
                return this.creatorNameField;
            }
            set
            {
                this.creatorNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public string ActionUrl2
        {
            get
            {
                return this.actionUrl2Field;
            }
            set
            {
                this.actionUrl2Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public enum TaskType
    {
        
        /// <remarks/>
        ToDo,
        
        /// <remarks/>
        Done,
        
        /// <remarks/>
        Expired,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Search", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SearchRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string userUid;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public TaskCenterService.TaskType taskType;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public int pageIndex;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public int pageSize;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public string taskKindCode;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        public string taskSource;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=6)]
        public string searchKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=7)]
        public string searchCreator;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=8)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> startDay;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=9)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> endDay;
        
        public SearchRequest()
        {
        }
        
        public SearchRequest(string userUid, TaskCenterService.TaskType taskType, int pageIndex, int pageSize, string taskKindCode, string taskSource, string searchKey, string searchCreator, System.Nullable<System.DateTime> startDay, System.Nullable<System.DateTime> endDay)
        {
            this.userUid = userUid;
            this.taskType = taskType;
            this.pageIndex = pageIndex;
            this.pageSize = pageSize;
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="SearchResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SearchResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public TaskCenterService.SplitPageResultOfTW_TaskEntity SearchResult;
        
        public SearchResponse()
        {
        }
        
        public SearchResponse(TaskCenterService.SplitPageResultOfTW_TaskEntity SearchResult)
        {
            this.SearchResult = SearchResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface QueryTasksSoapChannel : TaskCenterService.QueryTasksSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class QueryTasksSoapClient : System.ServiceModel.ClientBase<TaskCenterService.QueryTasksSoap>, TaskCenterService.QueryTasksSoap
    {
        
    /// <summary>
    /// 实现此分部方法，配置服务终结点。
    /// </summary>
    /// <param name="serviceEndpoint">要配置的终结点</param>
    /// <param name="clientCredentials">客户端凭据</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public QueryTasksSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(QueryTasksSoapClient.GetBindingForEndpoint(endpointConfiguration), QueryTasksSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public QueryTasksSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(QueryTasksSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public QueryTasksSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(QueryTasksSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public QueryTasksSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<TaskCenterService.SplitPageResultOfTW_TaskEntity> QueryDoneListAsync(string userUid, int pageIndex, int pageSize, string taskKindCode)
        {
            return base.Channel.QueryDoneListAsync(userUid, pageIndex, pageSize, taskKindCode);
        }
        
        public System.Threading.Tasks.Task<TaskCenterService.SplitPageResultOfTW_TaskEntity> QueryAsync(string userUid, int pageIndex, int pageSize, string taskKindCode)
        {
            return base.Channel.QueryAsync(userUid, pageIndex, pageSize, taskKindCode);
        }
        
        public System.Threading.Tasks.Task<TaskCenterService.SplitPageResultOfTW_TaskEntity> QueryMergedToDoListAsync(string userUid, int pageIndex, int pageSize, string taskKindCode)
        {
            return base.Channel.QueryMergedToDoListAsync(userUid, pageIndex, pageSize, taskKindCode);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TaskCenterService.SearchResponse> TaskCenterService.QueryTasksSoap.SearchAsync(TaskCenterService.SearchRequest request)
        {
            return base.Channel.SearchAsync(request);
        }
        
        public System.Threading.Tasks.Task<TaskCenterService.SearchResponse> SearchAsync(string userUid, TaskCenterService.TaskType taskType, int pageIndex, int pageSize, string taskKindCode, string taskSource, string searchKey, string searchCreator, System.Nullable<System.DateTime> startDay, System.Nullable<System.DateTime> endDay)
        {
            TaskCenterService.SearchRequest inValue = new TaskCenterService.SearchRequest();
            inValue.userUid = userUid;
            inValue.taskType = taskType;
            inValue.pageIndex = pageIndex;
            inValue.pageSize = pageSize;
            inValue.taskKindCode = taskKindCode;
            inValue.taskSource = taskSource;
            inValue.searchKey = searchKey;
            inValue.searchCreator = searchCreator;
            inValue.startDay = startDay;
            inValue.endDay = endDay;
            return ((TaskCenterService.QueryTasksSoap)(this)).SearchAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.QueryTasksSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.QueryTasksSoap12))
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
            if ((endpointConfiguration == EndpointConfiguration.QueryTasksSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://taskcenter.ceair.com/QueryTasks.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.QueryTasksSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://taskcenter.ceair.com/QueryTasks.asmx");
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            QueryTasksSoap,
            
            QueryTasksSoap12,
        }
    }
}
