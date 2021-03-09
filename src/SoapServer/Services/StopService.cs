using System;
using SoapServer.Models;

namespace SoapServer.Services
{
    public class StopService : IStopService
    {
        public void HandleStop(StopRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            Console.WriteLine($"Stop request was received : " + request?.ToString());
        }
    }
}
