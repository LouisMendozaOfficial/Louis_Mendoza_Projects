using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CSE_445_Project3_Assignment6_NonRESTFUL_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        //Required Service (15 Points) - Louis Mendoza
        [OperationContract] string TopTenWords(string url);

        //Elective Service - Louis Mendoza
        [OperationContract] int AverageSentenceLength(string url);

        //Elective Service - Louis Mendoza
        [OperationContract] int NumberOfUnimportantWords(string url);

        //Elective Service - Louis Mendoza
        [OperationContract] string WordFilter(string inputString);

        //Elective Service - Louis Mendoza
        [OperationContract] string NumberOfSentences(string url);
    }
}
