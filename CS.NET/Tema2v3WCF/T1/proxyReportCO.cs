﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17379
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseTablesClasses
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/DatabaseTablesClasses")]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string AddressField;
        
        private int IdField;
        
        private string NameField;
        
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
        public string Address
        {
            get
            {
                return this.AddressField;
            }
            set
            {
                this.AddressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Order", Namespace="http://schemas.datacontract.org/2004/07/DatabaseTablesClasses")]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int CustomerIdField;
        
        private System.DateTime DataField;
        
        private int OrderIdField;
        
        private string ProdusField;
        
        private int SerialField;
        
        private decimal ValoareField;
        
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
        public int CustomerId
        {
            get
            {
                return this.CustomerIdField;
            }
            set
            {
                this.CustomerIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Data
        {
            get
            {
                return this.DataField;
            }
            set
            {
                this.DataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OrderId
        {
            get
            {
                return this.OrderIdField;
            }
            set
            {
                this.OrderIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Produs
        {
            get
            {
                return this.ProdusField;
            }
            set
            {
                this.ProdusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Serial
        {
            get
            {
                return this.SerialField;
            }
            set
            {
                this.SerialField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Valoare
        {
            get
            {
                return this.ValoareField;
            }
            set
            {
                this.ValoareField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICustomer")]
public interface ICustomer
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/GetCustomerById", ReplyAction="http://tempuri.org/ICustomer/GetCustomerByIdResponse")]
    DatabaseTablesClasses.Customer GetCustomerById(int _id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/InsertCustomer", ReplyAction="http://tempuri.org/ICustomer/InsertCustomerResponse")]
    void InsertCustomer(string _name, string _address);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/UpdateCustomer", ReplyAction="http://tempuri.org/ICustomer/UpdateCustomerResponse")]
    void UpdateCustomer(DatabaseTablesClasses.Customer customer);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/DeleteCustomer", ReplyAction="http://tempuri.org/ICustomer/DeleteCustomerResponse")]
    void DeleteCustomer(DatabaseTablesClasses.Customer customer);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomer/GetAllOrders", ReplyAction="http://tempuri.org/ICustomer/GetAllOrdersResponse")]
    DatabaseTablesClasses.Order[] GetAllOrders(int _customerId);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ICustomerChannel : ICustomer, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class CustomerClient : System.ServiceModel.ClientBase<ICustomer>, ICustomer
{
    
    public CustomerClient()
    {
    }
    
    public CustomerClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public CustomerClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CustomerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CustomerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public DatabaseTablesClasses.Customer GetCustomerById(int _id)
    {
        return base.Channel.GetCustomerById(_id);
    }
    
    public void InsertCustomer(string _name, string _address)
    {
        base.Channel.InsertCustomer(_name, _address);
    }
    
    public void UpdateCustomer(DatabaseTablesClasses.Customer customer)
    {
        base.Channel.UpdateCustomer(customer);
    }
    
    public void DeleteCustomer(DatabaseTablesClasses.Customer customer)
    {
        base.Channel.DeleteCustomer(customer);
    }
    
    public DatabaseTablesClasses.Order[] GetAllOrders(int _customerId)
    {
        return base.Channel.GetAllOrders(_customerId);
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IOrder")]
public interface IOrder
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrder/GetOrder", ReplyAction="http://tempuri.org/IOrder/GetOrderResponse")]
    DatabaseTablesClasses.Order GetOrder(int _orderid);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrder/InsertOrder", ReplyAction="http://tempuri.org/IOrder/InsertOrderResponse")]
    void InsertOrder(int _customerid, System.DateTime dt, decimal _value);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrder/UpdateOrder", ReplyAction="http://tempuri.org/IOrder/UpdateOrderResponse")]
    void UpdateOrder(DatabaseTablesClasses.Order order);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrder/DeleteOrder", ReplyAction="http://tempuri.org/IOrder/DeleteOrderResponse")]
    void DeleteOrder(DatabaseTablesClasses.Order order);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IOrderChannel : IOrder, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class OrderClient : System.ServiceModel.ClientBase<IOrder>, IOrder
{
    
    public OrderClient()
    {
    }
    
    public OrderClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public OrderClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public OrderClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public OrderClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public DatabaseTablesClasses.Order GetOrder(int _orderid)
    {
        return base.Channel.GetOrder(_orderid);
    }
    
    public void InsertOrder(int _customerid, System.DateTime dt, decimal _value)
    {
        base.Channel.InsertOrder(_customerid, dt, _value);
    }
    
    public void UpdateOrder(DatabaseTablesClasses.Order order)
    {
        base.Channel.UpdateOrder(order);
    }
    
    public void DeleteOrder(DatabaseTablesClasses.Order order)
    {
        base.Channel.DeleteOrder(order);
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="ISubscribe", CallbackContract=typeof(ISubscribeCallback))]
public interface ISubscribe
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubscribe/Subscribe", ReplyAction="http://tempuri.org/ISubscribe/SubscribeResponse")]
    void Subscribe();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubscribe/Unsubscribe", ReplyAction="http://tempuri.org/ISubscribe/UnsubscribeResponse")]
    void Unsubscribe();
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ISubscribeCallback
{
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ISubscribe/OnInsertUpdateDelete")]
    void OnInsertUpdateDelete(string message);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ISubscribeChannel : ISubscribe, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class SubscribeClient : System.ServiceModel.DuplexClientBase<ISubscribe>, ISubscribe
{
    
    public SubscribeClient(System.ServiceModel.InstanceContext callbackInstance) : 
            base(callbackInstance)
    {
    }
    
    public SubscribeClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
            base(callbackInstance, endpointConfigurationName)
    {
    }
    
    public SubscribeClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
            base(callbackInstance, endpointConfigurationName, remoteAddress)
    {
    }
    
    public SubscribeClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(callbackInstance, endpointConfigurationName, remoteAddress)
    {
    }
    
    public SubscribeClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(callbackInstance, binding, remoteAddress)
    {
    }
    
    public void Subscribe()
    {
        base.Channel.Subscribe();
    }
    
    public void Unsubscribe()
    {
        base.Channel.Unsubscribe();
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IReport")]
public interface IReport
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReport/GetAllCustomer", ReplyAction="http://tempuri.org/IReport/GetAllCustomerResponse")]
    DatabaseTablesClasses.Customer[] GetAllCustomer();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReport/GetAllOrdersForCustomer", ReplyAction="http://tempuri.org/IReport/GetAllOrdersForCustomerResponse")]
    DatabaseTablesClasses.Order[] GetAllOrdersForCustomer(int _customerid);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IReportChannel : IReport, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class ReportClient : System.ServiceModel.ClientBase<IReport>, IReport
{
    
    public ReportClient()
    {
    }
    
    public ReportClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public ReportClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ReportClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ReportClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public DatabaseTablesClasses.Customer[] GetAllCustomer()
    {
        return base.Channel.GetAllCustomer();
    }
    
    public DatabaseTablesClasses.Order[] GetAllOrdersForCustomer(int _customerid)
    {
        return base.Channel.GetAllOrdersForCustomer(_customerid);
    }
}