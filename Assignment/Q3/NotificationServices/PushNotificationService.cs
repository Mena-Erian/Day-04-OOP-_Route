using Assignment.Q3.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Q3.NotificationServices
{
    internal class PushNotificationService : INotificationService
    {
        public void SendNotification(IChannel recipient, string message)
        {
            recipient.News = message;
        }
    }
}
