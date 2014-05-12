using StoreManagement.DataAccess;
using StoreManagement.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatsAppApi;
using WhatsAppApi.Account;
using WhatsAppApi.Register;

namespace StoreManagement.Business
{
    public class NotificationService
    {
        public NotificationDal NotificationDal { get; set; }

        public NotificationService()
        {
            this.NotificationDal = new NotificationDal();
        }
        public Collection<CatalogChange> GetPendingChangeNotifications()
        {
            //Other biz here             
            return this.NotificationDal.GetPendingChangeNotifications();
        }


        public void Notify(Notification notification)
        {
            if((notification.Configuration.HasFlag(NotificationType.WhatsApp)))
            {
                Encoding tmpEncoding = Encoding.UTF8;
                System.Console.OutputEncoding = Encoding.Default;
                System.Console.InputEncoding = Encoding.Default;
                string nickname = "WhatsApiNet";
                string sender = "523315168566";
                string password = "pass";
                WhatsUserManager userManager= new WhatsUserManager();
                WhatsUser destinationUser = userManager.CreateUser(notification.Destination, "User");
                WhatsApp client = new WhatsApp(sender, password, nickname, true);
                client.Connect();
                client.Message(destinationUser.GetFullJid(), notification.Message);
            }
        }
    }
}
