using System;
using System.Diagnostics;
using System.Threading;
using wcftestcontracts;

namespace wcfasynctestservice
{
    class OneWayService1 : IOneWayService1
    {
        public void LongOneWayCall(string message)
        {
            Debug.WriteLine($"Long running one-way call start {DateTime.Now}");
            Debug.WriteLine($"Received message {message}");
            Thread.Sleep(15000);
            Debug.WriteLine($"Long running one-way call end {DateTime.Now}");
        }
    }
}
