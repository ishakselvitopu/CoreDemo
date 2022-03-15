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
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;
        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }
        public void Add(Message message)
        {
            throw new NotImplementedException();
        }

        public void Delete(Message message)
        {
            throw new NotImplementedException();
        }

        public Message GetByClassID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Message> GetInboxMessageByWriter(string receverMail)
        {
            return _messageDal.FilterList(x => x.Recever == receverMail);
        }

        public void Update(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
