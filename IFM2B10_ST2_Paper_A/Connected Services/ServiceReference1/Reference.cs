﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IFM2B10_ST2_Paper_A.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Item", Namespace="http://schemas.datacontract.org/2004/07/IFM2B10_ST2_Paper_A_Service")]
    [System.SerializableAttribute()]
    public partial class Item : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ActiveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OnSpecialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
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
        public int Active {
            get {
                return this.ActiveField;
            }
            set {
                if ((this.ActiveField.Equals(value) != true)) {
                    this.ActiveField = value;
                    this.RaisePropertyChanged("Active");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryField, value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Image {
            get {
                return this.ImageField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageField, value) != true)) {
                    this.ImageField = value;
                    this.RaisePropertyChanged("Image");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OnSpecial {
            get {
                return this.OnSpecialField;
            }
            set {
                if ((this.OnSpecialField.Equals(value) != true)) {
                    this.OnSpecialField = value;
                    this.RaisePropertyChanged("OnSpecial");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="itemMenu", Namespace="http://schemas.datacontract.org/2004/07/IFM2B10_ST2_Paper_A_Service")]
    [System.SerializableAttribute()]
    public partial class itemMenu : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ActiveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OnSpecialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
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
        public int Active {
            get {
                return this.ActiveField;
            }
            set {
                if ((this.ActiveField.Equals(value) != true)) {
                    this.ActiveField = value;
                    this.RaisePropertyChanged("Active");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryField, value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Image {
            get {
                return this.ImageField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageField, value) != true)) {
                    this.ImageField = value;
                    this.RaisePropertyChanged("Image");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OnSpecial {
            get {
                return this.OnSpecialField;
            }
            set {
                if ((this.OnSpecialField.Equals(value) != true)) {
                    this.OnSpecialField = value;
                    this.RaisePropertyChanged("OnSpecial");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Reservation", Namespace="http://schemas.datacontract.org/2004/07/IFM2B10_ST2_Paper_A_Service")]
    [System.SerializableAttribute()]
    public partial class Reservation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NoteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PersonsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TimeField;
        
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
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Note {
            get {
                return this.NoteField;
            }
            set {
                if ((object.ReferenceEquals(this.NoteField, value) != true)) {
                    this.NoteField = value;
                    this.RaisePropertyChanged("Note");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Persons {
            get {
                return this.PersonsField;
            }
            set {
                if ((this.PersonsField.Equals(value) != true)) {
                    this.PersonsField = value;
                    this.RaisePropertyChanged("Persons");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Time {
            get {
                return this.TimeField;
            }
            set {
                if ((object.ReferenceEquals(this.TimeField, value) != true)) {
                    this.TimeField = value;
                    this.RaisePropertyChanged("Time");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IPaperAService")]
    public interface IPaperAService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaperAService/getOEI", ReplyAction="http://tempuri.org/IPaperAService/getOEIResponse")]
        IFM2B10_ST2_Paper_A.ServiceReference1.Item[] getOEI();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaperAService/getOEI", ReplyAction="http://tempuri.org/IPaperAService/getOEIResponse")]
        System.Threading.Tasks.Task<IFM2B10_ST2_Paper_A.ServiceReference1.Item[]> getOEIAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaperAService/getmealType", ReplyAction="http://tempuri.org/IPaperAService/getmealTypeResponse")]
        IFM2B10_ST2_Paper_A.ServiceReference1.itemMenu[] getmealType();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaperAService/getmealType", ReplyAction="http://tempuri.org/IPaperAService/getmealTypeResponse")]
        System.Threading.Tasks.Task<IFM2B10_ST2_Paper_A.ServiceReference1.itemMenu[]> getmealTypeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaperAService/getSingleProduct", ReplyAction="http://tempuri.org/IPaperAService/getSingleProductResponse")]
        IFM2B10_ST2_Paper_A.ServiceReference1.itemMenu getSingleProduct(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaperAService/getSingleProduct", ReplyAction="http://tempuri.org/IPaperAService/getSingleProductResponse")]
        System.Threading.Tasks.Task<IFM2B10_ST2_Paper_A.ServiceReference1.itemMenu> getSingleProductAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaperAService/addBooking", ReplyAction="http://tempuri.org/IPaperAService/addBookingResponse")]
        bool addBooking(string name, string email, int persons, string phone, System.DateTime mydate, string time, string note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaperAService/addBooking", ReplyAction="http://tempuri.org/IPaperAService/addBookingResponse")]
        System.Threading.Tasks.Task<bool> addBookingAsync(string name, string email, int persons, string phone, System.DateTime mydate, string time, string note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaperAService/checkIfExist", ReplyAction="http://tempuri.org/IPaperAService/checkIfExistResponse")]
        bool checkIfExist(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaperAService/checkIfExist", ReplyAction="http://tempuri.org/IPaperAService/checkIfExistResponse")]
        System.Threading.Tasks.Task<bool> checkIfExistAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaperAService/getEmail", ReplyAction="http://tempuri.org/IPaperAService/getEmailResponse")]
        IFM2B10_ST2_Paper_A.ServiceReference1.Reservation getEmail(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaperAService/getEmail", ReplyAction="http://tempuri.org/IPaperAService/getEmailResponse")]
        System.Threading.Tasks.Task<IFM2B10_ST2_Paper_A.ServiceReference1.Reservation> getEmailAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaperAService/editReservation", ReplyAction="http://tempuri.org/IPaperAService/editReservationResponse")]
        bool editReservation(string name, string email, int persons, string phone, System.DateTime mydate, string time, string note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaperAService/editReservation", ReplyAction="http://tempuri.org/IPaperAService/editReservationResponse")]
        System.Threading.Tasks.Task<bool> editReservationAsync(string name, string email, int persons, string phone, System.DateTime mydate, string time, string note);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPaperAServiceChannel : IFM2B10_ST2_Paper_A.ServiceReference1.IPaperAService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PaperAServiceClient : System.ServiceModel.ClientBase<IFM2B10_ST2_Paper_A.ServiceReference1.IPaperAService>, IFM2B10_ST2_Paper_A.ServiceReference1.IPaperAService {
        
        public PaperAServiceClient() {
        }
        
        public PaperAServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PaperAServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PaperAServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PaperAServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public IFM2B10_ST2_Paper_A.ServiceReference1.Item[] getOEI() {
            return base.Channel.getOEI();
        }
        
        public System.Threading.Tasks.Task<IFM2B10_ST2_Paper_A.ServiceReference1.Item[]> getOEIAsync() {
            return base.Channel.getOEIAsync();
        }
        
        public IFM2B10_ST2_Paper_A.ServiceReference1.itemMenu[] getmealType() {
            return base.Channel.getmealType();
        }
        
        public System.Threading.Tasks.Task<IFM2B10_ST2_Paper_A.ServiceReference1.itemMenu[]> getmealTypeAsync() {
            return base.Channel.getmealTypeAsync();
        }
        
        public IFM2B10_ST2_Paper_A.ServiceReference1.itemMenu getSingleProduct(int ID) {
            return base.Channel.getSingleProduct(ID);
        }
        
        public System.Threading.Tasks.Task<IFM2B10_ST2_Paper_A.ServiceReference1.itemMenu> getSingleProductAsync(int ID) {
            return base.Channel.getSingleProductAsync(ID);
        }
        
        public bool addBooking(string name, string email, int persons, string phone, System.DateTime mydate, string time, string note) {
            return base.Channel.addBooking(name, email, persons, phone, mydate, time, note);
        }
        
        public System.Threading.Tasks.Task<bool> addBookingAsync(string name, string email, int persons, string phone, System.DateTime mydate, string time, string note) {
            return base.Channel.addBookingAsync(name, email, persons, phone, mydate, time, note);
        }
        
        public bool checkIfExist(string email) {
            return base.Channel.checkIfExist(email);
        }
        
        public System.Threading.Tasks.Task<bool> checkIfExistAsync(string email) {
            return base.Channel.checkIfExistAsync(email);
        }
        
        public IFM2B10_ST2_Paper_A.ServiceReference1.Reservation getEmail(int ID) {
            return base.Channel.getEmail(ID);
        }
        
        public System.Threading.Tasks.Task<IFM2B10_ST2_Paper_A.ServiceReference1.Reservation> getEmailAsync(int ID) {
            return base.Channel.getEmailAsync(ID);
        }
        
        public bool editReservation(string name, string email, int persons, string phone, System.DateTime mydate, string time, string note) {
            return base.Channel.editReservation(name, email, persons, phone, mydate, time, note);
        }
        
        public System.Threading.Tasks.Task<bool> editReservationAsync(string name, string email, int persons, string phone, System.DateTime mydate, string time, string note) {
            return base.Channel.editReservationAsync(name, email, persons, phone, mydate, time, note);
        }
    }
}
