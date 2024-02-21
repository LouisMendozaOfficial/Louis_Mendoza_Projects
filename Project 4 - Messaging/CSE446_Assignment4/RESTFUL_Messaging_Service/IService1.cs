using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTFUL_Messaging_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract] [WebGet(UriTemplate = "sendMsg?senderID={senderID}&receiverID={receiverID}&time={time}&message={message}", 
            ResponseFormat = WebMessageFormat.Json)] void sendMsg(string senderID, string receiverID, string time, string message);

        [OperationContract] [WebGet(UriTemplate = "receiveMsg?receiverID={receiverID}&purge={purge}", 
            ResponseFormat = WebMessageFormat.Json)] string receiveMsg(string receiverID, string purge);

    }
}
