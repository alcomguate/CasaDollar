using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using UdeoPrograXFinal.Entities;
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

        public async Task<IEnumerable<Cliente>> GetClienteById(int id)
        {
            return await _unitOfWork.ClienteRepository.GetClienteById(id);
        }

        public bool Insert(Cliente dt)
        {
            return _unitOfWork.ClienteRepository.Insert(dt);
        }



    }
}