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
    public class ContinenteRepository : GenericRepository<Continente>, IContinenteRepository
    {

        IConnectionFactory _connectionFactory;

        public ContinenteRepository(IConnectionFactory connectionFactory) {
            _connectionFactory = connectionFactory;
        }

        public async Task<IEnumerable<Continente>> GetAllContinentes()
        {
            var query = "SELECT * FROM CAT_Continente";
            var list = await SqlMapper.QueryAsync<Continente>(_connectionFactory.GetConnection, query, null, commandType: System.Data.CommandType.Text);
            return list;
        }

        public async Task<Continente> GetContinenteById(int id)
        {
            var query = "SELECT TOP 1 * FROM CAT_Continente WHERE Id = @Id";
            var list = await SqlMapper.QueryAsync<Continente>(_connectionFactory.GetConnection, query, new { id }, commandType: System.Data.CommandType.Text);
            return list.FirstOrDefault();
        }
    }
}