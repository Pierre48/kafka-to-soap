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
                            topicName, new Message<string, string> { Key = "", Value = "" },r=>{Console.WriteLine(r.Error.Reason );});

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
