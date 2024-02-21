using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.IO;
using System.Web;
using System.Xml;
using System.Data;
using System.Xml.Schema;
using System.Xml.Linq;

namespace RESTFUL_Messaging_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        //Send Message
        public void sendMsg(string senderID, string receiverID, string time, string message)
        {
            //Loading the Messages.xml doc
            XmlDocument doc = new XmlDocument();
            doc.Load(AppDomain.CurrentDomain.BaseDirectory + "Messages.xml");

            //Adding to the Messages.xml doc
            XmlElement root = doc.DocumentElement;

            XmlElement individualMessageElement = doc.CreateElement("IndividualMessage");
            XmlAttribute senderIDAttribute = doc.CreateAttribute("SenderID");
            XmlAttribute receiverIDAAttribute = doc.CreateAttribute("ReceiverID");
            XmlAttribute timeStampAttribute = doc.CreateAttribute("TimeStamp");
            XmlAttribute textAttribute = doc.CreateAttribute("Text");

            senderIDAttribute.Value = senderID;
            receiverIDAAttribute.Value = receiverID;
            timeStampAttribute.Value = time;
            textAttribute.Value = message;

            root.AppendChild(individualMessageElement);
            individualMessageElement.Attributes.Append(senderIDAttribute);
            individualMessageElement.Attributes.Append(receiverIDAAttribute);
            individualMessageElement.Attributes.Append(timeStampAttribute);
            individualMessageElement.Attributes.Append(textAttribute);

            //Saving the Messages.xml doc
            doc.Save(AppDomain.CurrentDomain.BaseDirectory + "Messages.xml");
        }

        //Receive Message
        public string receiveMsg(string receiverID, string purge)
        {
            string messageArray = "";

            //Loading the Messages.xml doc
            XmlDocument doc = new XmlDocument();
            doc.Load(AppDomain.CurrentDomain.BaseDirectory + "Messages.xml");
            var nodes = doc.GetElementsByTagName("IndividualMessage");

            //Searching the Messages.xml for messages with the reciever ID
            foreach (XmlNode node in nodes)
            {
                if (node.Attributes != null && node.Attributes["ReceiverID"] != null && node.Attributes["ReceiverID"].Value == receiverID)
                {
                    string fullMessage = "From: " + node.Attributes["SenderID"].Value + "$" + "At: " + node.Attributes["TimeStamp"].Value + "$" + "Message: " + node.Attributes["Text"].Value + "$$";
                    messageArray = messageArray + fullMessage;
                }
            }

            //Purging
            if (purge == "yes")
            {
                XDocument messageDoc = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "Messages.xml");

                messageDoc.Descendants("IndividualMessage")
                    .Where(x => x.Attribute("ReceiverID") != null)
                    .Where(x => x.Attribute("ReceiverID").Value.Equals(receiverID))
                    .ToList()
                    .ForEach(x => x.Remove());

                //Saving the Messages.xml doc
                messageDoc.Save(AppDomain.CurrentDomain.BaseDirectory + "Messages.xml");
            }

            return messageArray;
        }
    }
}
