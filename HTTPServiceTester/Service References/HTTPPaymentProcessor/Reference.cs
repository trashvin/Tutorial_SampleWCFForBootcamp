﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HTTPServiceTester.HTTPPaymentProcessor {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PaymentTransaction", Namespace="http://schemas.datacontract.org/2004/07/HTTPPaymentProcessor.Model")]
    [System.SerializableAttribute()]
    public partial class PaymentTransaction : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PaymentAmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TenderTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double TransactionAmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TransactionIDField;
        
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
        public double PaymentAmount {
            get {
                return this.PaymentAmountField;
            }
            set {
                if ((this.PaymentAmountField.Equals(value) != true)) {
                    this.PaymentAmountField = value;
                    this.RaisePropertyChanged("PaymentAmount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TenderType {
            get {
                return this.TenderTypeField;
            }
            set {
                if ((this.TenderTypeField.Equals(value) != true)) {
                    this.TenderTypeField = value;
                    this.RaisePropertyChanged("TenderType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double TransactionAmount {
            get {
                return this.TransactionAmountField;
            }
            set {
                if ((this.TransactionAmountField.Equals(value) != true)) {
                    this.TransactionAmountField = value;
                    this.RaisePropertyChanged("TransactionAmount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TransactionID {
            get {
                return this.TransactionIDField;
            }
            set {
                if ((this.TransactionIDField.Equals(value) != true)) {
                    this.TransactionIDField = value;
                    this.RaisePropertyChanged("TransactionID");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ProcessResult", Namespace="http://schemas.datacontract.org/2004/07/HTTPPaymentProcessor.Model")]
    [System.SerializableAttribute()]
    public partial class ProcessResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReasonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResultField;
        
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
        public string Reason {
            get {
                return this.ReasonField;
            }
            set {
                if ((object.ReferenceEquals(this.ReasonField, value) != true)) {
                    this.ReasonField = value;
                    this.RaisePropertyChanged("Reason");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Result {
            get {
                return this.ResultField;
            }
            set {
                if ((object.ReferenceEquals(this.ResultField, value) != true)) {
                    this.ResultField = value;
                    this.RaisePropertyChanged("Result");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HTTPPaymentProcessor.IPaymentProcessor")]
    public interface IPaymentProcessor {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentProcessor/Process", ReplyAction="http://tempuri.org/IPaymentProcessor/ProcessResponse")]
        HTTPServiceTester.HTTPPaymentProcessor.ProcessResult Process(HTTPServiceTester.HTTPPaymentProcessor.PaymentTransaction transaction);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentProcessor/Process", ReplyAction="http://tempuri.org/IPaymentProcessor/ProcessResponse")]
        System.Threading.Tasks.Task<HTTPServiceTester.HTTPPaymentProcessor.ProcessResult> ProcessAsync(HTTPServiceTester.HTTPPaymentProcessor.PaymentTransaction transaction);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentProcessor/ProcessBatch", ReplyAction="http://tempuri.org/IPaymentProcessor/ProcessBatchResponse")]
        HTTPServiceTester.HTTPPaymentProcessor.ProcessResult[] ProcessBatch(HTTPServiceTester.HTTPPaymentProcessor.PaymentTransaction[] transactions);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentProcessor/ProcessBatch", ReplyAction="http://tempuri.org/IPaymentProcessor/ProcessBatchResponse")]
        System.Threading.Tasks.Task<HTTPServiceTester.HTTPPaymentProcessor.ProcessResult[]> ProcessBatchAsync(HTTPServiceTester.HTTPPaymentProcessor.PaymentTransaction[] transactions);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPaymentProcessorChannel : HTTPServiceTester.HTTPPaymentProcessor.IPaymentProcessor, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PaymentProcessorClient : System.ServiceModel.ClientBase<HTTPServiceTester.HTTPPaymentProcessor.IPaymentProcessor>, HTTPServiceTester.HTTPPaymentProcessor.IPaymentProcessor {
        
        public PaymentProcessorClient() {
        }
        
        public PaymentProcessorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PaymentProcessorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PaymentProcessorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PaymentProcessorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public HTTPServiceTester.HTTPPaymentProcessor.ProcessResult Process(HTTPServiceTester.HTTPPaymentProcessor.PaymentTransaction transaction) {
            return base.Channel.Process(transaction);
        }
        
        public System.Threading.Tasks.Task<HTTPServiceTester.HTTPPaymentProcessor.ProcessResult> ProcessAsync(HTTPServiceTester.HTTPPaymentProcessor.PaymentTransaction transaction) {
            return base.Channel.ProcessAsync(transaction);
        }
        
        public HTTPServiceTester.HTTPPaymentProcessor.ProcessResult[] ProcessBatch(HTTPServiceTester.HTTPPaymentProcessor.PaymentTransaction[] transactions) {
            return base.Channel.ProcessBatch(transactions);
        }
        
        public System.Threading.Tasks.Task<HTTPServiceTester.HTTPPaymentProcessor.ProcessResult[]> ProcessBatchAsync(HTTPServiceTester.HTTPPaymentProcessor.PaymentTransaction[] transactions) {
            return base.Channel.ProcessBatchAsync(transactions);
        }
    }
}