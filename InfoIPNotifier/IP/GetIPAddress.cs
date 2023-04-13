using InfoIPNotifier.Utilities;

namespace InfoIPNotifier.IP
{
    public class GetIPAddress
    {
        public static IPAddress getIPAddress(string endpoint)
        {
            string response = RequestManager.getRequest(endpoint);
            IPAddress ipAddress = new IPAddress(response);

            return ipAddress;
        }
    }
}
