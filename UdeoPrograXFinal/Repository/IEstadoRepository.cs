using System.Collections.Generic;
using System.Threading.Tasks;
using UdeoPrograXFinal.Entities;

namespace UdeoPrograXFinal.Repository
{
    public interface IEstadoRepository : IGenericRepository<Estado>
    {

        Task<IEnumerable<Estado>> GetAllEstados();

        Task<IEnumerable<Estado>> GetEstadosByPais(Pais pais);

    }
}
