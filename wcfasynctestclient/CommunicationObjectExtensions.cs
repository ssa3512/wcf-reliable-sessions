using System.ServiceModel;

namespace wcfasynctestclient
{
    public static class CommunicationObjectExtensions
    {
        public static void SafeDispose(this ICommunicationObject communicationObject)
        {
            try
            {
                if (communicationObject.State != CommunicationState.Faulted)
                {
                    communicationObject.Close();
                }
                else
                {
                    communicationObject.Abort();
                }
            }
            catch
            {
                communicationObject.Abort();
            }
        }
    }
}
