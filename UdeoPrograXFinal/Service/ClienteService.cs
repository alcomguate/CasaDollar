using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using UdeoPrograXFinal.Models;
using UdeoPrograXFinal.UnitOfWork;

namespace UdeoPrograXFinal.Service
{
    public class ClienteService : IClienteService
    {

        IUnitOfWork _unitOfWork;

        public ClienteService(IUnitOfWork unitOfWork) {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Cliente>> GetAllCliente()
        {
            return await _unitOfWork.ClienteRepository.GetAllClientes();
        }
    }
}