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
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;
        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void Add(Writer writer)
        {
            _writerDal.Insert(writer);
        }

        public void Delete(Writer writer)
        {
            _writerDal.Delete(writer);
        }

        public Writer GetByClassID(int id)
        {
            return _writerDal.GetByID(id);
        }

        public List<Writer> GetList()
        {
            return _writerDal.GetListAll();
        }

        public List<Writer> GetWriterByID(int writerId)
        {
            return _writerDal.FilterList(x => x.WriterID == writerId);
        }

        public void Update(Writer writer)
        {
            _writerDal.Update(writer);
        }
    }
}
