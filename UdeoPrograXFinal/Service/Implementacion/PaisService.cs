using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using UdeoPrograXFinal.Entities;
using UdeoPrograXFinal.UnitOfWork;

namespace UdeoPrograXFinal.Service
{
    public class PaisService : IPaisService
    {
        readonly IUnitOfWork _unitOfWork;

        public PaisService(IUnitOfWork unitOfWork) {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Pais>> GetAllPaises()
        {
            return await _unitOfWork.PaisRepository.GetAllPaises();
        }

        public async Task<IEnumerable<Pais>> GetPaisesByContinente(Continente continente)
        {
            return await _unitOfWork.PaisRepository.GetAllPaisesByContinente(continente);
        }
    }
}