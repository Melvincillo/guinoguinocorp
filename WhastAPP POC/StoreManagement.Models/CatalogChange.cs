using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Models
{
    public class CatalogChange
    {
        public int CatalogId { get; set; }

        public string Description { get; set; }

        public bool Sent { get; set; }

        public IEnumerable<Notification> Notifications { get; set; }
    }
}
