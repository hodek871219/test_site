using Navistar.DAO.Orders;
using Navistar.Model.common;
using Navistar.DataContext;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;


namespace Navistar.DAO.OrdersImp
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public class OrderDAOImp : IOrderDAO<TCP001_PEDIDO>, IDisposable
    {
        IDbConnection _dbContext;

        public OrderDAOImp(IDBContext<DBDatamartImp> context)
        {
            _dbContext = context.DBConnection;
        }

        public Task<int> AddOrder(TCP001_PEDIDO t)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteOrder(int cd_pedido)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            if (_dbContext != null)
            {
                _dbContext.Dispose();
            }
        }

        public Task<TCP001_PEDIDO> GetOrderById(int cd_pedido)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<TCP001_PEDIDO>> GetOrders()
        {
            var data = await _dbContext.QueryAsync<TCP001_PEDIDO>("select top 100 * from TCP001_PEDIDO with (NOLOCK)",
            commandType: CommandType.Text);
            return data.ToList();
        }

        public Task<int> UpdateOrder(int cd_pedido)
        {
            throw new NotImplementedException();
        }
    }
}
    

