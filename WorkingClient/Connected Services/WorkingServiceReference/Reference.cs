﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorkingClient.WorkingServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StatisticsService", Namespace="http://schemas.datacontract.org/2004/07/WorkingService.AppService.Services")]
    [System.SerializableAttribute()]
    public partial class StatisticsService : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AllTactsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ErrorTactsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SuccessTactsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AllTacts {
            get {
                return this.AllTactsField;
            }
            set {
                if ((this.AllTactsField.Equals(value) != true)) {
                    this.AllTactsField = value;
                    this.RaisePropertyChanged("AllTacts");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ErrorTacts {
            get {
                return this.ErrorTactsField;
            }
            set {
                if ((this.ErrorTactsField.Equals(value) != true)) {
                    this.ErrorTactsField = value;
                    this.RaisePropertyChanged("ErrorTacts");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SuccessTacts {
            get {
                return this.SuccessTactsField;
            }
            set {
                if ((this.SuccessTactsField.Equals(value) != true)) {
                    this.SuccessTactsField = value;
                    this.RaisePropertyChanged("SuccessTacts");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WorkingServiceReference.IWorkingService", CallbackContract=typeof(WorkingClient.WorkingServiceReference.IWorkingServiceCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IWorkingService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IWorkingService/RunScript")]
        void RunScript();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IWorkingService/RunScript")]
        System.Threading.Tasks.Task RunScriptAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IWorkingService/UpdateAndCompileScript")]
        void UpdateAndCompileScript(string fileName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IWorkingService/UpdateAndCompileScript")]
        System.Threading.Tasks.Task UpdateAndCompileScriptAsync(string fileName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IWorkingService/CompileScript")]
        void CompileScript();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IWorkingService/CompileScript")]
        System.Threading.Tasks.Task CompileScriptAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWorkingServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IWorkingService/UpdateStatistics")]
        void UpdateStatistics(WorkingClient.WorkingServiceReference.StatisticsService service);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWorkingServiceChannel : WorkingClient.WorkingServiceReference.IWorkingService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WorkingServiceClient : System.ServiceModel.DuplexClientBase<WorkingClient.WorkingServiceReference.IWorkingService>, WorkingClient.WorkingServiceReference.IWorkingService {
        
        public WorkingServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public WorkingServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public WorkingServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public WorkingServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public WorkingServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void RunScript() {
            base.Channel.RunScript();
        }
        
        public System.Threading.Tasks.Task RunScriptAsync() {
            return base.Channel.RunScriptAsync();
        }
        
        public void UpdateAndCompileScript(string fileName) {
            base.Channel.UpdateAndCompileScript(fileName);
        }
        
        public System.Threading.Tasks.Task UpdateAndCompileScriptAsync(string fileName) {
            return base.Channel.UpdateAndCompileScriptAsync(fileName);
        }
        
        public void CompileScript() {
            base.Channel.CompileScript();
        }
        
        public System.Threading.Tasks.Task CompileScriptAsync() {
            return base.Channel.CompileScriptAsync();
        }
    }
}