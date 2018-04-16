﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SLSOCdesktop.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Modulesc", Namespace="http://schemas.datacontract.org/2004/07/SLSOCserver")]
    [System.SerializableAttribute()]
    public partial class Modulesc : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LecnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModcodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModnameField;
        
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
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Lecname {
            get {
                return this.LecnameField;
            }
            set {
                if ((object.ReferenceEquals(this.LecnameField, value) != true)) {
                    this.LecnameField = value;
                    this.RaisePropertyChanged("Lecname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Modcode {
            get {
                return this.ModcodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ModcodeField, value) != true)) {
                    this.ModcodeField = value;
                    this.RaisePropertyChanged("Modcode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Modname {
            get {
                return this.ModnameField;
            }
            set {
                if ((object.ReferenceEquals(this.ModnameField, value) != true)) {
                    this.ModnameField = value;
                    this.RaisePropertyChanged("Modname");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IService2")]
    public interface IService2 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/AddModules", ReplyAction="http://tempuri.org/IService2/AddModulesResponse")]
        int AddModules(SLSOCdesktop.ServiceReference2.Modulesc md);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/AddModules", ReplyAction="http://tempuri.org/IService2/AddModulesResponse")]
        System.Threading.Tasks.Task<int> AddModulesAsync(SLSOCdesktop.ServiceReference2.Modulesc md);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/SearchModules", ReplyAction="http://tempuri.org/IService2/SearchModulesResponse")]
        SLSOCdesktop.ServiceReference2.Modulesc SearchModules(string Modcode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/SearchModules", ReplyAction="http://tempuri.org/IService2/SearchModulesResponse")]
        System.Threading.Tasks.Task<SLSOCdesktop.ServiceReference2.Modulesc> SearchModulesAsync(string Modcode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/GetComModules", ReplyAction="http://tempuri.org/IService2/GetComModulesResponse")]
        SLSOCdesktop.ServiceReference2.Modulesc[] GetComModules();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/GetComModules", ReplyAction="http://tempuri.org/IService2/GetComModulesResponse")]
        System.Threading.Tasks.Task<SLSOCdesktop.ServiceReference2.Modulesc[]> GetComModulesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/UpdateComModules", ReplyAction="http://tempuri.org/IService2/UpdateComModulesResponse")]
        int UpdateComModules(SLSOCdesktop.ServiceReference2.Modulesc cmu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/UpdateComModules", ReplyAction="http://tempuri.org/IService2/UpdateComModulesResponse")]
        System.Threading.Tasks.Task<int> UpdateComModulesAsync(SLSOCdesktop.ServiceReference2.Modulesc cmu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/DeleteComModules", ReplyAction="http://tempuri.org/IService2/DeleteComModulesResponse")]
        int DeleteComModules(SLSOCdesktop.ServiceReference2.Modulesc cmdel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/DeleteComModules", ReplyAction="http://tempuri.org/IService2/DeleteComModulesResponse")]
        System.Threading.Tasks.Task<int> DeleteComModulesAsync(SLSOCdesktop.ServiceReference2.Modulesc cmdel);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService2Channel : SLSOCdesktop.ServiceReference2.IService2, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service2Client : System.ServiceModel.ClientBase<SLSOCdesktop.ServiceReference2.IService2>, SLSOCdesktop.ServiceReference2.IService2 {
        
        public Service2Client() {
        }
        
        public Service2Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service2Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service2Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service2Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int AddModules(SLSOCdesktop.ServiceReference2.Modulesc md) {
            return base.Channel.AddModules(md);
        }
        
        public System.Threading.Tasks.Task<int> AddModulesAsync(SLSOCdesktop.ServiceReference2.Modulesc md) {
            return base.Channel.AddModulesAsync(md);
        }
        
        public SLSOCdesktop.ServiceReference2.Modulesc SearchModules(string Modcode) {
            return base.Channel.SearchModules(Modcode);
        }
        
        public System.Threading.Tasks.Task<SLSOCdesktop.ServiceReference2.Modulesc> SearchModulesAsync(string Modcode) {
            return base.Channel.SearchModulesAsync(Modcode);
        }
        
        public SLSOCdesktop.ServiceReference2.Modulesc[] GetComModules() {
            return base.Channel.GetComModules();
        }
        
        public System.Threading.Tasks.Task<SLSOCdesktop.ServiceReference2.Modulesc[]> GetComModulesAsync() {
            return base.Channel.GetComModulesAsync();
        }
        
        public int UpdateComModules(SLSOCdesktop.ServiceReference2.Modulesc cmu) {
            return base.Channel.UpdateComModules(cmu);
        }
        
        public System.Threading.Tasks.Task<int> UpdateComModulesAsync(SLSOCdesktop.ServiceReference2.Modulesc cmu) {
            return base.Channel.UpdateComModulesAsync(cmu);
        }
        
        public int DeleteComModules(SLSOCdesktop.ServiceReference2.Modulesc cmdel) {
            return base.Channel.DeleteComModules(cmdel);
        }
        
        public System.Threading.Tasks.Task<int> DeleteComModulesAsync(SLSOCdesktop.ServiceReference2.Modulesc cmdel) {
            return base.Channel.DeleteComModulesAsync(cmdel);
        }
    }
}
