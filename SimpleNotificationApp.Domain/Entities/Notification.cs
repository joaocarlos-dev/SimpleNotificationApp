using SimpleNotificationApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNotificationApp.Domain.Entities
{
    public class Notification
    {
        public NotificationType Type { get; }
        public string Message { get; }
        public string Recipient { get; }

        public Notification(
            NotificationType type, 
            string message, 
            string recipient)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new ArgumentNullException("Message can not be Null or empty");
            }
            if (string.IsNullOrEmpty(recipient))
            {
                throw new ArgumentNullException("Recipient can not be Null or empty");
            }
            Type = type;
            Message = message;
            Recipient = recipient;
        }
    }
}
