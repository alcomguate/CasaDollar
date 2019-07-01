using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UdeoPrograXFinal.Service;

namespace UdeoPrograXFinal.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        public bool Delete(TEntity dt, int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(TEntity dt)
        {
            throw new NotImplementedException();
        }

        public bool Update(TEntity dt, int id)
        {
            throw new NotImplementedException();
        }
    }
}