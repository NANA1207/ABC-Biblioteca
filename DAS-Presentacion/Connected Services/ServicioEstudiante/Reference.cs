﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAS_Presentacion.ServicioEstudiante {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EstudianteEntidad", Namespace="http://schemas.datacontract.org/2004/07/DAS_Entidades")]
    [System.SerializableAttribute()]
    public partial class EstudianteEntidad : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string APE1_ESTField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string APE2_ESTField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> CANT_LIBROSField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CED_ESTField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CEL_REPRESENTANTE_ESTField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DIR_ESTField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EMAIL_ESTField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ESTADOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FEC_ING_SISTEMA_ESTField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FEC_NAC_ESTField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NOM1_ESTField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NOM2_ESTField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> NUM_MAT_ESTField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SEXO_ESTField;
        
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
        public string APE1_EST {
            get {
                return this.APE1_ESTField;
            }
            set {
                if ((object.ReferenceEquals(this.APE1_ESTField, value) != true)) {
                    this.APE1_ESTField = value;
                    this.RaisePropertyChanged("APE1_EST");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string APE2_EST {
            get {
                return this.APE2_ESTField;
            }
            set {
                if ((object.ReferenceEquals(this.APE2_ESTField, value) != true)) {
                    this.APE2_ESTField = value;
                    this.RaisePropertyChanged("APE2_EST");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> CANT_LIBROS {
            get {
                return this.CANT_LIBROSField;
            }
            set {
                if ((this.CANT_LIBROSField.Equals(value) != true)) {
                    this.CANT_LIBROSField = value;
                    this.RaisePropertyChanged("CANT_LIBROS");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CED_EST {
            get {
                return this.CED_ESTField;
            }
            set {
                if ((object.ReferenceEquals(this.CED_ESTField, value) != true)) {
                    this.CED_ESTField = value;
                    this.RaisePropertyChanged("CED_EST");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CEL_REPRESENTANTE_EST {
            get {
                return this.CEL_REPRESENTANTE_ESTField;
            }
            set {
                if ((object.ReferenceEquals(this.CEL_REPRESENTANTE_ESTField, value) != true)) {
                    this.CEL_REPRESENTANTE_ESTField = value;
                    this.RaisePropertyChanged("CEL_REPRESENTANTE_EST");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DIR_EST {
            get {
                return this.DIR_ESTField;
            }
            set {
                if ((object.ReferenceEquals(this.DIR_ESTField, value) != true)) {
                    this.DIR_ESTField = value;
                    this.RaisePropertyChanged("DIR_EST");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EMAIL_EST {
            get {
                return this.EMAIL_ESTField;
            }
            set {
                if ((object.ReferenceEquals(this.EMAIL_ESTField, value) != true)) {
                    this.EMAIL_ESTField = value;
                    this.RaisePropertyChanged("EMAIL_EST");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ESTADO {
            get {
                return this.ESTADOField;
            }
            set {
                if ((object.ReferenceEquals(this.ESTADOField, value) != true)) {
                    this.ESTADOField = value;
                    this.RaisePropertyChanged("ESTADO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FEC_ING_SISTEMA_EST {
            get {
                return this.FEC_ING_SISTEMA_ESTField;
            }
            set {
                if ((this.FEC_ING_SISTEMA_ESTField.Equals(value) != true)) {
                    this.FEC_ING_SISTEMA_ESTField = value;
                    this.RaisePropertyChanged("FEC_ING_SISTEMA_EST");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FEC_NAC_EST {
            get {
                return this.FEC_NAC_ESTField;
            }
            set {
                if ((this.FEC_NAC_ESTField.Equals(value) != true)) {
                    this.FEC_NAC_ESTField = value;
                    this.RaisePropertyChanged("FEC_NAC_EST");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NOM1_EST {
            get {
                return this.NOM1_ESTField;
            }
            set {
                if ((object.ReferenceEquals(this.NOM1_ESTField, value) != true)) {
                    this.NOM1_ESTField = value;
                    this.RaisePropertyChanged("NOM1_EST");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NOM2_EST {
            get {
                return this.NOM2_ESTField;
            }
            set {
                if ((object.ReferenceEquals(this.NOM2_ESTField, value) != true)) {
                    this.NOM2_ESTField = value;
                    this.RaisePropertyChanged("NOM2_EST");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> NUM_MAT_EST {
            get {
                return this.NUM_MAT_ESTField;
            }
            set {
                if ((this.NUM_MAT_ESTField.Equals(value) != true)) {
                    this.NUM_MAT_ESTField = value;
                    this.RaisePropertyChanged("NUM_MAT_EST");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SEXO_EST {
            get {
                return this.SEXO_ESTField;
            }
            set {
                if ((object.ReferenceEquals(this.SEXO_ESTField, value) != true)) {
                    this.SEXO_ESTField = value;
                    this.RaisePropertyChanged("SEXO_EST");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioEstudiante.IServicioEstudiante")]
    public interface IServicioEstudiante {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioEstudiante/add", ReplyAction="http://tempuri.org/IServicioEstudiante/addResponse")]
        DAS_Presentacion.ServicioEstudiante.EstudianteEntidad add(DAS_Presentacion.ServicioEstudiante.EstudianteEntidad obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioEstudiante/add", ReplyAction="http://tempuri.org/IServicioEstudiante/addResponse")]
        System.Threading.Tasks.Task<DAS_Presentacion.ServicioEstudiante.EstudianteEntidad> addAsync(DAS_Presentacion.ServicioEstudiante.EstudianteEntidad obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioEstudiante/edit", ReplyAction="http://tempuri.org/IServicioEstudiante/editResponse")]
        bool edit(DAS_Presentacion.ServicioEstudiante.EstudianteEntidad obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioEstudiante/edit", ReplyAction="http://tempuri.org/IServicioEstudiante/editResponse")]
        System.Threading.Tasks.Task<bool> editAsync(DAS_Presentacion.ServicioEstudiante.EstudianteEntidad obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioEstudiante/delete", ReplyAction="http://tempuri.org/IServicioEstudiante/deleteResponse")]
        bool delete(DAS_Presentacion.ServicioEstudiante.EstudianteEntidad obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioEstudiante/delete", ReplyAction="http://tempuri.org/IServicioEstudiante/deleteResponse")]
        System.Threading.Tasks.Task<bool> deleteAsync(DAS_Presentacion.ServicioEstudiante.EstudianteEntidad obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioEstudiante/ObtenerEstudianteID", ReplyAction="http://tempuri.org/IServicioEstudiante/ObtenerEstudianteIDResponse")]
        DAS_Presentacion.ServicioEstudiante.EstudianteEntidad ObtenerEstudianteID(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioEstudiante/ObtenerEstudianteID", ReplyAction="http://tempuri.org/IServicioEstudiante/ObtenerEstudianteIDResponse")]
        System.Threading.Tasks.Task<DAS_Presentacion.ServicioEstudiante.EstudianteEntidad> ObtenerEstudianteIDAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioEstudiante/buscar", ReplyAction="http://tempuri.org/IServicioEstudiante/buscarResponse")]
        DAS_Presentacion.ServicioEstudiante.EstudianteEntidad[] buscar(string busqueda, int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioEstudiante/buscar", ReplyAction="http://tempuri.org/IServicioEstudiante/buscarResponse")]
        System.Threading.Tasks.Task<DAS_Presentacion.ServicioEstudiante.EstudianteEntidad[]> buscarAsync(string busqueda, int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioEstudiante/existe", ReplyAction="http://tempuri.org/IServicioEstudiante/existeResponse")]
        bool existe(string cedula);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioEstudiante/existe", ReplyAction="http://tempuri.org/IServicioEstudiante/existeResponse")]
        System.Threading.Tasks.Task<bool> existeAsync(string cedula);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioEstudiante/updateState", ReplyAction="http://tempuri.org/IServicioEstudiante/updateStateResponse")]
        bool updateState(DAS_Presentacion.ServicioEstudiante.EstudianteEntidad estudiante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioEstudiante/updateState", ReplyAction="http://tempuri.org/IServicioEstudiante/updateStateResponse")]
        System.Threading.Tasks.Task<bool> updateStateAsync(DAS_Presentacion.ServicioEstudiante.EstudianteEntidad estudiante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioEstudiante/ObtenerEstudiantes", ReplyAction="http://tempuri.org/IServicioEstudiante/ObtenerEstudiantesResponse")]
        DAS_Presentacion.ServicioEstudiante.EstudianteEntidad[] ObtenerEstudiantes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioEstudiante/ObtenerEstudiantes", ReplyAction="http://tempuri.org/IServicioEstudiante/ObtenerEstudiantesResponse")]
        System.Threading.Tasks.Task<DAS_Presentacion.ServicioEstudiante.EstudianteEntidad[]> ObtenerEstudiantesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioEstudianteChannel : DAS_Presentacion.ServicioEstudiante.IServicioEstudiante, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioEstudianteClient : System.ServiceModel.ClientBase<DAS_Presentacion.ServicioEstudiante.IServicioEstudiante>, DAS_Presentacion.ServicioEstudiante.IServicioEstudiante {
        
        public ServicioEstudianteClient() {
        }
        
        public ServicioEstudianteClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioEstudianteClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioEstudianteClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioEstudianteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DAS_Presentacion.ServicioEstudiante.EstudianteEntidad add(DAS_Presentacion.ServicioEstudiante.EstudianteEntidad obj) {
            return base.Channel.add(obj);
        }
        
        public System.Threading.Tasks.Task<DAS_Presentacion.ServicioEstudiante.EstudianteEntidad> addAsync(DAS_Presentacion.ServicioEstudiante.EstudianteEntidad obj) {
            return base.Channel.addAsync(obj);
        }
        
        public bool edit(DAS_Presentacion.ServicioEstudiante.EstudianteEntidad obj) {
            return base.Channel.edit(obj);
        }
        
        public System.Threading.Tasks.Task<bool> editAsync(DAS_Presentacion.ServicioEstudiante.EstudianteEntidad obj) {
            return base.Channel.editAsync(obj);
        }
        
        public bool delete(DAS_Presentacion.ServicioEstudiante.EstudianteEntidad obj) {
            return base.Channel.delete(obj);
        }
        
        public System.Threading.Tasks.Task<bool> deleteAsync(DAS_Presentacion.ServicioEstudiante.EstudianteEntidad obj) {
            return base.Channel.deleteAsync(obj);
        }
        
        public DAS_Presentacion.ServicioEstudiante.EstudianteEntidad ObtenerEstudianteID(string id) {
            return base.Channel.ObtenerEstudianteID(id);
        }
        
        public System.Threading.Tasks.Task<DAS_Presentacion.ServicioEstudiante.EstudianteEntidad> ObtenerEstudianteIDAsync(string id) {
            return base.Channel.ObtenerEstudianteIDAsync(id);
        }
        
        public DAS_Presentacion.ServicioEstudiante.EstudianteEntidad[] buscar(string busqueda, int value) {
            return base.Channel.buscar(busqueda, value);
        }
        
        public System.Threading.Tasks.Task<DAS_Presentacion.ServicioEstudiante.EstudianteEntidad[]> buscarAsync(string busqueda, int value) {
            return base.Channel.buscarAsync(busqueda, value);
        }
        
        public bool existe(string cedula) {
            return base.Channel.existe(cedula);
        }
        
        public System.Threading.Tasks.Task<bool> existeAsync(string cedula) {
            return base.Channel.existeAsync(cedula);
        }
        
        public bool updateState(DAS_Presentacion.ServicioEstudiante.EstudianteEntidad estudiante) {
            return base.Channel.updateState(estudiante);
        }
        
        public System.Threading.Tasks.Task<bool> updateStateAsync(DAS_Presentacion.ServicioEstudiante.EstudianteEntidad estudiante) {
            return base.Channel.updateStateAsync(estudiante);
        }
        
        public DAS_Presentacion.ServicioEstudiante.EstudianteEntidad[] ObtenerEstudiantes() {
            return base.Channel.ObtenerEstudiantes();
        }
        
        public System.Threading.Tasks.Task<DAS_Presentacion.ServicioEstudiante.EstudianteEntidad[]> ObtenerEstudiantesAsync() {
            return base.Channel.ObtenerEstudiantesAsync();
        }
    }
}
