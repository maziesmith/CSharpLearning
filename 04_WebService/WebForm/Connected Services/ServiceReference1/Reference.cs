﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebForm.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        WebForm.ServiceReference1.HelloWorldResponse HelloWorld(WebForm.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<WebForm.ServiceReference1.HelloWorldResponse> HelloWorldAsync(WebForm.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        int Add(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int a, int b);
        
        // CODEGEN: Generating message contract since element name GetUserInfoListResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetUserInfoList", ReplyAction="*")]
        WebForm.ServiceReference1.GetUserInfoListResponse GetUserInfoList(WebForm.ServiceReference1.GetUserInfoListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetUserInfoList", ReplyAction="*")]
        System.Threading.Tasks.Task<WebForm.ServiceReference1.GetUserInfoListResponse> GetUserInfoListAsync(WebForm.ServiceReference1.GetUserInfoListRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public WebForm.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WebForm.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebForm.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WebForm.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetUserInfoListRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetUserInfoList", Namespace="http://tempuri.org/", Order=0)]
        public WebForm.ServiceReference1.GetUserInfoListRequestBody Body;
        
        public GetUserInfoListRequest() {
        }
        
        public GetUserInfoListRequest(WebForm.ServiceReference1.GetUserInfoListRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetUserInfoListRequestBody {
        
        public GetUserInfoListRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetUserInfoListResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetUserInfoListResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebForm.ServiceReference1.GetUserInfoListResponseBody Body;
        
        public GetUserInfoListResponse() {
        }
        
        public GetUserInfoListResponse(WebForm.ServiceReference1.GetUserInfoListResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetUserInfoListResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetUserInfoListResult;
        
        public GetUserInfoListResponseBody() {
        }
        
        public GetUserInfoListResponseBody(string GetUserInfoListResult) {
            this.GetUserInfoListResult = GetUserInfoListResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : WebForm.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<WebForm.ServiceReference1.WebService1Soap>, WebForm.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebForm.ServiceReference1.HelloWorldResponse WebForm.ServiceReference1.WebService1Soap.HelloWorld(WebForm.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WebForm.ServiceReference1.HelloWorldRequest inValue = new WebForm.ServiceReference1.HelloWorldRequest();
            inValue.Body = new WebForm.ServiceReference1.HelloWorldRequestBody();
            WebForm.ServiceReference1.HelloWorldResponse retVal = ((WebForm.ServiceReference1.WebService1Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebForm.ServiceReference1.HelloWorldResponse> WebForm.ServiceReference1.WebService1Soap.HelloWorldAsync(WebForm.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebForm.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            WebForm.ServiceReference1.HelloWorldRequest inValue = new WebForm.ServiceReference1.HelloWorldRequest();
            inValue.Body = new WebForm.ServiceReference1.HelloWorldRequestBody();
            return ((WebForm.ServiceReference1.WebService1Soap)(this)).HelloWorldAsync(inValue);
        }
        
        public int Add(int a, int b) {
            return base.Channel.Add(a, b);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int a, int b) {
            return base.Channel.AddAsync(a, b);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebForm.ServiceReference1.GetUserInfoListResponse WebForm.ServiceReference1.WebService1Soap.GetUserInfoList(WebForm.ServiceReference1.GetUserInfoListRequest request) {
            return base.Channel.GetUserInfoList(request);
        }
        
        public string GetUserInfoList() {
            WebForm.ServiceReference1.GetUserInfoListRequest inValue = new WebForm.ServiceReference1.GetUserInfoListRequest();
            inValue.Body = new WebForm.ServiceReference1.GetUserInfoListRequestBody();
            WebForm.ServiceReference1.GetUserInfoListResponse retVal = ((WebForm.ServiceReference1.WebService1Soap)(this)).GetUserInfoList(inValue);
            return retVal.Body.GetUserInfoListResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebForm.ServiceReference1.GetUserInfoListResponse> WebForm.ServiceReference1.WebService1Soap.GetUserInfoListAsync(WebForm.ServiceReference1.GetUserInfoListRequest request) {
            return base.Channel.GetUserInfoListAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebForm.ServiceReference1.GetUserInfoListResponse> GetUserInfoListAsync() {
            WebForm.ServiceReference1.GetUserInfoListRequest inValue = new WebForm.ServiceReference1.GetUserInfoListRequest();
            inValue.Body = new WebForm.ServiceReference1.GetUserInfoListRequestBody();
            return ((WebForm.ServiceReference1.WebService1Soap)(this)).GetUserInfoListAsync(inValue);
        }
    }
}
