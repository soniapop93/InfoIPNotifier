using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoIPNotifier.IP;
using Microsoft.Toolkit.Uwp.Notifications;

namespace InfoIPNotifier.Utilities
{
    public static class SendNotification
    {
        public static void sendToastNotification(InformationFromIP informationFromIP)
        {
            string textNotification = generateTextNotification(informationFromIP);
            new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddText("Your IP Information:")
                .AddText(textNotification)
                .Show(toast =>
                {
                    toast.ExpirationTime = DateTime.Now.AddDays(1);
                });
        }

        public static string generateTextNotification(InformationFromIP informationFromIP)
        {
            string text = "";
            text =
                "Status: " + informationFromIP.status + "\n" +
                "Continent: " + informationFromIP.continent + "\n" +
                "Country: " + informationFromIP.country + "\n" +
                "Country Code: " + informationFromIP.countryCode + "\n" +
                "Region Name: " + informationFromIP.regionName + "\n" +
                "City: " + informationFromIP.city + "\n" +
                "Zip Code: " + informationFromIP.zip + "\n" +
                "Latitude: " + informationFromIP.lat.ToString() + "\n" +
                "Longitude: " + informationFromIP.lon.ToString() + "\n" +
                "Timezone: " + informationFromIP.timezone + "\n" +
                "Currency: " + informationFromIP.currency + "\n" +
                "ISP: " + informationFromIP.isp + "\n" +
                "Org: " + informationFromIP.org + "\n" +
                "ASN: " + informationFromIP.asn + "\n" +
                "Reverse: " + (informationFromIP.reverse.Length > 0 ? informationFromIP.reverse : "-") + "\n" +
                "Mobile: " + (informationFromIP.mobile ? "Yes" : "No") + "\n" +
                "Proxy: " + (informationFromIP.proxy ? "Yes" : "No") + "\n" +
                "IP Address: " + informationFromIP.ip + "\n" +
                "Cached: " + (informationFromIP.cached ? "Yes" : "No") + "\n" +
                "Cache Timestamp: " + informationFromIP.cacheTimestamp.ToString();

            return text;
        }
    }
}
