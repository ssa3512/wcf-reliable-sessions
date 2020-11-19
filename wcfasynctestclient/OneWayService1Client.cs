using System.ServiceModel.Description;
using System.Threading.Tasks;

namespace wcfasynctestclient
{
    public class OneWayService1Client : ClientBase<IOneWayService1>, IOneWayService1
    {
        public OneWayService1Client(ServiceEndpoint endpoint)
            : base(endpoint)
        {

        }

        public void OneWayCall()
        {
            Channel.OneWayCall();
        }

        public Task OneWayCallAsync()
        {
            return Channel.OneWayCallAsync();
        }
    }
}
