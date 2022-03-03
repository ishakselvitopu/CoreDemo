using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IWriterService
    {
        void WriterAdd(Writer writer);
        //void WriterDelete(Writer writer);
        //void WriterUpdate(Writer writer);
        //List<Writer> GetWriterList();
        //Writer GetByWriterID(int writerID);
    }
}
