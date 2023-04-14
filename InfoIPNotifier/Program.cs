using InfoIPNotifier.IP;
using InfoIPNotifier.Utilities;
public class Program
{
    public static void Main(string[] args)
    {
        /*
           =============================================================
           =============================================================
              The API endoint used in this script is free to use.
              https://api.techniknews.net/ipgeo/ + ipAddress
              https://ipinfo.io/ip

           =============================================================
           =============================================================
        */

        Console.WriteLine("------------------------ SCRIPT STARTED ------------------------");
        try
        {
            IPAddress ipAddress = GetIPAddress.getIPAddress("https://ipinfo.io/ip");
            Console.WriteLine(String.Format("Your IP Address is: {0}", ipAddress.ip));

            string response = GetInfoFromIP.getInfoFromIPRequest("https://api.techniknews.net/ipgeo/" + ipAddress.ip);
            InformationFromIP informationFromIP = GetInfoFromIP.parseInfoFromIPRequest(response);

            string filePath = "C:\\Users\\" + Environment.UserName + "\\Desktop";
            string text = CreateFile.generateText(informationFromIP);
            string fileName = CreateFile.generateFile(text, filePath);

            SendNotification.sendToastNotification("File is saved", String.Format("Your IP details can be found here: {0}\\{1}", filePath, fileName));
        }
        catch (Exception e)
        {
            Console.WriteLine("There was an exception: {0} {1} {2} {3}", e.Message, "\n", e.Source, "\n", e.StackTrace);
        }

        Console.WriteLine("------------------------ SCRIPT FINISHED ------------------------");
    }
}