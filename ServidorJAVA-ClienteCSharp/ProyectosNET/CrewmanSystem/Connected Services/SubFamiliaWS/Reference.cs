﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrewmanSystem.SubFamiliaWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.CrewmanSystem.pucp.edu.pe/", ConfigurationName="SubFamiliaWS.SubFamiliaWS")]
    public interface SubFamiliaWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.CrewmanSystem.pucp.edu.pe/SubFamiliaWS/insertarSubFamiliaRequest", ReplyAction="http://services.CrewmanSystem.pucp.edu.pe/SubFamiliaWS/insertarSubFamiliaResponse" +
            "")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        CrewmanSystem.SubFamiliaWS.insertarSubFamiliaResponse insertarSubFamilia(CrewmanSystem.SubFamiliaWS.insertarSubFamiliaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.CrewmanSystem.pucp.edu.pe/SubFamiliaWS/insertarSubFamiliaRequest", ReplyAction="http://services.CrewmanSystem.pucp.edu.pe/SubFamiliaWS/insertarSubFamiliaResponse" +
            "")]
        System.Threading.Tasks.Task<CrewmanSystem.SubFamiliaWS.insertarSubFamiliaResponse> insertarSubFamiliaAsync(CrewmanSystem.SubFamiliaWS.insertarSubFamiliaRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.CrewmanSystem.pucp.edu.pe/SubFamiliaWS/actualizarSubFamiliaReques" +
            "t", ReplyAction="http://services.CrewmanSystem.pucp.edu.pe/SubFamiliaWS/actualizarSubFamiliaRespon" +
            "se")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        CrewmanSystem.SubFamiliaWS.actualizarSubFamiliaResponse actualizarSubFamilia(CrewmanSystem.SubFamiliaWS.actualizarSubFamiliaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.CrewmanSystem.pucp.edu.pe/SubFamiliaWS/actualizarSubFamiliaReques" +
            "t", ReplyAction="http://services.CrewmanSystem.pucp.edu.pe/SubFamiliaWS/actualizarSubFamiliaRespon" +
            "se")]
        System.Threading.Tasks.Task<CrewmanSystem.SubFamiliaWS.actualizarSubFamiliaResponse> actualizarSubFamiliaAsync(CrewmanSystem.SubFamiliaWS.actualizarSubFamiliaRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.CrewmanSystem.pucp.edu.pe/SubFamiliaWS/eliminarSubFamiliaRequest", ReplyAction="http://services.CrewmanSystem.pucp.edu.pe/SubFamiliaWS/eliminarSubFamiliaResponse" +
            "")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        CrewmanSystem.SubFamiliaWS.eliminarSubFamiliaResponse eliminarSubFamilia(CrewmanSystem.SubFamiliaWS.eliminarSubFamiliaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.CrewmanSystem.pucp.edu.pe/SubFamiliaWS/eliminarSubFamiliaRequest", ReplyAction="http://services.CrewmanSystem.pucp.edu.pe/SubFamiliaWS/eliminarSubFamiliaResponse" +
            "")]
        System.Threading.Tasks.Task<CrewmanSystem.SubFamiliaWS.eliminarSubFamiliaResponse> eliminarSubFamiliaAsync(CrewmanSystem.SubFamiliaWS.eliminarSubFamiliaRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.CrewmanSystem.pucp.edu.pe/SubFamiliaWS/listarSubFamiliasRequest", ReplyAction="http://services.CrewmanSystem.pucp.edu.pe/SubFamiliaWS/listarSubFamiliasResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        CrewmanSystem.SubFamiliaWS.listarSubFamiliasResponse listarSubFamilias(CrewmanSystem.SubFamiliaWS.listarSubFamiliasRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.CrewmanSystem.pucp.edu.pe/SubFamiliaWS/listarSubFamiliasRequest", ReplyAction="http://services.CrewmanSystem.pucp.edu.pe/SubFamiliaWS/listarSubFamiliasResponse")]
        System.Threading.Tasks.Task<CrewmanSystem.SubFamiliaWS.listarSubFamiliasResponse> listarSubFamiliasAsync(CrewmanSystem.SubFamiliaWS.listarSubFamiliasRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.CrewmanSystem.pucp.edu.pe/")]
    public partial class subFamilia : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool activoField;
        
        private string descripcionSubFamiliaField;
        
        private familia familiaField;
        
        private int idSubFamiliaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool activo {
            get {
                return this.activoField;
            }
            set {
                this.activoField = value;
                this.RaisePropertyChanged("activo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string descripcionSubFamilia {
            get {
                return this.descripcionSubFamiliaField;
            }
            set {
                this.descripcionSubFamiliaField = value;
                this.RaisePropertyChanged("descripcionSubFamilia");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public familia familia {
            get {
                return this.familiaField;
            }
            set {
                this.familiaField = value;
                this.RaisePropertyChanged("familia");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int idSubFamilia {
            get {
                return this.idSubFamiliaField;
            }
            set {
                this.idSubFamiliaField = value;
                this.RaisePropertyChanged("idSubFamilia");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.CrewmanSystem.pucp.edu.pe/")]
    public partial class familia : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool activoField;
        
        private string descripcionField;
        
        private int idFamiliaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool activo {
            get {
                return this.activoField;
            }
            set {
                this.activoField = value;
                this.RaisePropertyChanged("activo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
                this.RaisePropertyChanged("descripcion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int idFamilia {
            get {
                return this.idFamiliaField;
            }
            set {
                this.idFamiliaField = value;
                this.RaisePropertyChanged("idFamilia");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarSubFamilia", WrapperNamespace="http://services.CrewmanSystem.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarSubFamiliaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.CrewmanSystem.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CrewmanSystem.SubFamiliaWS.subFamilia subFamilia;
        
        public insertarSubFamiliaRequest() {
        }
        
        public insertarSubFamiliaRequest(CrewmanSystem.SubFamiliaWS.subFamilia subFamilia) {
            this.subFamilia = subFamilia;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarSubFamiliaResponse", WrapperNamespace="http://services.CrewmanSystem.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarSubFamiliaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.CrewmanSystem.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public insertarSubFamiliaResponse() {
        }
        
        public insertarSubFamiliaResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="actualizarSubFamilia", WrapperNamespace="http://services.CrewmanSystem.pucp.edu.pe/", IsWrapped=true)]
    public partial class actualizarSubFamiliaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.CrewmanSystem.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CrewmanSystem.SubFamiliaWS.subFamilia subFamilia;
        
        public actualizarSubFamiliaRequest() {
        }
        
        public actualizarSubFamiliaRequest(CrewmanSystem.SubFamiliaWS.subFamilia subFamilia) {
            this.subFamilia = subFamilia;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="actualizarSubFamiliaResponse", WrapperNamespace="http://services.CrewmanSystem.pucp.edu.pe/", IsWrapped=true)]
    public partial class actualizarSubFamiliaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.CrewmanSystem.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public actualizarSubFamiliaResponse() {
        }
        
        public actualizarSubFamiliaResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarSubFamilia", WrapperNamespace="http://services.CrewmanSystem.pucp.edu.pe/", IsWrapped=true)]
    public partial class eliminarSubFamiliaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.CrewmanSystem.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int idSubFamilia;
        
        public eliminarSubFamiliaRequest() {
        }
        
        public eliminarSubFamiliaRequest(int idSubFamilia) {
            this.idSubFamilia = idSubFamilia;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarSubFamiliaResponse", WrapperNamespace="http://services.CrewmanSystem.pucp.edu.pe/", IsWrapped=true)]
    public partial class eliminarSubFamiliaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.CrewmanSystem.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public eliminarSubFamiliaResponse() {
        }
        
        public eliminarSubFamiliaResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarSubFamilias", WrapperNamespace="http://services.CrewmanSystem.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarSubFamiliasRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.CrewmanSystem.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string familia;
        
        public listarSubFamiliasRequest() {
        }
        
        public listarSubFamiliasRequest(string familia) {
            this.familia = familia;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarSubFamiliasResponse", WrapperNamespace="http://services.CrewmanSystem.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarSubFamiliasResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.CrewmanSystem.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CrewmanSystem.SubFamiliaWS.subFamilia[] @return;
        
        public listarSubFamiliasResponse() {
        }
        
        public listarSubFamiliasResponse(CrewmanSystem.SubFamiliaWS.subFamilia[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SubFamiliaWSChannel : CrewmanSystem.SubFamiliaWS.SubFamiliaWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SubFamiliaWSClient : System.ServiceModel.ClientBase<CrewmanSystem.SubFamiliaWS.SubFamiliaWS>, CrewmanSystem.SubFamiliaWS.SubFamiliaWS {
        
        public SubFamiliaWSClient() {
        }
        
        public SubFamiliaWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SubFamiliaWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SubFamiliaWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SubFamiliaWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CrewmanSystem.SubFamiliaWS.insertarSubFamiliaResponse CrewmanSystem.SubFamiliaWS.SubFamiliaWS.insertarSubFamilia(CrewmanSystem.SubFamiliaWS.insertarSubFamiliaRequest request) {
            return base.Channel.insertarSubFamilia(request);
        }
        
        public int insertarSubFamilia(CrewmanSystem.SubFamiliaWS.subFamilia subFamilia) {
            CrewmanSystem.SubFamiliaWS.insertarSubFamiliaRequest inValue = new CrewmanSystem.SubFamiliaWS.insertarSubFamiliaRequest();
            inValue.subFamilia = subFamilia;
            CrewmanSystem.SubFamiliaWS.insertarSubFamiliaResponse retVal = ((CrewmanSystem.SubFamiliaWS.SubFamiliaWS)(this)).insertarSubFamilia(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CrewmanSystem.SubFamiliaWS.insertarSubFamiliaResponse> CrewmanSystem.SubFamiliaWS.SubFamiliaWS.insertarSubFamiliaAsync(CrewmanSystem.SubFamiliaWS.insertarSubFamiliaRequest request) {
            return base.Channel.insertarSubFamiliaAsync(request);
        }
        
        public System.Threading.Tasks.Task<CrewmanSystem.SubFamiliaWS.insertarSubFamiliaResponse> insertarSubFamiliaAsync(CrewmanSystem.SubFamiliaWS.subFamilia subFamilia) {
            CrewmanSystem.SubFamiliaWS.insertarSubFamiliaRequest inValue = new CrewmanSystem.SubFamiliaWS.insertarSubFamiliaRequest();
            inValue.subFamilia = subFamilia;
            return ((CrewmanSystem.SubFamiliaWS.SubFamiliaWS)(this)).insertarSubFamiliaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CrewmanSystem.SubFamiliaWS.actualizarSubFamiliaResponse CrewmanSystem.SubFamiliaWS.SubFamiliaWS.actualizarSubFamilia(CrewmanSystem.SubFamiliaWS.actualizarSubFamiliaRequest request) {
            return base.Channel.actualizarSubFamilia(request);
        }
        
        public int actualizarSubFamilia(CrewmanSystem.SubFamiliaWS.subFamilia subFamilia) {
            CrewmanSystem.SubFamiliaWS.actualizarSubFamiliaRequest inValue = new CrewmanSystem.SubFamiliaWS.actualizarSubFamiliaRequest();
            inValue.subFamilia = subFamilia;
            CrewmanSystem.SubFamiliaWS.actualizarSubFamiliaResponse retVal = ((CrewmanSystem.SubFamiliaWS.SubFamiliaWS)(this)).actualizarSubFamilia(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CrewmanSystem.SubFamiliaWS.actualizarSubFamiliaResponse> CrewmanSystem.SubFamiliaWS.SubFamiliaWS.actualizarSubFamiliaAsync(CrewmanSystem.SubFamiliaWS.actualizarSubFamiliaRequest request) {
            return base.Channel.actualizarSubFamiliaAsync(request);
        }
        
        public System.Threading.Tasks.Task<CrewmanSystem.SubFamiliaWS.actualizarSubFamiliaResponse> actualizarSubFamiliaAsync(CrewmanSystem.SubFamiliaWS.subFamilia subFamilia) {
            CrewmanSystem.SubFamiliaWS.actualizarSubFamiliaRequest inValue = new CrewmanSystem.SubFamiliaWS.actualizarSubFamiliaRequest();
            inValue.subFamilia = subFamilia;
            return ((CrewmanSystem.SubFamiliaWS.SubFamiliaWS)(this)).actualizarSubFamiliaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CrewmanSystem.SubFamiliaWS.eliminarSubFamiliaResponse CrewmanSystem.SubFamiliaWS.SubFamiliaWS.eliminarSubFamilia(CrewmanSystem.SubFamiliaWS.eliminarSubFamiliaRequest request) {
            return base.Channel.eliminarSubFamilia(request);
        }
        
        public int eliminarSubFamilia(int idSubFamilia) {
            CrewmanSystem.SubFamiliaWS.eliminarSubFamiliaRequest inValue = new CrewmanSystem.SubFamiliaWS.eliminarSubFamiliaRequest();
            inValue.idSubFamilia = idSubFamilia;
            CrewmanSystem.SubFamiliaWS.eliminarSubFamiliaResponse retVal = ((CrewmanSystem.SubFamiliaWS.SubFamiliaWS)(this)).eliminarSubFamilia(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CrewmanSystem.SubFamiliaWS.eliminarSubFamiliaResponse> CrewmanSystem.SubFamiliaWS.SubFamiliaWS.eliminarSubFamiliaAsync(CrewmanSystem.SubFamiliaWS.eliminarSubFamiliaRequest request) {
            return base.Channel.eliminarSubFamiliaAsync(request);
        }
        
        public System.Threading.Tasks.Task<CrewmanSystem.SubFamiliaWS.eliminarSubFamiliaResponse> eliminarSubFamiliaAsync(int idSubFamilia) {
            CrewmanSystem.SubFamiliaWS.eliminarSubFamiliaRequest inValue = new CrewmanSystem.SubFamiliaWS.eliminarSubFamiliaRequest();
            inValue.idSubFamilia = idSubFamilia;
            return ((CrewmanSystem.SubFamiliaWS.SubFamiliaWS)(this)).eliminarSubFamiliaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CrewmanSystem.SubFamiliaWS.listarSubFamiliasResponse CrewmanSystem.SubFamiliaWS.SubFamiliaWS.listarSubFamilias(CrewmanSystem.SubFamiliaWS.listarSubFamiliasRequest request) {
            return base.Channel.listarSubFamilias(request);
        }
        
        public CrewmanSystem.SubFamiliaWS.subFamilia[] listarSubFamilias(string familia) {
            CrewmanSystem.SubFamiliaWS.listarSubFamiliasRequest inValue = new CrewmanSystem.SubFamiliaWS.listarSubFamiliasRequest();
            inValue.familia = familia;
            CrewmanSystem.SubFamiliaWS.listarSubFamiliasResponse retVal = ((CrewmanSystem.SubFamiliaWS.SubFamiliaWS)(this)).listarSubFamilias(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CrewmanSystem.SubFamiliaWS.listarSubFamiliasResponse> CrewmanSystem.SubFamiliaWS.SubFamiliaWS.listarSubFamiliasAsync(CrewmanSystem.SubFamiliaWS.listarSubFamiliasRequest request) {
            return base.Channel.listarSubFamiliasAsync(request);
        }
        
        public System.Threading.Tasks.Task<CrewmanSystem.SubFamiliaWS.listarSubFamiliasResponse> listarSubFamiliasAsync(string familia) {
            CrewmanSystem.SubFamiliaWS.listarSubFamiliasRequest inValue = new CrewmanSystem.SubFamiliaWS.listarSubFamiliasRequest();
            inValue.familia = familia;
            return ((CrewmanSystem.SubFamiliaWS.SubFamiliaWS)(this)).listarSubFamiliasAsync(inValue);
        }
    }
}
