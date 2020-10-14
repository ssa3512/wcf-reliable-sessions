using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace wcfasynctestclient
{
    [ServiceContract]
    public interface IService1 : wcftestcontracts.IService1
    {
        [OperationContract]
        Task<string> LongCallAsync();
    }
}
