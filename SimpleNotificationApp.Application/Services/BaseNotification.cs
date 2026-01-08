using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleNotificationApp.Domain.Interfaces;

namespace SimpleNotificationApp.Application.Services
{
    
    public abstract class BaseNotification : INotificationService
    {
        public async Task EnviarAsync(string message, string recipient)
        {
            try
            {
                await EnviarCoreAsync(message, recipient);

            }
            catch (Exception ex) {
            }
        }

        protected abstract Task EnviarCoreAsync(string message, string recipient);

    }
}
