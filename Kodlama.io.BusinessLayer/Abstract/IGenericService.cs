﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T t);
        void Update(T t);
        void Delete(T t);
    }
}
