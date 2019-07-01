using System.Collections.Generic;
using System.Threading.Tasks;
using UdeoPrograXFinal.Entities;

namespace UdeoPrograXFinal.Repository
{
    public interface IClienteRepository : IGenericRepository<Cliente>
    {

        Task<IEnumerable<Cliente>> GetAllClientes();

        Task<IEnumerable<Cliente>> GetClienteById(int id);

    }
}
