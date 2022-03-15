﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IMessage2Service:IGenericService<Message2>
    {
        List<Message2> GetInboxMessageByWriter(int ID);
        
    }
}
