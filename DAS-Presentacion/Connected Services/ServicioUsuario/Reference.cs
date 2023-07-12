﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAS_Presentacion.ServicioUsuario {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioUsuario.IServicioUsuario")]
    public interface IServicioUsuario {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuario/add", ReplyAction="http://tempuri.org/IServicioUsuario/addResponse")]
        DAS_Entidades.UsuarioEntidad add(DAS_Entidades.UsuarioEntidad obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuario/add", ReplyAction="http://tempuri.org/IServicioUsuario/addResponse")]
        System.Threading.Tasks.Task<DAS_Entidades.UsuarioEntidad> addAsync(DAS_Entidades.UsuarioEntidad obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuario/edit", ReplyAction="http://tempuri.org/IServicioUsuario/editResponse")]
        bool edit(DAS_Entidades.UsuarioEntidad obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuario/edit", ReplyAction="http://tempuri.org/IServicioUsuario/editResponse")]
        System.Threading.Tasks.Task<bool> editAsync(DAS_Entidades.UsuarioEntidad obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuario/delete", ReplyAction="http://tempuri.org/IServicioUsuario/deleteResponse")]
        bool delete(DAS_Entidades.UsuarioEntidad obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuario/delete", ReplyAction="http://tempuri.org/IServicioUsuario/deleteResponse")]
        System.Threading.Tasks.Task<bool> deleteAsync(DAS_Entidades.UsuarioEntidad obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuario/obtenerUsuarioID", ReplyAction="http://tempuri.org/IServicioUsuario/obtenerUsuarioIDResponse")]
        DAS_Entidades.UsuarioEntidad obtenerUsuarioID(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuario/obtenerUsuarioID", ReplyAction="http://tempuri.org/IServicioUsuario/obtenerUsuarioIDResponse")]
        System.Threading.Tasks.Task<DAS_Entidades.UsuarioEntidad> obtenerUsuarioIDAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuario/buscar", ReplyAction="http://tempuri.org/IServicioUsuario/buscarResponse")]
        DAS_Entidades.UsuarioEntidad[] buscar(string busqueda, int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuario/buscar", ReplyAction="http://tempuri.org/IServicioUsuario/buscarResponse")]
        System.Threading.Tasks.Task<DAS_Entidades.UsuarioEntidad[]> buscarAsync(string busqueda, int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuario/login", ReplyAction="http://tempuri.org/IServicioUsuario/loginResponse")]
        DAS_Entidades.UsuarioEntidad login(string user, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuario/login", ReplyAction="http://tempuri.org/IServicioUsuario/loginResponse")]
        System.Threading.Tasks.Task<DAS_Entidades.UsuarioEntidad> loginAsync(string user, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuario/obtenerUsuarios", ReplyAction="http://tempuri.org/IServicioUsuario/obtenerUsuariosResponse")]
        DAS_Entidades.UsuarioEntidad[] obtenerUsuarios();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuario/obtenerUsuarios", ReplyAction="http://tempuri.org/IServicioUsuario/obtenerUsuariosResponse")]
        System.Threading.Tasks.Task<DAS_Entidades.UsuarioEntidad[]> obtenerUsuariosAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioUsuarioChannel : DAS_Presentacion.ServicioUsuario.IServicioUsuario, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioUsuarioClient : System.ServiceModel.ClientBase<DAS_Presentacion.ServicioUsuario.IServicioUsuario>, DAS_Presentacion.ServicioUsuario.IServicioUsuario {
        
        public ServicioUsuarioClient() {
        }
        
        public ServicioUsuarioClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioUsuarioClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioUsuarioClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioUsuarioClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DAS_Entidades.UsuarioEntidad add(DAS_Entidades.UsuarioEntidad obj) {
            return base.Channel.add(obj);
        }
        
        public System.Threading.Tasks.Task<DAS_Entidades.UsuarioEntidad> addAsync(DAS_Entidades.UsuarioEntidad obj) {
            return base.Channel.addAsync(obj);
        }
        
        public bool edit(DAS_Entidades.UsuarioEntidad obj) {
            return base.Channel.edit(obj);
        }
        
        public System.Threading.Tasks.Task<bool> editAsync(DAS_Entidades.UsuarioEntidad obj) {
            return base.Channel.editAsync(obj);
        }
        
        public bool delete(DAS_Entidades.UsuarioEntidad obj) {
            return base.Channel.delete(obj);
        }
        
        public System.Threading.Tasks.Task<bool> deleteAsync(DAS_Entidades.UsuarioEntidad obj) {
            return base.Channel.deleteAsync(obj);
        }
        
        public DAS_Entidades.UsuarioEntidad obtenerUsuarioID(string id) {
            return base.Channel.obtenerUsuarioID(id);
        }
        
        public System.Threading.Tasks.Task<DAS_Entidades.UsuarioEntidad> obtenerUsuarioIDAsync(string id) {
            return base.Channel.obtenerUsuarioIDAsync(id);
        }
        
        public DAS_Entidades.UsuarioEntidad[] buscar(string busqueda, int value) {
            return base.Channel.buscar(busqueda, value);
        }
        
        public System.Threading.Tasks.Task<DAS_Entidades.UsuarioEntidad[]> buscarAsync(string busqueda, int value) {
            return base.Channel.buscarAsync(busqueda, value);
        }
        
        public DAS_Entidades.UsuarioEntidad login(string user, string pass) {
            return base.Channel.login(user, pass);
        }
        
        public System.Threading.Tasks.Task<DAS_Entidades.UsuarioEntidad> loginAsync(string user, string pass) {
            return base.Channel.loginAsync(user, pass);
        }
        
        public DAS_Entidades.UsuarioEntidad[] obtenerUsuarios() {
            return base.Channel.obtenerUsuarios();
        }
        
        public System.Threading.Tasks.Task<DAS_Entidades.UsuarioEntidad[]> obtenerUsuariosAsync() {
            return base.Channel.obtenerUsuariosAsync();
        }
    }
}
