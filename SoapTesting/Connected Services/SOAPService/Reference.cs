﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoapTesting.SOAPService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Producto", Namespace="http://schemas.datacontract.org/2004/07/SOAP")]
    [System.SerializableAttribute()]
    public partial class Producto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime datesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int detailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double priceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int quantityField;
        
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
        public System.DateTime dates {
            get {
                return this.datesField;
            }
            set {
                if ((this.datesField.Equals(value) != true)) {
                    this.datesField = value;
                    this.RaisePropertyChanged("dates");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int detail {
            get {
                return this.detailField;
            }
            set {
                if ((this.detailField.Equals(value) != true)) {
                    this.detailField = value;
                    this.RaisePropertyChanged("detail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double price {
            get {
                return this.priceField;
            }
            set {
                if ((this.priceField.Equals(value) != true)) {
                    this.priceField = value;
                    this.RaisePropertyChanged("price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int quantity {
            get {
                return this.quantityField;
            }
            set {
                if ((this.quantityField.Equals(value) != true)) {
                    this.quantityField = value;
                    this.RaisePropertyChanged("quantity");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SOAPService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SP_LISTARPRODUCTO", ReplyAction="http://tempuri.org/IService1/SP_LISTARPRODUCTOResponse")]
        System.Data.DataSet SP_LISTARPRODUCTO();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SP_LISTARPRODUCTO", ReplyAction="http://tempuri.org/IService1/SP_LISTARPRODUCTOResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SP_LISTARPRODUCTOAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SP_INSERTARPRODUCTO", ReplyAction="http://tempuri.org/IService1/SP_INSERTARPRODUCTOResponse")]
        void SP_INSERTARPRODUCTO(SoapTesting.SOAPService.Producto prod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SP_INSERTARPRODUCTO", ReplyAction="http://tempuri.org/IService1/SP_INSERTARPRODUCTOResponse")]
        System.Threading.Tasks.Task SP_INSERTARPRODUCTOAsync(SoapTesting.SOAPService.Producto prod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SP_ACTUALIZARPRODUCTO", ReplyAction="http://tempuri.org/IService1/SP_ACTUALIZARPRODUCTOResponse")]
        void SP_ACTUALIZARPRODUCTO(SoapTesting.SOAPService.Producto prod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SP_ACTUALIZARPRODUCTO", ReplyAction="http://tempuri.org/IService1/SP_ACTUALIZARPRODUCTOResponse")]
        System.Threading.Tasks.Task SP_ACTUALIZARPRODUCTOAsync(SoapTesting.SOAPService.Producto prod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SP_ELIMINARPRODUCTO", ReplyAction="http://tempuri.org/IService1/SP_ELIMINARPRODUCTOResponse")]
        void SP_ELIMINARPRODUCTO(SoapTesting.SOAPService.Producto prod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SP_ELIMINARPRODUCTO", ReplyAction="http://tempuri.org/IService1/SP_ELIMINARPRODUCTOResponse")]
        System.Threading.Tasks.Task SP_ELIMINARPRODUCTOAsync(SoapTesting.SOAPService.Producto prod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SP_BUSCARPRODUCTO", ReplyAction="http://tempuri.org/IService1/SP_BUSCARPRODUCTOResponse")]
        System.Data.DataSet SP_BUSCARPRODUCTO(SoapTesting.SOAPService.Producto prod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SP_BUSCARPRODUCTO", ReplyAction="http://tempuri.org/IService1/SP_BUSCARPRODUCTOResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SP_BUSCARPRODUCTOAsync(SoapTesting.SOAPService.Producto prod);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : SoapTesting.SOAPService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<SoapTesting.SOAPService.IService1>, SoapTesting.SOAPService.IService1 {
        
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
        
        public System.Data.DataSet SP_LISTARPRODUCTO() {
            return base.Channel.SP_LISTARPRODUCTO();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SP_LISTARPRODUCTOAsync() {
            return base.Channel.SP_LISTARPRODUCTOAsync();
        }
        
        public void SP_INSERTARPRODUCTO(SoapTesting.SOAPService.Producto prod) {
            base.Channel.SP_INSERTARPRODUCTO(prod);
        }
        
        public System.Threading.Tasks.Task SP_INSERTARPRODUCTOAsync(SoapTesting.SOAPService.Producto prod) {
            return base.Channel.SP_INSERTARPRODUCTOAsync(prod);
        }
        
        public void SP_ACTUALIZARPRODUCTO(SoapTesting.SOAPService.Producto prod) {
            base.Channel.SP_ACTUALIZARPRODUCTO(prod);
        }
        
        public System.Threading.Tasks.Task SP_ACTUALIZARPRODUCTOAsync(SoapTesting.SOAPService.Producto prod) {
            return base.Channel.SP_ACTUALIZARPRODUCTOAsync(prod);
        }
        
        public void SP_ELIMINARPRODUCTO(SoapTesting.SOAPService.Producto prod) {
            base.Channel.SP_ELIMINARPRODUCTO(prod);
        }
        
        public System.Threading.Tasks.Task SP_ELIMINARPRODUCTOAsync(SoapTesting.SOAPService.Producto prod) {
            return base.Channel.SP_ELIMINARPRODUCTOAsync(prod);
        }
        
        public System.Data.DataSet SP_BUSCARPRODUCTO(SoapTesting.SOAPService.Producto prod) {
            return base.Channel.SP_BUSCARPRODUCTO(prod);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SP_BUSCARPRODUCTOAsync(SoapTesting.SOAPService.Producto prod) {
            return base.Channel.SP_BUSCARPRODUCTOAsync(prod);
        }
    }
}
