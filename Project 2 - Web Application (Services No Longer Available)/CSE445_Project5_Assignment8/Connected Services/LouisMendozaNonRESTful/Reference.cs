﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSE445_Project5_Assignment8.LouisMendozaNonRESTful {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LouisMendozaNonRESTful.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TopTenWords", ReplyAction="http://tempuri.org/IService1/TopTenWordsResponse")]
        string TopTenWords(string url);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TopTenWords", ReplyAction="http://tempuri.org/IService1/TopTenWordsResponse")]
        System.Threading.Tasks.Task<string> TopTenWordsAsync(string url);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AverageSentenceLength", ReplyAction="http://tempuri.org/IService1/AverageSentenceLengthResponse")]
        int AverageSentenceLength(string url);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AverageSentenceLength", ReplyAction="http://tempuri.org/IService1/AverageSentenceLengthResponse")]
        System.Threading.Tasks.Task<int> AverageSentenceLengthAsync(string url);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NumberOfUnimportantWords", ReplyAction="http://tempuri.org/IService1/NumberOfUnimportantWordsResponse")]
        int NumberOfUnimportantWords(string url);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NumberOfUnimportantWords", ReplyAction="http://tempuri.org/IService1/NumberOfUnimportantWordsResponse")]
        System.Threading.Tasks.Task<int> NumberOfUnimportantWordsAsync(string url);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/WordFilter", ReplyAction="http://tempuri.org/IService1/WordFilterResponse")]
        string WordFilter(string inputString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/WordFilter", ReplyAction="http://tempuri.org/IService1/WordFilterResponse")]
        System.Threading.Tasks.Task<string> WordFilterAsync(string inputString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NumberOfSentences", ReplyAction="http://tempuri.org/IService1/NumberOfSentencesResponse")]
        string NumberOfSentences(string url);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NumberOfSentences", ReplyAction="http://tempuri.org/IService1/NumberOfSentencesResponse")]
        System.Threading.Tasks.Task<string> NumberOfSentencesAsync(string url);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : CSE445_Project5_Assignment8.LouisMendozaNonRESTful.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<CSE445_Project5_Assignment8.LouisMendozaNonRESTful.IService1>, CSE445_Project5_Assignment8.LouisMendozaNonRESTful.IService1 {
        
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
        
        public string TopTenWords(string url) {
            return base.Channel.TopTenWords(url);
        }
        
        public System.Threading.Tasks.Task<string> TopTenWordsAsync(string url) {
            return base.Channel.TopTenWordsAsync(url);
        }
        
        public int AverageSentenceLength(string url) {
            return base.Channel.AverageSentenceLength(url);
        }
        
        public System.Threading.Tasks.Task<int> AverageSentenceLengthAsync(string url) {
            return base.Channel.AverageSentenceLengthAsync(url);
        }
        
        public int NumberOfUnimportantWords(string url) {
            return base.Channel.NumberOfUnimportantWords(url);
        }
        
        public System.Threading.Tasks.Task<int> NumberOfUnimportantWordsAsync(string url) {
            return base.Channel.NumberOfUnimportantWordsAsync(url);
        }
        
        public string WordFilter(string inputString) {
            return base.Channel.WordFilter(inputString);
        }
        
        public System.Threading.Tasks.Task<string> WordFilterAsync(string inputString) {
            return base.Channel.WordFilterAsync(inputString);
        }
        
        public string NumberOfSentences(string url) {
            return base.Channel.NumberOfSentences(url);
        }
        
        public System.Threading.Tasks.Task<string> NumberOfSentencesAsync(string url) {
            return base.Channel.NumberOfSentencesAsync(url);
        }
    }
}