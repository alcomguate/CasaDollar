using System.Collections.Generic;
using System.Threading.Tasks;
using UdeoPrograXFinal.Entities;

namespace UdeoPrograXFinal.Repository
{
    public interface IContinenteRepository: IGenericRepository<Continente>
    {

        Task<IEnumerable<Continente>> GetAllContinentes();

        Task<Continente> GetContinenteById(int id);

    }
}
