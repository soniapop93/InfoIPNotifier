using InfoIPNotifier.Utilities;
using System;
using System.Text.Json;

namespace InfoIPNotifier.IP
{
    public class GetInfoFromIP
    {
        public static string getInfoFromIPRequest(string endpoint)
        {
            string response = RequestManager.getRequest(endpoint);
            return response;
        }

        public static InformationFromIP parseInfoFromIPRequest(string response)
        {
            InformationFromIP infoFromIP = JsonSerializer.Deserialize<InformationFromIP>(response);

            return infoFromIP;
        }
    }
}
