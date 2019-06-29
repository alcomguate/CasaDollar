using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdeoPrograXFinal.Models;

namespace UdeoPrograXFinal.Service
{
    public interface IGenericRepository<TEntity> where TEntity: class
    {
        
        IEnumerable GetAll();

        IEnumerable GetByID(int id);

        bool Insert(TEntity dt);

        bool Update(TEntity dt, int id);

        bool Delete(TEntity dt, int id);

    }
}
