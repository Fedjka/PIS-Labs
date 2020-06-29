﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceLib.Models
{
    using System.Runtime.Serialization;
    using System;


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Telephone", Namespace="http://schemas.datacontract.org/2004/07/ServiceLib.Models")]
    public partial class Telephone : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int idField;
        
        private int numberField;
        
        private string surnameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string surname
        {
            get
            {
                return this.surnameField;
            }
            set
            {
                this.surnameField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IMyService")]
public interface IMyService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetDict", ReplyAction="http://tempuri.org/IMyService/GetDictResponse")]
    ServiceLib.Models.Telephone[] GetDict();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetDict", ReplyAction="http://tempuri.org/IMyService/GetDictResponse")]
    System.Threading.Tasks.Task<ServiceLib.Models.Telephone[]> GetDictAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetAll", ReplyAction="http://tempuri.org/IMyService/GetAllResponse")]
    string GetAll();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetAll", ReplyAction="http://tempuri.org/IMyService/GetAllResponse")]
    System.Threading.Tasks.Task<string> GetAllAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/AddDict", ReplyAction="http://tempuri.org/IMyService/AddDictResponse")]
    string AddDict(string surname, int number);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/AddDict", ReplyAction="http://tempuri.org/IMyService/AddDictResponse")]
    System.Threading.Tasks.Task<string> AddDictAsync(string surname, int number);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/UpdDict", ReplyAction="http://tempuri.org/IMyService/UpdDictResponse")]
    string UpdDict(int id, string surname, int number);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/UpdDict", ReplyAction="http://tempuri.org/IMyService/UpdDictResponse")]
    System.Threading.Tasks.Task<string> UpdDictAsync(int id, string surname, int number);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/DelDict", ReplyAction="http://tempuri.org/IMyService/DelDictResponse")]
    string DelDict(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/DelDict", ReplyAction="http://tempuri.org/IMyService/DelDictResponse")]
    System.Threading.Tasks.Task<string> DelDictAsync(int id);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IMyServiceChannel : IMyService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class MyServiceClient : System.ServiceModel.ClientBase<IMyService>, IMyService
{
    
    public MyServiceClient()
    {
    }
    
    public MyServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public MyServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public MyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public MyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public ServiceLib.Models.Telephone[] GetDict()
    {
        return base.Channel.GetDict();
    }
    
    public System.Threading.Tasks.Task<ServiceLib.Models.Telephone[]> GetDictAsync()
    {
        return base.Channel.GetDictAsync();
    }
    
    public string GetAll()
    {
        return base.Channel.GetAll();
    }
    
    public System.Threading.Tasks.Task<string> GetAllAsync()
    {
        return base.Channel.GetAllAsync();
    }
    
    public string AddDict(string surname, int number)
    {
        return base.Channel.AddDict(surname, number);
    }
    
    public System.Threading.Tasks.Task<string> AddDictAsync(string surname, int number)
    {
        return base.Channel.AddDictAsync(surname, number);
    }
    
    public string UpdDict(int id, string surname, int number)
    {
        return base.Channel.UpdDict(id, surname, number);
    }
    
    public System.Threading.Tasks.Task<string> UpdDictAsync(int id, string surname, int number)
    {
        return base.Channel.UpdDictAsync(id, surname, number);
    }
    
    public string DelDict(int id)
    {
        return base.Channel.DelDict(id);
    }
    
    public System.Threading.Tasks.Task<string> DelDictAsync(int id)
    {
        return base.Channel.DelDictAsync(id);
    }
}