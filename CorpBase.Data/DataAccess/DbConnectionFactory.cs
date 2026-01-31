using System;
using System.Data.SqlTypes;
using Microsoft.Data.SqlClient;

namespace CorpBase.Data.DataAccess;

public static class DbConnectionFactory
{
    private static readonly string _connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=CorpBaseDB;Trusted_Connection=True;TrustServerCertificate=True";
    public static SqlConnection Create()
    {
        return new SqlConnection(_connectionString);
    }
}
