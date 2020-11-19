using System;
using System.ServiceModel.Description;

namespace wcfasynctestclient
{
    public class ClientBase<T> : System.ServiceModel.ClientBase<T>, IDisposable
        where T : class
    {
        public ClientBase()
            : base()
        {

        }

        public ClientBase(ServiceEndpoint endpoint)
            : base(endpoint)
        {

        }

        void IDisposable.Dispose()
        {
            this.SafeDispose();
        }
    }
}
