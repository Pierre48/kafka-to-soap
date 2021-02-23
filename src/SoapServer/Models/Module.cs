using System.Runtime.Serialization;

namespace SoapServer.Models
{
    [DataContract]
    public class Module
    {
       [DataMember]
        public string Id {get;set;}
    }
}
