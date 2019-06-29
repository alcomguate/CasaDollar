using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UdeoPrograXFinal.Service;

namespace UdeoPrograXFinal.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IClienteRepository _clienteRepository;

        public UnitOfWork(IClienteRepository clienteRepository) {
            _clienteRepository = clienteRepository;
        }

        public void Complete()
        {
            throw new NotImplementedException();
        }

        public IClienteRepository ClienteRepository {
            get {
                return _clienteRepository;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}