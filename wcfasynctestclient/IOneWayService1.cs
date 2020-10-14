using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace wcfasynctestclient
{
    [ServiceContract]
    public interface IOneWayService1 : wcftestcontracts.IOneWayService1
    {
        [OperationContract(IsOneWay = true)]
        Task LongOneWayCallAsync(string message);
    }
}
