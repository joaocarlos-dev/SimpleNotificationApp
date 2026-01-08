using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNotificationApp.Domain.Interfaces
{
    public interface INotificationService
    {
        public Task EnviarAsync(string message, string recipient);
    }
}
