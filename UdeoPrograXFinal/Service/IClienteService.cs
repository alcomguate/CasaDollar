using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdeoPrograXFinal.Entities;

namespace UdeoPrograXFinal.Service
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> GetAllCliente();

        Task<IEnumerable<Cliente>> GetClienteById(int id);

        bool Insert(Cliente dt);

    }
}
