using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using UdeoPrograXFinal.Entities;
using UdeoPrograXFinal.UnitOfWork;

namespace UdeoPrograXFinal.Service
{
    public class ContinenteService : IContinenteService
    {

        IUnitOfWork _unitOfWork;

        public ContinenteService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Continente>> GetAllContinente()
        {
            return await _unitOfWork.ContinenteRepository.GetAllContinentes();
        }

        public async Task<Continente> GetContinenteById(int id)
        {
            return await _unitOfWork.ContinenteRepository.GetContinenteById(id);
        }
    }
}