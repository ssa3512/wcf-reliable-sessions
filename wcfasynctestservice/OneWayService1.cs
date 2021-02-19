using System;
using System.Diagnostics;
using System.Threading;
using wcftestcontracts;

namespace wcfasynctestservice
{
    class OneWayService1 : IOneWayService1
    {
        public void OneWayCall()
        {
            Debug.WriteLine($"Long running one-way call start {DateTime.Now}");
            Thread.Sleep(5000);
            Debug.WriteLine($"Long running one-way call end {DateTime.Now}");
        }
    }
}
