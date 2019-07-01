
using System.Collections.Generic;
using System.Threading.Tasks;
using UdeoPrograXFinal.Entities;

namespace UdeoPrograXFinal.Repository
{
    public interface IPaisRepository: IGenericRepository<Pais>
    {

        Task<IEnumerable<Pais>> GetAllPaises();

        Task<IEnumerable<Pais>> GetAllPaisesByContinente(Continente continente);

    }
}
