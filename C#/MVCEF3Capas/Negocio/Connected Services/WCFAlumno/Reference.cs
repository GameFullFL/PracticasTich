﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Negocio.WCFAlumno {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AportacionesIMSS", Namespace="http://schemas.datacontract.org/2004/07/WCFAlumnos")]
    [System.SerializableAttribute()]
    public partial class AportacionesIMSS : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal cesantiaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal enfermedadMaternidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal infonavitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal invalidezVidaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal retiroField;
        
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
        public decimal cesantia {
            get {
                return this.cesantiaField;
            }
            set {
                if ((this.cesantiaField.Equals(value) != true)) {
                    this.cesantiaField = value;
                    this.RaisePropertyChanged("cesantia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal enfermedadMaternidad {
            get {
                return this.enfermedadMaternidadField;
            }
            set {
                if ((this.enfermedadMaternidadField.Equals(value) != true)) {
                    this.enfermedadMaternidadField = value;
                    this.RaisePropertyChanged("enfermedadMaternidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal infonavit {
            get {
                return this.infonavitField;
            }
            set {
                if ((this.infonavitField.Equals(value) != true)) {
                    this.infonavitField = value;
                    this.RaisePropertyChanged("infonavit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal invalidezVida {
            get {
                return this.invalidezVidaField;
            }
            set {
                if ((this.invalidezVidaField.Equals(value) != true)) {
                    this.invalidezVidaField = value;
                    this.RaisePropertyChanged("invalidezVida");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal retiro {
            get {
                return this.retiroField;
            }
            set {
                if ((this.retiroField.Equals(value) != true)) {
                    this.retiroField = value;
                    this.RaisePropertyChanged("retiro");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ItemTablaISR", Namespace="http://schemas.datacontract.org/2004/07/WCFAlumnos")]
    [System.SerializableAttribute()]
    public partial class ItemTablaISR : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ExcedenteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ISRField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal cuotaFijaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal limInfField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal limSupField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal subsidioField;
        
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
        public decimal Excedente {
            get {
                return this.ExcedenteField;
            }
            set {
                if ((this.ExcedenteField.Equals(value) != true)) {
                    this.ExcedenteField = value;
                    this.RaisePropertyChanged("Excedente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal ISR {
            get {
                return this.ISRField;
            }
            set {
                if ((this.ISRField.Equals(value) != true)) {
                    this.ISRField = value;
                    this.RaisePropertyChanged("ISR");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal cuotaFija {
            get {
                return this.cuotaFijaField;
            }
            set {
                if ((this.cuotaFijaField.Equals(value) != true)) {
                    this.cuotaFijaField = value;
                    this.RaisePropertyChanged("cuotaFija");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal limInf {
            get {
                return this.limInfField;
            }
            set {
                if ((this.limInfField.Equals(value) != true)) {
                    this.limInfField = value;
                    this.RaisePropertyChanged("limInf");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal limSup {
            get {
                return this.limSupField;
            }
            set {
                if ((this.limSupField.Equals(value) != true)) {
                    this.limSupField = value;
                    this.RaisePropertyChanged("limSup");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal subsidio {
            get {
                return this.subsidioField;
            }
            set {
                if ((this.subsidioField.Equals(value) != true)) {
                    this.subsidioField = value;
                    this.RaisePropertyChanged("subsidio");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFAlumno.IWCFAlumnos")]
    public interface IWCFAlumnos {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFAlumnos/CalcularIMSS", ReplyAction="http://tempuri.org/IWCFAlumnos/CalcularIMSSResponse")]
        Negocio.WCFAlumno.AportacionesIMSS CalcularIMSS(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFAlumnos/CalcularIMSS", ReplyAction="http://tempuri.org/IWCFAlumnos/CalcularIMSSResponse")]
        System.Threading.Tasks.Task<Negocio.WCFAlumno.AportacionesIMSS> CalcularIMSSAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFAlumnos/CalcularItemISR", ReplyAction="http://tempuri.org/IWCFAlumnos/CalcularItemISRResponse")]
        Negocio.WCFAlumno.ItemTablaISR CalcularItemISR(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFAlumnos/CalcularItemISR", ReplyAction="http://tempuri.org/IWCFAlumnos/CalcularItemISRResponse")]
        System.Threading.Tasks.Task<Negocio.WCFAlumno.ItemTablaISR> CalcularItemISRAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWCFAlumnosChannel : Negocio.WCFAlumno.IWCFAlumnos, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WCFAlumnosClient : System.ServiceModel.ClientBase<Negocio.WCFAlumno.IWCFAlumnos>, Negocio.WCFAlumno.IWCFAlumnos {
        
        public WCFAlumnosClient() {
        }
        
        public WCFAlumnosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WCFAlumnosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFAlumnosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFAlumnosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Negocio.WCFAlumno.AportacionesIMSS CalcularIMSS(int id) {
            return base.Channel.CalcularIMSS(id);
        }
        
        public System.Threading.Tasks.Task<Negocio.WCFAlumno.AportacionesIMSS> CalcularIMSSAsync(int id) {
            return base.Channel.CalcularIMSSAsync(id);
        }
        
        public Negocio.WCFAlumno.ItemTablaISR CalcularItemISR(int id) {
            return base.Channel.CalcularItemISR(id);
        }
        
        public System.Threading.Tasks.Task<Negocio.WCFAlumno.ItemTablaISR> CalcularItemISRAsync(int id) {
            return base.Channel.CalcularItemISRAsync(id);
        }
    }
}