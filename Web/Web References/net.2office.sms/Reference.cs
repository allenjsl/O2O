﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.3643
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 2.0.50727.3643 版自动生成。
// 
#pragma warning disable 1591

namespace Eyousoft_yhq.Web.net._2office.sms {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="SmsServiceSoap", Namespace="http://tempuri.org/")]
    public partial class SmsService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SendSms3OperationCompleted;
        
        private System.Threading.SendOrPostCallback IsIncludeKeyWordOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetSmsMoney2OperationCompleted;
        
        private System.Threading.SendOrPostCallback SendSms5OperationCompleted;
        
        private System.Threading.SendOrPostCallback SendTimingSmsOperationCompleted;
        
        private System.Threading.SendOrPostCallback BatchSendSMSOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SmsService() {
            this.Url = global::Eyousoft_yhq.Web.Properties.Settings.Default.Eyousoft_yhq_Web_net_2office_sms_SmsService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event SendSms3CompletedEventHandler SendSms3Completed;
        
        /// <remarks/>
        public event IsIncludeKeyWordCompletedEventHandler IsIncludeKeyWordCompleted;
        
        /// <remarks/>
        public event GetSmsMoney2CompletedEventHandler GetSmsMoney2Completed;
        
        /// <remarks/>
        public event SendSms5CompletedEventHandler SendSms5Completed;
        
        /// <remarks/>
        public event SendTimingSmsCompletedEventHandler SendTimingSmsCompleted;
        
        /// <remarks/>
        public event BatchSendSMSCompletedEventHandler BatchSendSMSCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org", RequestNamespace="http://tempuri.org", ResponseNamespace="http://tempuri.org", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SendSms3(string account, string password, string mobile, string content, string channel, string smsid, string sendType) {
            object[] results = this.Invoke("SendSms3", new object[] {
                        account,
                        password,
                        mobile,
                        content,
                        channel,
                        smsid,
                        sendType});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SendSms3Async(string account, string password, string mobile, string content, string channel, string smsid, string sendType) {
            this.SendSms3Async(account, password, mobile, content, channel, smsid, sendType, null);
        }
        
        /// <remarks/>
        public void SendSms3Async(string account, string password, string mobile, string content, string channel, string smsid, string sendType, object userState) {
            if ((this.SendSms3OperationCompleted == null)) {
                this.SendSms3OperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendSms3OperationCompleted);
            }
            this.InvokeAsync("SendSms3", new object[] {
                        account,
                        password,
                        mobile,
                        content,
                        channel,
                        smsid,
                        sendType}, this.SendSms3OperationCompleted, userState);
        }
        
        private void OnSendSms3OperationCompleted(object arg) {
            if ((this.SendSms3Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendSms3Completed(this, new SendSms3CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org", RequestNamespace="http://tempuri.org", ResponseNamespace="http://tempuri.org", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string IsIncludeKeyWord(string content) {
            object[] results = this.Invoke("IsIncludeKeyWord", new object[] {
                        content});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void IsIncludeKeyWordAsync(string content) {
            this.IsIncludeKeyWordAsync(content, null);
        }
        
        /// <remarks/>
        public void IsIncludeKeyWordAsync(string content, object userState) {
            if ((this.IsIncludeKeyWordOperationCompleted == null)) {
                this.IsIncludeKeyWordOperationCompleted = new System.Threading.SendOrPostCallback(this.OnIsIncludeKeyWordOperationCompleted);
            }
            this.InvokeAsync("IsIncludeKeyWord", new object[] {
                        content}, this.IsIncludeKeyWordOperationCompleted, userState);
        }
        
        private void OnIsIncludeKeyWordOperationCompleted(object arg) {
            if ((this.IsIncludeKeyWordCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.IsIncludeKeyWordCompleted(this, new IsIncludeKeyWordCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org", RequestNamespace="http://tempuri.org", ResponseNamespace="http://tempuri.org", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetSmsMoney2(string account, string password) {
            object[] results = this.Invoke("GetSmsMoney2", new object[] {
                        account,
                        password});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetSmsMoney2Async(string account, string password) {
            this.GetSmsMoney2Async(account, password, null);
        }
        
        /// <remarks/>
        public void GetSmsMoney2Async(string account, string password, object userState) {
            if ((this.GetSmsMoney2OperationCompleted == null)) {
                this.GetSmsMoney2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSmsMoney2OperationCompleted);
            }
            this.InvokeAsync("GetSmsMoney2", new object[] {
                        account,
                        password}, this.GetSmsMoney2OperationCompleted, userState);
        }
        
        private void OnGetSmsMoney2OperationCompleted(object arg) {
            if ((this.GetSmsMoney2Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSmsMoney2Completed(this, new GetSmsMoney2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org", RequestNamespace="http://tempuri.org", ResponseNamespace="http://tempuri.org", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SendSms5(string account, string password, string mobile, string content, string channel, string smsid, string sendType) {
            object[] results = this.Invoke("SendSms5", new object[] {
                        account,
                        password,
                        mobile,
                        content,
                        channel,
                        smsid,
                        sendType});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SendSms5Async(string account, string password, string mobile, string content, string channel, string smsid, string sendType) {
            this.SendSms5Async(account, password, mobile, content, channel, smsid, sendType, null);
        }
        
        /// <remarks/>
        public void SendSms5Async(string account, string password, string mobile, string content, string channel, string smsid, string sendType, object userState) {
            if ((this.SendSms5OperationCompleted == null)) {
                this.SendSms5OperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendSms5OperationCompleted);
            }
            this.InvokeAsync("SendSms5", new object[] {
                        account,
                        password,
                        mobile,
                        content,
                        channel,
                        smsid,
                        sendType}, this.SendSms5OperationCompleted, userState);
        }
        
        private void OnSendSms5OperationCompleted(object arg) {
            if ((this.SendSms5Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendSms5Completed(this, new SendSms5CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org", RequestNamespace="http://tempuri.org", ResponseNamespace="http://tempuri.org", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SendTimingSms(string account, string password, string mobile, string content, string smsid, string sendTime) {
            object[] results = this.Invoke("SendTimingSms", new object[] {
                        account,
                        password,
                        mobile,
                        content,
                        smsid,
                        sendTime});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SendTimingSmsAsync(string account, string password, string mobile, string content, string smsid, string sendTime) {
            this.SendTimingSmsAsync(account, password, mobile, content, smsid, sendTime, null);
        }
        
        /// <remarks/>
        public void SendTimingSmsAsync(string account, string password, string mobile, string content, string smsid, string sendTime, object userState) {
            if ((this.SendTimingSmsOperationCompleted == null)) {
                this.SendTimingSmsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendTimingSmsOperationCompleted);
            }
            this.InvokeAsync("SendTimingSms", new object[] {
                        account,
                        password,
                        mobile,
                        content,
                        smsid,
                        sendTime}, this.SendTimingSmsOperationCompleted, userState);
        }
        
        private void OnSendTimingSmsOperationCompleted(object arg) {
            if ((this.SendTimingSmsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendTimingSmsCompleted(this, new SendTimingSmsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org", RequestNamespace="http://tempuri.org", ResponseNamespace="http://tempuri.org", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string BatchSendSMS(string account, string password, string smsinfo, string smsid, string channel) {
            object[] results = this.Invoke("BatchSendSMS", new object[] {
                        account,
                        password,
                        smsinfo,
                        smsid,
                        channel});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void BatchSendSMSAsync(string account, string password, string smsinfo, string smsid, string channel) {
            this.BatchSendSMSAsync(account, password, smsinfo, smsid, channel, null);
        }
        
        /// <remarks/>
        public void BatchSendSMSAsync(string account, string password, string smsinfo, string smsid, string channel, object userState) {
            if ((this.BatchSendSMSOperationCompleted == null)) {
                this.BatchSendSMSOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBatchSendSMSOperationCompleted);
            }
            this.InvokeAsync("BatchSendSMS", new object[] {
                        account,
                        password,
                        smsinfo,
                        smsid,
                        channel}, this.BatchSendSMSOperationCompleted, userState);
        }
        
        private void OnBatchSendSMSOperationCompleted(object arg) {
            if ((this.BatchSendSMSCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BatchSendSMSCompleted(this, new BatchSendSMSCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void SendSms3CompletedEventHandler(object sender, SendSms3CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendSms3CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendSms3CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void IsIncludeKeyWordCompletedEventHandler(object sender, IsIncludeKeyWordCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsIncludeKeyWordCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal IsIncludeKeyWordCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetSmsMoney2CompletedEventHandler(object sender, GetSmsMoney2CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSmsMoney2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetSmsMoney2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void SendSms5CompletedEventHandler(object sender, SendSms5CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendSms5CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendSms5CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void SendTimingSmsCompletedEventHandler(object sender, SendTimingSmsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendTimingSmsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendTimingSmsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void BatchSendSMSCompletedEventHandler(object sender, BatchSendSMSCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BatchSendSMSCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal BatchSendSMSCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591