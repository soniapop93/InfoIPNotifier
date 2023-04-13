using System.Text.Json.Serialization;

namespace InfoIPNotifier.IP
{
    public class InformationFromIP
    {
        public string status { get; set; }
        public string continent { get; set; }
        public string country { get; set; }
        public string countryCode { get; set; }
        public string regionName { get; set; }
        public string city { get; set; }
        public string zip { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public string timezone { get; set; }
        public string currency { get; set; }
        public string isp { get; set; }
        public string org { get; set; }
        [JsonPropertyName("as")]
        public string asn { get; set; }
        public string reverse { get; set; }
        public bool mobile { get; set; }
        public bool proxy { get; set; }
        public string ip { get; set; }
        public bool cached { get; set; }
        public long cacheTimestamp { get; set; }
    }
}
