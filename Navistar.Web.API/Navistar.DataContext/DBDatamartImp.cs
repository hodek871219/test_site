using Microsoft.Extensions.Options;
using System.Data;
using System.Data.SqlClient;
using Mastercon;

namespace Navistar.DataContext
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public class DBDatamartImp:IDBContext<DBDatamartImp>
    {
        IDbConnection _dbConnection;
        Masterconnect_Interface _dbConnectionString;
        public DBDatamartImp(IOptions<ConnectionsConfig> connectionConfig)
        {
            _dbConnectionString = new Masterconnect();
            _dbConnection = new SqlConnection(_dbConnectionString.GetDataConn(connectionConfig.Value.APP_NAME, connectionConfig.Value.DataMartDB));
        }
        public IDbConnection DBConnection => _dbConnection;
    }
}
