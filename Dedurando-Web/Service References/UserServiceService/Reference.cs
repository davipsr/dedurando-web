﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.UserServiceService {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://business.dedurando.com.br")]
    public partial class RegisterException : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://bean.dedurando.com.br")]
    public partial class User : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string cityField;
        
        private string confirmation_tokenField;
        
        private string countryField;
        
        private System.Nullable<System.DateTime> created_atField;
        
        private string firstNameField;
        
        private string ipAddressField;
        
        private string lastNameField;
        
        private string mailField;
        
        private string passwordField;
        
        private string phoneField;
        
        private byte[] photoField;
        
        private string resetPasswordTokenField;
        
        private int statusField;
        
        private System.Nullable<long> userIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string city {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
                this.RaisePropertyChanged("city");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string confirmation_token {
            get {
                return this.confirmation_tokenField;
            }
            set {
                this.confirmation_tokenField = value;
                this.RaisePropertyChanged("confirmation_token");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public string country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
                this.RaisePropertyChanged("country");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public System.Nullable<System.DateTime> created_at {
            get {
                return this.created_atField;
            }
            set {
                this.created_atField = value;
                this.RaisePropertyChanged("created_at");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public string firstName {
            get {
                return this.firstNameField;
            }
            set {
                this.firstNameField = value;
                this.RaisePropertyChanged("firstName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public string ipAddress {
            get {
                return this.ipAddressField;
            }
            set {
                this.ipAddressField = value;
                this.RaisePropertyChanged("ipAddress");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public string lastName {
            get {
                return this.lastNameField;
            }
            set {
                this.lastNameField = value;
                this.RaisePropertyChanged("lastName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public string mail {
            get {
                return this.mailField;
            }
            set {
                this.mailField = value;
                this.RaisePropertyChanged("mail");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
                this.RaisePropertyChanged("password");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
        public string phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
                this.RaisePropertyChanged("phone");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", IsNullable=true, Order=10)]
        public byte[] photo {
            get {
                return this.photoField;
            }
            set {
                this.photoField = value;
                this.RaisePropertyChanged("photo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
        public string resetPasswordToken {
            get {
                return this.resetPasswordTokenField;
            }
            set {
                this.resetPasswordTokenField = value;
                this.RaisePropertyChanged("resetPasswordToken");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public int status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
                this.RaisePropertyChanged("status");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=13)]
        public System.Nullable<long> userId {
            get {
                return this.userIdField;
            }
            set {
                this.userIdField = value;
                this.RaisePropertyChanged("userId");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://business.dedurando.com.br")]
    public partial class BusinessException : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://service.dedurando.com.br", ConfigurationName="UserServiceService.UserService")]
    public interface UserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Core.UserServiceService.RegisterException), Action="", Name="fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="registerReturn")]
        Core.UserServiceService.User register(Core.UserServiceService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="findReturn")]
        Core.UserServiceService.User find(Core.UserServiceService.User user);
        
        // CODEGEN: Parameter 'findAllReturn' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="findAllReturn")]
        Core.UserServiceService.findAllResponse findAll(Core.UserServiceService.findAllRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Core.UserServiceService.RegisterException), Action="", Name="fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="unRegisterReturn")]
        Core.UserServiceService.User unRegister(Core.UserServiceService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Core.UserServiceService.BusinessException), Action="", Name="fault1")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="signInReturn")]
        bool signIn(Core.UserServiceService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Core.UserServiceService.BusinessException), Action="", Name="fault1")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="resetPasswordReturn")]
        bool resetPassword(Core.UserServiceService.User user);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="findAll", WrapperNamespace="http://service.dedurando.com.br", IsWrapped=true)]
    public partial class findAllRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.dedurando.com.br", Order=0)]
        public Core.UserServiceService.User user;
        
        public findAllRequest() {
        }
        
        public findAllRequest(Core.UserServiceService.User user) {
            this.user = user;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="findAllResponse", WrapperNamespace="http://service.dedurando.com.br", IsWrapped=true)]
    public partial class findAllResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.dedurando.com.br", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("findAllReturn")]
        public User[] findAllReturn;
        
        public findAllResponse() {
        }
        
        public findAllResponse(User[] findAllReturn) {
            this.findAllReturn = findAllReturn;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface UserServiceChannel : Core.UserServiceService.UserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<Core.UserServiceService.UserService>, Core.UserServiceService.UserService {
        
        public UserServiceClient() {
        }
        
        public UserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Core.UserServiceService.User register(Core.UserServiceService.User user) {
            return base.Channel.register(user);
        }
        
        public Core.UserServiceService.User find(Core.UserServiceService.User user) {
            return base.Channel.find(user);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Core.UserServiceService.findAllResponse Core.UserServiceService.UserService.findAll(Core.UserServiceService.findAllRequest request) {
            return base.Channel.findAll(request);
        }
        
        public User[] findAll(Core.UserServiceService.User user) {
            Core.UserServiceService.findAllRequest inValue = new Core.UserServiceService.findAllRequest();
            inValue.user = user;
            Core.UserServiceService.findAllResponse retVal = ((Core.UserServiceService.UserService)(this)).findAll(inValue);
            return retVal.findAllReturn;
        }
        
        public Core.UserServiceService.User unRegister(Core.UserServiceService.User user) {
            return base.Channel.unRegister(user);
        }
        
        public bool signIn(Core.UserServiceService.User user) {
            return base.Channel.signIn(user);
        }
        
        public bool resetPassword(Core.UserServiceService.User user) {
            return base.Channel.resetPassword(user);
        }
    }
}