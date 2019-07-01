using System.Collections.Generic;
using System.Threading.Tasks;
using UdeoPrograXFinal.Entities;

namespace UdeoPrograXFinal.Service
{
    public interface IEstadoService
    {

        Task<IEnumerable<Estado>> GetAllEstados();

        Task<IEnumerable<Estado>> GetEstadosByPais(Pais pais);

    }
}
