using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNotificationApp.Domain.Interfaces
{
    public interface INotificationLogger
    {
        void LogSucess(string message, string recipient);
        void LogError(Exception ex);
    }
}
