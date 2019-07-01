using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UdeoPrograXFinal.Repository;
using UdeoPrograXFinal.Service;

namespace UdeoPrograXFinal.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IContinenteRepository _continenteRepository;
        private readonly IPaisRepository _paisRepository;
        private readonly IEstadoRepository _estadoRepository;

        public UnitOfWork(IClienteRepository clienteRepository, 
            IContinenteRepository continenteRepository,
            IPaisRepository paisRepository,
            IEstadoRepository estadoRepository) {
            _clienteRepository = clienteRepository;
            _continenteRepository = continenteRepository;
            _paisRepository = paisRepository;
            _estadoRepository = estadoRepository;
        }

        public UnitOfWork(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public UnitOfWork(IContinenteRepository continenteRepository) {
            _continenteRepository = continenteRepository;
        }

        public UnitOfWork(IPaisRepository paisRepository) {
            _paisRepository = paisRepository;
        }

        public UnitOfWork(IEstadoRepository estadoRepository) {
            _estadoRepository = estadoRepository;
        }

        public void Complete()
        {
            throw new NotImplementedException();
        }
        
        public IContinenteRepository ContinenteRepository => _continenteRepository;

        public IPaisRepository PaisRepository => _paisRepository;

        public IEstadoRepository EstadoRepository => _estadoRepository;

        public IClienteRepository ClienteRepository => _clienteRepository;

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}