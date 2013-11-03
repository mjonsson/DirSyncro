﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DirSyncroClient.SyncService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SyncService.ISyncService")]
    public interface ISyncService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISyncService/ServiceCommand", ReplyAction="http://tempuri.org/ISyncService/ServiceCommandResponse")]
        bool ServiceCommand(uint eventId, string objectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISyncService/ServiceCommand", ReplyAction="http://tempuri.org/ISyncService/ServiceCommandResponse")]
        System.Threading.Tasks.Task<bool> ServiceCommandAsync(uint eventId, string objectId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISyncServiceChannel : DirSyncroClient.SyncService.ISyncService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SyncServiceClient : System.ServiceModel.ClientBase<DirSyncroClient.SyncService.ISyncService>, DirSyncroClient.SyncService.ISyncService {
        
        public SyncServiceClient() {
        }
        
        public SyncServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SyncServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SyncServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SyncServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool ServiceCommand(uint eventId, string objectId) {
            return base.Channel.ServiceCommand(eventId, objectId);
        }
        
        public System.Threading.Tasks.Task<bool> ServiceCommandAsync(uint eventId, string objectId) {
            return base.Channel.ServiceCommandAsync(eventId, objectId);
        }
    }
}