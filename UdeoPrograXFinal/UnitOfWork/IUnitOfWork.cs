using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdeoPrograXFinal.Repository;
using UdeoPrograXFinal.Service;

namespace UdeoPrograXFinal.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {

        IClienteRepository ClienteRepository { get; }
        IContinenteRepository ContinenteRepository { get; }
        IPaisRepository PaisRepository { get; }
        IEstadoRepository EstadoRepository { get; }

        void Complete();

    }
}
