using Dapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using UdeoPrograXFinal.Entities;
using UdeoPrograXFinal.Infrastructure;

namespace UdeoPrograXFinal.Repository
{
    public class PaisRepository : GenericRepository<Pais>, IPaisRepository
    {

        IConnectionFactory _connectionFactory;

        public PaisRepository(IConnectionFactory connectionFactory) {
            _connectionFactory = connectionFactory;
        }

        public async Task<IEnumerable<Pais>> GetAllPaises()
        {
            var query = "SELECT * FROM CAT_Pais";
            var list = await SqlMapper.QueryAsync<Pais>(_connectionFactory.GetConnection, query, null, commandType: System.Data.CommandType.Text);
            return list;
        }

        public async Task<IEnumerable<Pais>> GetAllPaisesByContinente(Continente continente)
        {
            var query = "SELECT * FROM CAT_Pais WHERE Continente = @Continente";
            var list = await SqlMapper.QueryAsync<Pais>(_connectionFactory.GetConnection, query, 
                new { Continente = continente.Id }, 
                commandType: System.Data.CommandType.Text);
            return list;
        }
    }
}