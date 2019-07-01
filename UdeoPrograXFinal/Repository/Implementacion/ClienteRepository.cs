using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using UdeoPrograXFinal.Infrastructure;
using UdeoPrograXFinal.Entities;
using UdeoPrograXFinal.Service;

namespace UdeoPrograXFinal.Repository
{
    public class ClienteRepository : GenericRepository<Cliente>, IClienteRepository
    {

        IConnectionFactory _connectionFactory;

        public ClienteRepository(IConnectionFactory connectionFactory) {
            _connectionFactory = connectionFactory;
        }

        public async Task<IEnumerable<Cliente>> GetAllClientes()
        {
            var query = "SELECT * FROM REG_Cliente";
            var list = await SqlMapper.QueryAsync<Cliente>(_connectionFactory.GetConnection, query, null, commandType: System.Data.CommandType.Text);
            return list;
        }

        public new bool Insert(Cliente dt) {

            var query = "INSERT INTO REG_Cliente(PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Nacimiento, IngresoMensual) VALUES (@PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, @Nacimiento, @IngresoMensual)";
            var result = SqlMapper.Execute(_connectionFactory.GetConnection, query, new
            {
                dt.PrimerNombre,
                dt.SegundoNombre,
                dt.PrimerApellido,
                dt.SegundoApellido,
                dt.Nacimiento,
                dt.IngresoMensual
            });
            return (result > 0);
        }

    }
}