using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace wcfasynctestclient
{
    public class Service1Client : ClientBase<IService1>, IService1
    {
        public Service1Client(Binding binding, EndpointAddress remoteAddress) 
            : base(binding, remoteAddress)
        {

        }

        public string LongCall()
        {
            return Channel.LongCall();
        }

        public Task<string> LongCallAsync()
        {
            return Channel.LongCallAsync();
        }
    }
}
