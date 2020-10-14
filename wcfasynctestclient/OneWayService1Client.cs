using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace wcfasynctestclient
{
    public class OneWayService1Client : ClientBase<IOneWayService1>, IOneWayService1
    {
        public OneWayService1Client(Binding binding, EndpointAddress remoteAddress) 
            : base(binding, remoteAddress)
        {

        }

        public void LongOneWayCall(string message)
        {
            Channel.LongOneWayCall(message);
        }

        public Task LongOneWayCallAsync(string message)
        {
            return Channel.LongOneWayCallAsync(message);
        }
    }
}
