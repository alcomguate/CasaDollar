using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdeoPrograXFinal.Entities;

namespace UdeoPrograXFinal.Service
{
    public interface IClienteRepository : IGenericRepository<Cliente>
    {

        Task<IEnumerable<Cliente>> GetAllClientes();

    }
}
