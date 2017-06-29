﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceConsumer.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ICalc")]
    public interface ICalc {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/AddNumbers", ReplyAction="http://tempuri.org/ICalc/AddNumbersResponse")]
        double AddNumbers(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/AddNumbers", ReplyAction="http://tempuri.org/ICalc/AddNumbersResponse")]
        System.Threading.Tasks.Task<double> AddNumbersAsync(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/SubstractNumbers", ReplyAction="http://tempuri.org/ICalc/SubstractNumbersResponse")]
        double SubstractNumbers(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/SubstractNumbers", ReplyAction="http://tempuri.org/ICalc/SubstractNumbersResponse")]
        System.Threading.Tasks.Task<double> SubstractNumbersAsync(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/MultiplyNumbers", ReplyAction="http://tempuri.org/ICalc/MultiplyNumbersResponse")]
        double MultiplyNumbers(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/MultiplyNumbers", ReplyAction="http://tempuri.org/ICalc/MultiplyNumbersResponse")]
        System.Threading.Tasks.Task<double> MultiplyNumbersAsync(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/DivisionNumbers", ReplyAction="http://tempuri.org/ICalc/DivisionNumbersResponse")]
        double DivisionNumbers(double number1, double number2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/DivisionNumbers", ReplyAction="http://tempuri.org/ICalc/DivisionNumbersResponse")]
        System.Threading.Tasks.Task<double> DivisionNumbersAsync(double number1, double number2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalcChannel : ServiceConsumer.ServiceReference1.ICalc, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalcClient : System.ServiceModel.ClientBase<ServiceConsumer.ServiceReference1.ICalc>, ServiceConsumer.ServiceReference1.ICalc {
        
        public CalcClient() {
        }
        
        public CalcClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalcClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double AddNumbers(double number1, double number2) {
            return base.Channel.AddNumbers(number1, number2);
        }
        
        public System.Threading.Tasks.Task<double> AddNumbersAsync(double number1, double number2) {
            return base.Channel.AddNumbersAsync(number1, number2);
        }
        
        public double SubstractNumbers(double number1, double number2) {
            return base.Channel.SubstractNumbers(number1, number2);
        }
        
        public System.Threading.Tasks.Task<double> SubstractNumbersAsync(double number1, double number2) {
            return base.Channel.SubstractNumbersAsync(number1, number2);
        }
        
        public double MultiplyNumbers(double number1, double number2) {
            return base.Channel.MultiplyNumbers(number1, number2);
        }
        
        public System.Threading.Tasks.Task<double> MultiplyNumbersAsync(double number1, double number2) {
            return base.Channel.MultiplyNumbersAsync(number1, number2);
        }
        
        public double DivisionNumbers(double number1, double number2) {
            return base.Channel.DivisionNumbers(number1, number2);
        }
        
        public System.Threading.Tasks.Task<double> DivisionNumbersAsync(double number1, double number2) {
            return base.Channel.DivisionNumbersAsync(number1, number2);
        }
    }
}
