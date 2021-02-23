using System.Runtime.Serialization;

namespace SoapServer.Models
{
    [DataContract]
    public class StopRequest
    {
       [DataMember]
        public string Cause {get;set;}
       [DataMember]
        public System.DateTime Timestamp {get;set;}
       [DataMember]
        public Machine[] Machines {get;set;}
    }
}
