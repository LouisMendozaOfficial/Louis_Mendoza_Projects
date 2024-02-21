using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Net;
using System.IO;
using System.Web;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Linq;

namespace XML_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        //Validation Service
        public bool Validation(string url)
        {

            bool isValid = false;

            string xml;
            
            //Checking if the URL is valid
            try
            {

                //Downloading XML file
                using (var webClient = new WebClient())
                {
                    xml = webClient.DownloadString(url);
                }
            }
            catch (WebException e)
            {
                isValid = false;
                return isValid;
            }

            //Validation
            try
            {
                XDocument doc = XDocument.Parse(xml);

                XmlSchemaSet schema = new XmlSchemaSet();
                schema.Add(null, "https://www.public.asu.edu/~lgmendo1/Cruises.xsd");

                bool validationErrors = false;

                //Checking for validation errors
                doc.Validate(schema, (s, e) =>
                {
                    validationErrors = true;
                });

                if (validationErrors)
                {
                    isValid = false;
                    return isValid;
                }

                else
                {
                    isValid = true;
                    return isValid;
                }

            }

            catch (XmlException exception)
            {
                isValid = false;
                return isValid;
            }
        }

        //XML Path Search Service
        public string XMLPathSearch(string url, string path)
        {
            //Validating the URL
            if(Validation(url))
            {
                var doc = new XmlDocument();
                doc.Load(url);

                XmlNodeList nodes = doc.SelectNodes(path);

                string output = "";

                //Getting the node content
                foreach (XmlNode xmlNode in nodes)
                {
                    output = output + "<br>" + xmlNode.InnerText + "<br>";
                }
                
                //Handling a bad path
                if (output == "")
                {
                    return "Invalid Path.";
                }

                else
                {
                    return output;
                }
            }

            else
            {
                return "Invalid URL.";
            }

        }

    }
}
