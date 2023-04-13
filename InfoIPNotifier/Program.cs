using InfoIPNotifier.IP;
using InfoIPNotifier.Utilities;
using System;

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
            Console.WriteLine(ipAddress.ip);

            string response = GetInfoFromIP.getInfoFromIPRequest("https://api.techniknews.net/ipgeo/" + ipAddress.ip);
            InformationFromIP informationFromIP = GetInfoFromIP.parseInfoFromIPRequest(response);

            SendNotification.sendToastNotification(informationFromIP);
        }
        catch (Exception e)
        {
            Console.WriteLine("There was an exception: {0} {1} {2} {3}", e.Message, "\n", e.Source, "\n", e.StackTrace);
        }
        Console.WriteLine("------------------------ SCRIPT FINISHED ------------------------");
    }
}