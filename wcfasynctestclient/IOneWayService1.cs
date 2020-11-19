using System;
using System.ServiceModel;
using System.Threading.Tasks;

namespace wcfasynctestclient
{
    [ServiceContract]
    public interface IOneWayService1 : wcftestcontracts.IOneWayService1, IDisposable
    {
        [OperationContract(IsOneWay = true)]
        Task OneWayCallAsync();
    }
}
