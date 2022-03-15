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
    public class Message2Manager : IMessage2Service
    {
        IMessage2Dal _message2Dal;
        public Message2Manager(IMessage2Dal message2Dal)
        {
            _message2Dal = message2Dal;
        }
        public void Add(Message2 message)
        {
            throw new NotImplementedException();
        }

        public void Delete(Message2 messaget)
        {
            throw new NotImplementedException();
        }

        public Message2 GetByClassID(int id)
        {
            return _message2Dal.GetByID(id);
        }


        public List<Message2> GetList()
        {
            return _message2Dal.GetListAll();
        }

        public void Update(Message2 messaget)
        {
            throw new NotImplementedException();
        }

        public List<Message2> GetInboxMessageByWriter(int ID)
        {
            return _message2Dal.GetListWithMessageByWriter(ID);
        }
    }
}
