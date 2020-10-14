using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace wcfasynctestclient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string s1;
            using (var client = new Service1Client(new NetTcpBinding(SecurityMode.None, false), new EndpointAddress("net.tcp://localhost:8733/wcfasynctestservice/Service1.svc")))
            {
                s1 = await client.LongCallAsync();
            }
            Console.WriteLine($"Two way async call finished. Returned: {s1}");

            string s2;
            using (var client = new Service1Client(new NetTcpBinding(SecurityMode.None, false), new EndpointAddress("net.tcp://localhost:8733/wcfasynctestservice/Service1.svc")))
            {
                s2 = client.LongCall();
            }
            Console.WriteLine($"Two way sync call finished. Returned: {s2}");

            using (var client = new OneWayService1Client(new NetTcpBinding(SecurityMode.None, true), new EndpointAddress("net.tcp://localhost:8733/wcfasynctestservice/OneWayService1.svc")))
            {
                Console.WriteLine($"Channel opened at {DateTime.Now}");
                client.LongOneWayCall("hello");
                Console.WriteLine($"One Way sync call finished at {DateTime.Now}");
            }
            Console.WriteLine($"Channel disposed at {DateTime.Now}");

            using (var client = new OneWayService1Client(new NetTcpBinding(SecurityMode.None, true), new EndpointAddress("net.tcp://localhost:8733/wcfasynctestservice/OneWayService1.svc")))
            {
                Console.WriteLine($"Channel opened at {DateTime.Now}");
                await client.LongOneWayCallAsync("hello");
                Console.WriteLine($"One Way async Call finished at {DateTime.Now}");
            }
            Console.WriteLine($"Channel disposed at {DateTime.Now}");
        }
    }
}
