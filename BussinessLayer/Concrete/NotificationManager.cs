using BussinessLayer.Abstract;
using DataAcessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class NotificationManager : INotificationService
    {
        INotificationDal _notificationDal;
        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }
        public void Add(Notification notification)
        {
            throw new NotImplementedException();
        }

        public void Delete(Notification notificationt)
        {
            throw new NotImplementedException();
        }

        public Notification GetByClassID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Notification> GetList()
        {
            return _notificationDal.GetListAll();
        }

        public void Update(Notification notificationt)
        {
            throw new NotImplementedException();
        }
    }
}
