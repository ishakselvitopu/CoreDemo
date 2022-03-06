﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void Add(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
        T GetByClassID(int id);
    }
}
