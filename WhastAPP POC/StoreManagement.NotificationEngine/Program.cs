using StoreManagement.Business;
using StoreManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.NotificationEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificationService service = new NotificationService();
            IEnumerable<CatalogChange> changes = service.GetPendingChangeNotifications();
            //Maybe use paralell.foreach here.. 
            foreach (CatalogChange change in changes)
            {                
                foreach (Notification notification in change.Notifications)
                {
                    service.Notify(notification);
                }
                change.Sent = true;
                //Change status
            }
        }
    }
}
