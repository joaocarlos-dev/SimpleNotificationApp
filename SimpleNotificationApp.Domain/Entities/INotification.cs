using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNotificationApp.Domain.Entities
{
    public class Notification
    {
        public string Type { get; }
        public string Message { get; }
        public string Recipient { get; }

    }
}
