using System.Collections.Generic;
using System.Threading.Tasks;
using UdeoPrograXFinal.Entities;

namespace UdeoPrograXFinal.Service
{
    public interface IPaisService
    {

        Task<IEnumerable<Pais>> GetAllPaises();

        Task<IEnumerable<Pais>> GetPaisesByContinente(Continente continente);

    }
}
