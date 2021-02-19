using System;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Threading.Tasks;

namespace wcfasynctestclient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var nettcpBinding = new NetTcpBinding(SecurityMode.None);
            var contract = ContractDescription.GetContract(typeof(IOneWayService1));
            var endpointAddr = new EndpointAddress("net.tcp://localhost:8733/wcfasynctestservice/OneWayService1.svc");
            var serviceEndpoint = new ServiceEndpoint(contract, nettcpBinding, endpointAddr);

            var sw = new Stopwatch();

            while (true)
            {
                sw.Restart();

                using (var client = new OneWayService1Client(serviceEndpoint))
                {
                    client.OneWayCall();
                }
                sw.Stop();
                Console.WriteLine(sw.ElapsedMilliseconds);

                await Task.Delay(100);
            }
        }
    }
}
