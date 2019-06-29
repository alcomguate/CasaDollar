using System.Configuration;
using System.Data;
using Dapper;

namespace UdeoPrograXFinal.Infrastructure
{
    public interface IConnectionFactory
    {

        IDbConnection GetConnection { get; }

    }
}