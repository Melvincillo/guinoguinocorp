using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Models
{
    public class Notification
    {
        public string Message { get; set; }

        public string Destination { get; set; }

        public NotificationType Configuration { get; set; }
    }
}
