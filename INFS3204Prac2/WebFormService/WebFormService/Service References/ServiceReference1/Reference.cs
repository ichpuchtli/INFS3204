﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.35312
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebFormService.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Food", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WebFormService.ServiceReference1.FoodComputed))]
    public partial class Food : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        private double weightField;
        
        private double fatField;
        
        private int calorieField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public double weight {
            get {
                return this.weightField;
            }
            set {
                if ((this.weightField.Equals(value) != true)) {
                    this.weightField = value;
                    this.RaisePropertyChanged("weight");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public double fat {
            get {
                return this.fatField;
            }
            set {
                if ((this.fatField.Equals(value) != true)) {
                    this.fatField = value;
                    this.RaisePropertyChanged("fat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int calorie {
            get {
                return this.calorieField;
            }
            set {
                if ((this.calorieField.Equals(value) != true)) {
                    this.calorieField = value;
                    this.RaisePropertyChanged("calorie");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="FoodComputed", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class FoodComputed : WebFormService.ServiceReference1.Food {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name name from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FatAndCal", ReplyAction="*")]
        WebFormService.ServiceReference1.FatAndCalResponse FatAndCal(WebFormService.ServiceReference1.FatAndCalRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FatAndCalRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FatAndCal", Namespace="http://tempuri.org/", Order=0)]
        public WebFormService.ServiceReference1.FatAndCalRequestBody Body;
        
        public FatAndCalRequest() {
        }
        
        public FatAndCalRequest(WebFormService.ServiceReference1.FatAndCalRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FatAndCalRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public double weight;
        
        public FatAndCalRequestBody() {
        }
        
        public FatAndCalRequestBody(string name, double weight) {
            this.name = name;
            this.weight = weight;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FatAndCalResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FatAndCalResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebFormService.ServiceReference1.FatAndCalResponseBody Body;
        
        public FatAndCalResponse() {
        }
        
        public FatAndCalResponse(WebFormService.ServiceReference1.FatAndCalResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FatAndCalResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebFormService.ServiceReference1.FoodComputed FatAndCalResult;
        
        public FatAndCalResponseBody() {
        }
        
        public FatAndCalResponseBody(WebFormService.ServiceReference1.FoodComputed FatAndCalResult) {
            this.FatAndCalResult = FatAndCalResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : WebFormService.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<WebFormService.ServiceReference1.WebService1Soap>, WebFormService.ServiceReference1.WebService1Soap {
        
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
        WebFormService.ServiceReference1.FatAndCalResponse WebFormService.ServiceReference1.WebService1Soap.FatAndCal(WebFormService.ServiceReference1.FatAndCalRequest request) {
            return base.Channel.FatAndCal(request);
        }
        
        public WebFormService.ServiceReference1.FoodComputed FatAndCal(string name, double weight) {
            WebFormService.ServiceReference1.FatAndCalRequest inValue = new WebFormService.ServiceReference1.FatAndCalRequest();
            inValue.Body = new WebFormService.ServiceReference1.FatAndCalRequestBody();
            inValue.Body.name = name;
            inValue.Body.weight = weight;
            WebFormService.ServiceReference1.FatAndCalResponse retVal = ((WebFormService.ServiceReference1.WebService1Soap)(this)).FatAndCal(inValue);
            return retVal.Body.FatAndCalResult;
        }
    }
}
