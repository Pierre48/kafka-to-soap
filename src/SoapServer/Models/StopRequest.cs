using System.Runtime.Serialization;
using System.Text;

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
        public override string ToString()
        {
            var strb = new StringBuilder();
            strb.AppendLine();
            strb.Append("Cause : ").Append(Cause).AppendLine();
            strb.Append("Timestamp : ").Append(Timestamp).AppendLine();
            if (Machines != null)
                foreach (var m in Machines)
                    strb.Append(" - Machine : ").Append(m?.Id).AppendLine();
            return strb.ToString();
        }
    }
}
