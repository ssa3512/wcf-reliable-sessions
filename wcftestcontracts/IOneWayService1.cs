using System.ServiceModel;

namespace wcftestcontracts
{
    [ServiceContract]
    public interface IOneWayService1
    {
        [OperationContract(IsOneWay = true)]
        void OneWayCall();
    }
}
