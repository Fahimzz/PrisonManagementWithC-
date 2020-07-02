using Prison_Management_System.Entities;
using Prison_Management_System.Interface;
using Prison_Management_System.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prison_Management_System.Services
{
    class NoticeService
    {
        NotificationRepo nr;
        INotification<Notification> n;
        public NoticeService()
        {
            nr = new NotificationRepo();
            n = new NotificationRepo();
        }
        public int Postnotice(string notice, string date)
        {
            return nr.Save(new Notification { Notice=notice,Date=date }); ;
        }
        public List<Notification> getNotifications()
        {
            return n.GetAll();
        }
    }
}
