using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using UdeoPrograXFinal.Entities;
using UdeoPrograXFinal.Infrastructure;

namespace UdeoPrograXFinal.Repository
{
    public class EstadoRepository : GenericRepository<Estado>, IEstadoRepository
    {

        IConnectionFactory _connectionFactory;

        public EstadoRepository(IConnectionFactory connectionFactory) {
            _connectionFactory = connectionFactory;
        }

        public async Task<IEnumerable<Estado>> GetAllEstados()
        {
            var query = "SELECT * FROM REG_Estado";
            var list = await SqlMapper.QueryAsync<Estado>(_connectionFactory.GetConnection, query, null, commandType: System.Data.CommandType.Text);
            return list;
        }

        public async Task<IEnumerable<Estado>> GetEstadosByPais(Pais pais)
        {
            var query = "SELECT * FROM REG_Cliente WHERE Pais = @Pais";
            var list = await SqlMapper.QueryAsync<Estado>(_connectionFactory.GetConnection, query, new { pais.Id }, commandType: System.Data.CommandType.Text);
            return list;
        }
    }
}