 public partial class CAdxWebServiceXmlCCClient : System.ServiceModel.ClientBase<ServiceReference1.CAdxWebServiceXmlCC>, ServiceReference1.CAdxWebServiceXmlCC
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CAdxWebServiceXmlCCClient() : 
                base(CAdxWebServiceXmlCCClient.GetDefaultBinding(), CAdxWebServiceXmlCCClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.CAdxWebServiceXmlCC.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CAdxWebServiceXmlCCClient(EndpointConfiguration endpointConfiguration) : 
                base(CAdxWebServiceXmlCCClient.GetBindingForEndpoint(endpointConfiguration), CAdxWebServiceXmlCCClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CAdxWebServiceXmlCCClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CAdxWebServiceXmlCCClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CAdxWebServiceXmlCCClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CAdxWebServiceXmlCCClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CAdxWebServiceXmlCCClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public ServiceReference1.CAdxResultXml run(ServiceReference1.CAdxCallContext callContext, string publicName, string inputXml)
        {
            return base.Channel.run(callContext, publicName, inputXml);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.CAdxResultXml> runAsync(ServiceReference1.CAdxCallContext callContext, string publicName, string inputXml)
        {
            return base.Channel.runAsync(callContext, publicName, inputXml);
        }
        
        public ServiceReference1.CAdxResultXml save(ServiceReference1.CAdxCallContext callContext, string publicName, string objectXml)
        {
            return base.Channel.save(callContext, publicName, objectXml);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.CAdxResultXml> saveAsync(ServiceReference1.CAdxCallContext callContext, string publicName, string objectXml)
        {
            return base.Channel.saveAsync(callContext, publicName, objectXml);
        }
        
        public ServiceReference1.CAdxResultXml delete(ServiceReference1.CAdxCallContext callContext, string publicName, ServiceReference1.CAdxParamKeyValue[] objectKeys)
        {
            return base.Channel.delete(callContext, publicName, objectKeys);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.CAdxResultXml> deleteAsync(ServiceReference1.CAdxCallContext callContext, string publicName, ServiceReference1.CAdxParamKeyValue[] objectKeys)
        {
            return base.Channel.deleteAsync(callContext, publicName, objectKeys);
        }
        
        public ServiceReference1.CAdxResultXml read(ServiceReference1.CAdxCallContext callContext, string publicName, ServiceReference1.CAdxParamKeyValue[] objectKeys)
        {
            return base.Channel.read(callContext, publicName, objectKeys);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.CAdxResultXml> readAsync(ServiceReference1.CAdxCallContext callContext, string publicName, ServiceReference1.CAdxParamKeyValue[] objectKeys)
        {
            return base.Channel.readAsync(callContext, publicName, objectKeys);
        }
        
        public ServiceReference1.CAdxResultXml query(ServiceReference1.CAdxCallContext callContext, string publicName, ServiceReference1.CAdxParamKeyValue[] objectKeys, int listSize)
        {
            return base.Channel.query(callContext, publicName, objectKeys, listSize);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.CAdxResultXml> queryAsync(ServiceReference1.CAdxCallContext callContext, string publicName, ServiceReference1.CAdxParamKeyValue[] objectKeys, int listSize)
        {
            return base.Channel.queryAsync(callContext, publicName, objectKeys, listSize);
        }
        
        public ServiceReference1.CAdxResultXml getDescription(ServiceReference1.CAdxCallContext callContext, string publicName)
        {
            return base.Channel.getDescription(callContext, publicName);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.CAdxResultXml> getDescriptionAsync(ServiceReference1.CAdxCallContext callContext, string publicName)
        {
            return base.Channel.getDescriptionAsync(callContext, publicName);
        }
        
        public ServiceReference1.CAdxResultXml modify(ServiceReference1.CAdxCallContext callContext, string publicName, ServiceReference1.CAdxParamKeyValue[] objectKeys, string objectXml)
        {
            return base.Channel.modify(callContext, publicName, objectKeys, objectXml);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.CAdxResultXml> modifyAsync(ServiceReference1.CAdxCallContext callContext, string publicName, ServiceReference1.CAdxParamKeyValue[] objectKeys, string objectXml)
        {
            return base.Channel.modifyAsync(callContext, publicName, objectKeys, objectXml);
        }
        
        public ServiceReference1.CAdxResultXml actionObject(ServiceReference1.CAdxCallContext callContext, string publicName, string actionCode, string objectXml)
        {
            return base.Channel.actionObject(callContext, publicName, actionCode, objectXml);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.CAdxResultXml> actionObjectAsync(ServiceReference1.CAdxCallContext callContext, string publicName, string actionCode, string objectXml)
        {
            return base.Channel.actionObjectAsync(callContext, publicName, actionCode, objectXml);
        }
        
        public ServiceReference1.CAdxResultXml actionObjectKeys(ServiceReference1.CAdxCallContext callContext, string publicName, string actionCode, ServiceReference1.CAdxParamKeyValue[] objectKeys)
        {
            return base.Channel.actionObjectKeys(callContext, publicName, actionCode, objectKeys);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.CAdxResultXml> actionObjectKeysAsync(ServiceReference1.CAdxCallContext callContext, string publicName, string actionCode, ServiceReference1.CAdxParamKeyValue[] objectKeys)
        {
            return base.Channel.actionObjectKeysAsync(callContext, publicName, actionCode, objectKeys);
        }
        
        public ServiceReference1.CAdxResultXml getDataXmlSchema(ServiceReference1.CAdxCallContext callContext, string publicName)
        {
            return base.Channel.getDataXmlSchema(callContext, publicName);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.CAdxResultXml> getDataXmlSchemaAsync(ServiceReference1.CAdxCallContext callContext, string publicName)
        {
            return base.Channel.getDataXmlSchemaAsync(callContext, publicName);
        }
        
        public ServiceReference1.CAdxResultXml insertLines(ServiceReference1.CAdxCallContext callContext, string publicName, ServiceReference1.CAdxParamKeyValue[] objectKeys, string blocKey, string lineKey, string lineXml)
        {
            return base.Channel.insertLines(callContext, publicName, objectKeys, blocKey, lineKey, lineXml);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.CAdxResultXml> insertLinesAsync(ServiceReference1.CAdxCallContext callContext, string publicName, ServiceReference1.CAdxParamKeyValue[] objectKeys, string blocKey, string lineKey, string lineXml)
        {
            return base.Channel.insertLinesAsync(callContext, publicName, objectKeys, blocKey, lineKey, lineXml);
        }
        
        public ServiceReference1.CAdxResultXml deleteLines(ServiceReference1.CAdxCallContext callContext, string publicName, ServiceReference1.CAdxParamKeyValue[] objectKeys, string blocKey, string[] lineKeys)
        {
            return base.Channel.deleteLines(callContext, publicName, objectKeys, blocKey, lineKeys);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.CAdxResultXml> deleteLinesAsync(ServiceReference1.CAdxCallContext callContext, string publicName, ServiceReference1.CAdxParamKeyValue[] objectKeys, string blocKey, string[] lineKeys)
        {
            return base.Channel.deleteLinesAsync(callContext, publicName, objectKeys, blocKey, lineKeys);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.CAdxWebServiceXmlCC))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.CAdxWebServiceXmlCC))
            {
                return new System.ServiceModel.EndpointAddress("http://bgr-idc-sageapp:8124/soap-generic/syracuse/collaboration/syracuse/CAdxWebS" +
                        "erviceXmlCC");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return CAdxWebServiceXmlCCClient.GetBindingForEndpoint(EndpointConfiguration.CAdxWebServiceXmlCC);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return CAdxWebServiceXmlCCClient.GetEndpointAddress(EndpointConfiguration.CAdxWebServiceXmlCC);
        }
        
        public enum EndpointConfiguration
        {
            
            CAdxWebServiceXmlCC,
        }
    }