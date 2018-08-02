using Microsoft.Extensions.Options;
using System.Data;
using System.Data.SqlClient;


namespace Navistar.DataContext
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public class DBNavimexVentasImp : IDBContext<DBNavimexVentasImp>
    {

        IDbConnection _dbConnection;
        public DBNavimexVentasImp(IOptions<ConnectionsConfig> connectionConfig)
        {
            _dbConnection = new SqlConnection(connectionConfig.Value.NavimexVentasDB);
        }
        public IDbConnection DBConnection => _dbConnection;
    }
}
