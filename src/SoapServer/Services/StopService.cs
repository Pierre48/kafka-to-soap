using System;
using SoapServer.Models;

namespace SoapServer.Services
{
    public class StopService : IStopService
    {
        public void HandleStop(StopRequest request)
        {
            Console.WriteLine($"Stop request was received : {request}");
        }
    }
}
