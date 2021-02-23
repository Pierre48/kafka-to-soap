using System.Runtime.Serialization;

namespace SoapServer.Models
{
    [DataContract]
    public class Machine
    {
       [DataMember]
        public string Id {get;set;}

       [DataMember]
        public Module[] Modules  {get;set;}
    }
}
