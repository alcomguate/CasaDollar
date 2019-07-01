using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using UdeoPrograXFinal.Entities;
using UdeoPrograXFinal.UnitOfWork;

namespace UdeoPrograXFinal.Service
{
    public class EstadoService : IEstadoService
    {

        readonly IUnitOfWork _unitOfWork;

        public EstadoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IEnumerable<Estado>> GetAllEstados()
        {
            return _unitOfWork.EstadoRepository.GetAllEstados();
        }

        public Task<IEnumerable<Estado>> GetEstadosByPais(Pais pais)
        {
            return _unitOfWork.EstadoRepository.GetEstadosByPais(pais);
        }
    }
}