using System.Collections.Generic;
using System.Threading.Tasks;
using UdeoPrograXFinal.Entities;

namespace UdeoPrograXFinal.Service
{
    public interface IContinenteService
    {

        Task<IEnumerable<Continente>> GetAllContinente();

        Task<Continente> GetContinenteById(int id);

    }
}
