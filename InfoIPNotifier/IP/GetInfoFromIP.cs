using InfoIPNotifier.Utilities;
using System.Text.Json;

namespace InfoIPNotifier.IP
{
    public class GetInfoFromIP
    {
        public static string getInfoFromIPRequest(string endpoint)
        {
            return RequestManager.getRequest(endpoint);
        }

        public static InformationFromIP parseInfoFromIPRequest(string response)
        {
            InformationFromIP infoFromIP = JsonSerializer.Deserialize<InformationFromIP>(response);

            return infoFromIP;
        }

    }
}
