using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdeoPrograXFinal.Models;

namespace UdeoPrograXFinal.Service
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> GetAllCliente();
    }
}
