using InfoIPNotifier.IP;

namespace InfoIPNotifier.Utilities
{
    public class CreateFile
    {
        public static string generateFile(string text, string path)
        {
            string fileName = String.Format("YourIP_Information_{0}.txt", DateTime.Now.ToString("dd_MM_yyyy"));
            Console.WriteLine("Will generate new text file with name: {0}", fileName);

            if (!File.Exists(path + "\\" + fileName))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path + "\\" + fileName))
                {
                    sw.WriteLine(text);
                }
                Console.WriteLine("File is generated and can be found here: " + path);
            }
            return fileName;
        }

        public static string generateText(InformationFromIP informationFromIP)
        {
            string text =
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

