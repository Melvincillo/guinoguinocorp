using StoreManagement.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DataAccess
{
    public class NotificationDal 
    {
        //Now in memory
        public Collection<CatalogChange> GetPendingChangeNotifications()
        {
            //This should get changes that have not been notified.
            Collection<CatalogChange> changes = new Collection<CatalogChange>();
            CatalogChange change = new CatalogChange();
            Collection<Notification> notifications = new Collection<Notification>();
            notifications.Add(new Notification() { Message = "Testing", Configuration = NotificationType.WhatsApp, Destination = "523315138566" });
            change.Notifications = notifications;
            changes.Add(change);
            return changes;
        }
        
            

    }
}
