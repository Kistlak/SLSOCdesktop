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
    }
}