using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Models
{
    [Flags]
    public enum NotificationType
    {
        Email = 1,
        WhatsApp = 2,
        Sms = 4
    }
}
