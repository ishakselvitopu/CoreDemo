using DataAcessLayer.Abstract;
using DataAcessLayer.Concrete;
using DataAcessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.EntityFramework
{
    public class EfMessage2Repository:GenericRepository<Message2>,IMessage2Dal
    {
        public List<Message2> GetListWithMessageByWriter(int id)
        {
            using (var context = new Context())
            {
                return context.Messages2.Include(x => x.SenderWriter).Where(x => x.ReceiverID == id).ToList();
            }
        }
    }
}
