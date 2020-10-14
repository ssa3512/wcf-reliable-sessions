using System;
using System.Diagnostics;
using System.Threading;
using wcftestcontracts;

namespace wcfasynctestservice
{
    public class Service1 : IService1
    {
        public string LongCall()
        {
            Debug.WriteLine($"Two-way call start {DateTime.Now}");
            Thread.Sleep(5000);
            Debug.WriteLine($"Two-way call end {DateTime.Now}");
            return "Hello Long Call";
        }
    }
}
