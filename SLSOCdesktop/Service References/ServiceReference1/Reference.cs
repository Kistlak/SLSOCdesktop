﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SLSOCdesktop.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/SLSOCserver")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Users", Namespace="http://schemas.datacontract.org/2004/07/SLSOCserver")]
    [System.SerializableAttribute()]
    public partial class Users : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Lecturersc", Namespace="http://schemas.datacontract.org/2004/07/SLSOCserver")]
    [System.SerializableAttribute()]
    public partial class Lecturersc : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AdoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AdtwoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FacultyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string JdateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModuleoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModulethreeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModuletwoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RdateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        public string Adone {
            get {
                return this.AdoneField;
            }
            set {
                if ((object.ReferenceEquals(this.AdoneField, value) != true)) {
                    this.AdoneField = value;
                    this.RaisePropertyChanged("Adone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Adtwo {
            get {
                return this.AdtwoField;
            }
            set {
                if ((object.ReferenceEquals(this.AdtwoField, value) != true)) {
                    this.AdtwoField = value;
                    this.RaisePropertyChanged("Adtwo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Faculty {
            get {
                return this.FacultyField;
            }
            set {
                if ((object.ReferenceEquals(this.FacultyField, value) != true)) {
                    this.FacultyField = value;
                    this.RaisePropertyChanged("Faculty");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Fname {
            get {
                return this.FnameField;
            }
            set {
                if ((object.ReferenceEquals(this.FnameField, value) != true)) {
                    this.FnameField = value;
                    this.RaisePropertyChanged("Fname");
                }
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
        public string Jdate {
            get {
                return this.JdateField;
            }
            set {
                if ((object.ReferenceEquals(this.JdateField, value) != true)) {
                    this.JdateField = value;
                    this.RaisePropertyChanged("Jdate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Lname {
            get {
                return this.LnameField;
            }
            set {
                if ((object.ReferenceEquals(this.LnameField, value) != true)) {
                    this.LnameField = value;
                    this.RaisePropertyChanged("Lname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Moduleone {
            get {
                return this.ModuleoneField;
            }
            set {
                if ((object.ReferenceEquals(this.ModuleoneField, value) != true)) {
                    this.ModuleoneField = value;
                    this.RaisePropertyChanged("Moduleone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Modulethree {
            get {
                return this.ModulethreeField;
            }
            set {
                if ((object.ReferenceEquals(this.ModulethreeField, value) != true)) {
                    this.ModulethreeField = value;
                    this.RaisePropertyChanged("Modulethree");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Moduletwo {
            get {
                return this.ModuletwoField;
            }
            set {
                if ((object.ReferenceEquals(this.ModuletwoField, value) != true)) {
                    this.ModuletwoField = value;
                    this.RaisePropertyChanged("Moduletwo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Number {
            get {
                return this.NumberField;
            }
            set {
                if ((object.ReferenceEquals(this.NumberField, value) != true)) {
                    this.NumberField = value;
                    this.RaisePropertyChanged("Number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Rdate {
            get {
                return this.RdateField;
            }
            set {
                if ((object.ReferenceEquals(this.RdateField, value) != true)) {
                    this.RdateField = value;
                    this.RaisePropertyChanged("Rdate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Studentsc", Namespace="http://schemas.datacontract.org/2004/07/SLSOCserver")]
    [System.SerializableAttribute()]
    public partial class Studentsc : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AdoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AdtwoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ByearField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FacultyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string JdateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NicField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        public string Adone {
            get {
                return this.AdoneField;
            }
            set {
                if ((object.ReferenceEquals(this.AdoneField, value) != true)) {
                    this.AdoneField = value;
                    this.RaisePropertyChanged("Adone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Adtwo {
            get {
                return this.AdtwoField;
            }
            set {
                if ((object.ReferenceEquals(this.AdtwoField, value) != true)) {
                    this.AdtwoField = value;
                    this.RaisePropertyChanged("Adtwo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Byear {
            get {
                return this.ByearField;
            }
            set {
                if ((object.ReferenceEquals(this.ByearField, value) != true)) {
                    this.ByearField = value;
                    this.RaisePropertyChanged("Byear");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Faculty {
            get {
                return this.FacultyField;
            }
            set {
                if ((object.ReferenceEquals(this.FacultyField, value) != true)) {
                    this.FacultyField = value;
                    this.RaisePropertyChanged("Faculty");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Fname {
            get {
                return this.FnameField;
            }
            set {
                if ((object.ReferenceEquals(this.FnameField, value) != true)) {
                    this.FnameField = value;
                    this.RaisePropertyChanged("Fname");
                }
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
        public string Jdate {
            get {
                return this.JdateField;
            }
            set {
                if ((object.ReferenceEquals(this.JdateField, value) != true)) {
                    this.JdateField = value;
                    this.RaisePropertyChanged("Jdate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Lname {
            get {
                return this.LnameField;
            }
            set {
                if ((object.ReferenceEquals(this.LnameField, value) != true)) {
                    this.LnameField = value;
                    this.RaisePropertyChanged("Lname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nic {
            get {
                return this.NicField;
            }
            set {
                if ((object.ReferenceEquals(this.NicField, value) != true)) {
                    this.NicField = value;
                    this.RaisePropertyChanged("Nic");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Number {
            get {
                return this.NumberField;
            }
            set {
                if ((object.ReferenceEquals(this.NumberField, value) != true)) {
                    this.NumberField = value;
                    this.RaisePropertyChanged("Number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        SLSOCdesktop.ServiceReference1.CompositeType GetDataUsingDataContract(SLSOCdesktop.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<SLSOCdesktop.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(SLSOCdesktop.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        int Login(SLSOCdesktop.ServiceReference1.Users ud);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        System.Threading.Tasks.Task<int> LoginAsync(SLSOCdesktop.ServiceReference1.Users ud);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveLecturers", ReplyAction="http://tempuri.org/IService1/SaveLecturersResponse")]
        int SaveLecturers(SLSOCdesktop.ServiceReference1.Lecturersc ld);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveLecturers", ReplyAction="http://tempuri.org/IService1/SaveLecturersResponse")]
        System.Threading.Tasks.Task<int> SaveLecturersAsync(SLSOCdesktop.ServiceReference1.Lecturersc ld);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetLecturersDetails", ReplyAction="http://tempuri.org/IService1/GetLecturersDetailsResponse")]
        SLSOCdesktop.ServiceReference1.Lecturersc[] GetLecturersDetails();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetLecturersDetails", ReplyAction="http://tempuri.org/IService1/GetLecturersDetailsResponse")]
        System.Threading.Tasks.Task<SLSOCdesktop.ServiceReference1.Lecturersc[]> GetLecturersDetailsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchLecturers", ReplyAction="http://tempuri.org/IService1/SearchLecturersResponse")]
        SLSOCdesktop.ServiceReference1.Lecturersc SearchLecturers(SLSOCdesktop.ServiceReference1.Lecturersc ls);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchLecturers", ReplyAction="http://tempuri.org/IService1/SearchLecturersResponse")]
        System.Threading.Tasks.Task<SLSOCdesktop.ServiceReference1.Lecturersc> SearchLecturersAsync(SLSOCdesktop.ServiceReference1.Lecturersc ls);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateLecturers", ReplyAction="http://tempuri.org/IService1/UpdateLecturersResponse")]
        int UpdateLecturers(SLSOCdesktop.ServiceReference1.Lecturersc lu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateLecturers", ReplyAction="http://tempuri.org/IService1/UpdateLecturersResponse")]
        System.Threading.Tasks.Task<int> UpdateLecturersAsync(SLSOCdesktop.ServiceReference1.Lecturersc lu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteLecturers", ReplyAction="http://tempuri.org/IService1/DeleteLecturersResponse")]
        int DeleteLecturers(SLSOCdesktop.ServiceReference1.Lecturersc ldel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteLecturers", ReplyAction="http://tempuri.org/IService1/DeleteLecturersResponse")]
        System.Threading.Tasks.Task<int> DeleteLecturersAsync(SLSOCdesktop.ServiceReference1.Lecturersc ldel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveStudents", ReplyAction="http://tempuri.org/IService1/SaveStudentsResponse")]
        int SaveStudents(SLSOCdesktop.ServiceReference1.Studentsc sd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveStudents", ReplyAction="http://tempuri.org/IService1/SaveStudentsResponse")]
        System.Threading.Tasks.Task<int> SaveStudentsAsync(SLSOCdesktop.ServiceReference1.Studentsc sd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStudentsDetails", ReplyAction="http://tempuri.org/IService1/GetStudentsDetailsResponse")]
        SLSOCdesktop.ServiceReference1.Studentsc[] GetStudentsDetails();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStudentsDetails", ReplyAction="http://tempuri.org/IService1/GetStudentsDetailsResponse")]
        System.Threading.Tasks.Task<SLSOCdesktop.ServiceReference1.Studentsc[]> GetStudentsDetailsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchStudents", ReplyAction="http://tempuri.org/IService1/SearchStudentsResponse")]
        SLSOCdesktop.ServiceReference1.Studentsc SearchStudents(SLSOCdesktop.ServiceReference1.Studentsc ss);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchStudents", ReplyAction="http://tempuri.org/IService1/SearchStudentsResponse")]
        System.Threading.Tasks.Task<SLSOCdesktop.ServiceReference1.Studentsc> SearchStudentsAsync(SLSOCdesktop.ServiceReference1.Studentsc ss);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateStudents", ReplyAction="http://tempuri.org/IService1/UpdateStudentsResponse")]
        int UpdateStudents(SLSOCdesktop.ServiceReference1.Studentsc su);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateStudents", ReplyAction="http://tempuri.org/IService1/UpdateStudentsResponse")]
        System.Threading.Tasks.Task<int> UpdateStudentsAsync(SLSOCdesktop.ServiceReference1.Studentsc su);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteStudents", ReplyAction="http://tempuri.org/IService1/DeleteStudentsResponse")]
        int DeleteStudents(SLSOCdesktop.ServiceReference1.Studentsc sdel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteStudents", ReplyAction="http://tempuri.org/IService1/DeleteStudentsResponse")]
        System.Threading.Tasks.Task<int> DeleteStudentsAsync(SLSOCdesktop.ServiceReference1.Studentsc sdel);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : SLSOCdesktop.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<SLSOCdesktop.ServiceReference1.IService1>, SLSOCdesktop.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public SLSOCdesktop.ServiceReference1.CompositeType GetDataUsingDataContract(SLSOCdesktop.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<SLSOCdesktop.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(SLSOCdesktop.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public int Login(SLSOCdesktop.ServiceReference1.Users ud) {
            return base.Channel.Login(ud);
        }
        
        public System.Threading.Tasks.Task<int> LoginAsync(SLSOCdesktop.ServiceReference1.Users ud) {
            return base.Channel.LoginAsync(ud);
        }
        
        public int SaveLecturers(SLSOCdesktop.ServiceReference1.Lecturersc ld) {
            return base.Channel.SaveLecturers(ld);
        }
        
        public System.Threading.Tasks.Task<int> SaveLecturersAsync(SLSOCdesktop.ServiceReference1.Lecturersc ld) {
            return base.Channel.SaveLecturersAsync(ld);
        }
        
        public SLSOCdesktop.ServiceReference1.Lecturersc[] GetLecturersDetails() {
            return base.Channel.GetLecturersDetails();
        }
        
        public System.Threading.Tasks.Task<SLSOCdesktop.ServiceReference1.Lecturersc[]> GetLecturersDetailsAsync() {
            return base.Channel.GetLecturersDetailsAsync();
        }
        
        public SLSOCdesktop.ServiceReference1.Lecturersc SearchLecturers(SLSOCdesktop.ServiceReference1.Lecturersc ls) {
            return base.Channel.SearchLecturers(ls);
        }
        
        public System.Threading.Tasks.Task<SLSOCdesktop.ServiceReference1.Lecturersc> SearchLecturersAsync(SLSOCdesktop.ServiceReference1.Lecturersc ls) {
            return base.Channel.SearchLecturersAsync(ls);
        }
        
        public int UpdateLecturers(SLSOCdesktop.ServiceReference1.Lecturersc lu) {
            return base.Channel.UpdateLecturers(lu);
        }
        
        public System.Threading.Tasks.Task<int> UpdateLecturersAsync(SLSOCdesktop.ServiceReference1.Lecturersc lu) {
            return base.Channel.UpdateLecturersAsync(lu);
        }
        
        public int DeleteLecturers(SLSOCdesktop.ServiceReference1.Lecturersc ldel) {
            return base.Channel.DeleteLecturers(ldel);
        }
        
        public System.Threading.Tasks.Task<int> DeleteLecturersAsync(SLSOCdesktop.ServiceReference1.Lecturersc ldel) {
            return base.Channel.DeleteLecturersAsync(ldel);
        }
        
        public int SaveStudents(SLSOCdesktop.ServiceReference1.Studentsc sd) {
            return base.Channel.SaveStudents(sd);
        }
        
        public System.Threading.Tasks.Task<int> SaveStudentsAsync(SLSOCdesktop.ServiceReference1.Studentsc sd) {
            return base.Channel.SaveStudentsAsync(sd);
        }
        
        public SLSOCdesktop.ServiceReference1.Studentsc[] GetStudentsDetails() {
            return base.Channel.GetStudentsDetails();
        }
        
        public System.Threading.Tasks.Task<SLSOCdesktop.ServiceReference1.Studentsc[]> GetStudentsDetailsAsync() {
            return base.Channel.GetStudentsDetailsAsync();
        }
        
        public SLSOCdesktop.ServiceReference1.Studentsc SearchStudents(SLSOCdesktop.ServiceReference1.Studentsc ss) {
            return base.Channel.SearchStudents(ss);
        }
        
        public System.Threading.Tasks.Task<SLSOCdesktop.ServiceReference1.Studentsc> SearchStudentsAsync(SLSOCdesktop.ServiceReference1.Studentsc ss) {
            return base.Channel.SearchStudentsAsync(ss);
        }
        
        public int UpdateStudents(SLSOCdesktop.ServiceReference1.Studentsc su) {
            return base.Channel.UpdateStudents(su);
        }
        
        public System.Threading.Tasks.Task<int> UpdateStudentsAsync(SLSOCdesktop.ServiceReference1.Studentsc su) {
            return base.Channel.UpdateStudentsAsync(su);
        }
        
        public int DeleteStudents(SLSOCdesktop.ServiceReference1.Studentsc sdel) {
            return base.Channel.DeleteStudents(sdel);
        }
        
        public System.Threading.Tasks.Task<int> DeleteStudentsAsync(SLSOCdesktop.ServiceReference1.Studentsc sdel) {
            return base.Channel.DeleteStudentsAsync(sdel);
        }

        internal int SaveLecturers(Studentsc sdc)
        {
            throw new NotImplementedException();
        }
    }
}
