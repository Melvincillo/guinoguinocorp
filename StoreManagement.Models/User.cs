using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Models
{
    public class User
    {
        public NotificationType NotificationConfiguration { get; set; }

        public string FullName { get; set; }

        public string ID { get; set; }

        public IEnumerable<UserRole> Roles { get; set; }
    }
}
