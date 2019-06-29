using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using UdeoPrograXFinal.Infrastructure;
using UdeoPrograXFinal.Models;
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
            var list = await SqlMapper.QueryAsync<Cliente>(_connectionFactory.GetConnection, query, null, commandType: System.Data.CommandType.TableDirect);
            return list;
        }

    }
}