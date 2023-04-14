using Microsoft.Toolkit.Uwp.Notifications;

namespace InfoIPNotifier.Utilities
{
    public static class SendNotification
    {
        public static void sendToastNotification(string titleNotification,string textNotification)
        {
            new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddText(titleNotification)
                .AddText(textNotification)
                .Show(toast => toast.ExpirationTime = DateTime.Now.AddDays(1));
        } 
    }
}
