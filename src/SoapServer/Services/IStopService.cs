using System.ServiceModel;
using SoapServer.Models;

namespace SoapServer.Services
{
    [ServiceContract]
    public interface IStopService
    {
        [OperationContract]
        void HandleStop(StopRequest request);
    }
}
