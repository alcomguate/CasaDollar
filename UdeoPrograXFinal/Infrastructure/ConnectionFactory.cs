﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;

namespace UdeoPrograXFinal.Infrastructure
{
    public class ConnectionFactory: IConnectionFactory
    {

        private readonly string connectionString = ConfigurationManager.ConnectionStrings["CiudadDollarBD"].ConnectionString;
        public IDbConnection GetConnection
        {
            get
            {
                var factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
                var conn = factory.CreateConnection();
                conn.ConnectionString = connectionString;
                conn.Open();
                return conn;
            }
        }

    }
}