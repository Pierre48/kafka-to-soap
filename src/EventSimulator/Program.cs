using System;
using System.Threading;
using System.Threading.Tasks;
using Confluent.Kafka;

namespace EventSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var brokerList = Environment.GetEnvironmentVariable("BROKER_LIST")??"localhost:9092";
            string topicName = "stop-machine";
            CancellationToken ct = new CancellationToken();
            Task.Factory.StartNew(async () =>
            {
                try
                {
                var config = new ProducerConfig { BootstrapServers = brokerList };
                Console.WriteLine("Starting ... ");
                using (var producer = new ProducerBuilder<string, string>(config).Build())
                {
                    while (true)
                    {
                        producer.Produce(
                            topicName, new Message<string, string> { Key = "", Value =
"<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:tem=\"http://tempuri.org/\" xmlns:soap=\"http://schemas.datacontract.org/2004/07/SoapServer.Models\">" +
"   <soapenv:Header/>" +
"   <soapenv:Body>" +
"      <tem:HandleStop>" +
"         <tem:request>" +
"            <soap:Cause>rzerez</soap:Cause>" +
"            <soap:Machines>" +
"               <soap:Machine>" +
"                  <soap:Id>Machine1</soap:Id>" +
"                  <soap:Modules>" +
"                     <soap:Module>" +
"                        <soap:Id>Truscin 1</soap:Id>" +
"                     </soap:Module>" +
"                  </soap:Modules>" +
"               </soap:Machine>" +
"            </soap:Machines>" +
$"            <soap:Timestamp>"+DateTime.Now.ToString("yyyy-MM-ddThh:mm:ssZ")+"</soap:Timestamp>" +
"         </tem:request>" +
"      </tem:HandleStop>" +
"   </soapenv:Body>" +
"</soapenv:Envelope>"
                             },r=>{Console.WriteLine(r.Error.Reason );});

                        Thread.Sleep(1000);
                    }
                }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }, ct).ContinueWith(t=>{Console.WriteLine("end");}).Wait();
        }
    }
}
