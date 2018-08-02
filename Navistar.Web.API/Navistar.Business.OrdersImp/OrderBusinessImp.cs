using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Navistar.Business.Orders;
using Navistar.Model.common;
using Navistar.DAO.Orders;
namespace Navistar.Business.OrdersImp
{
    public class OrderBusinessImp : IOrderBusiness<TCP001_PEDIDO>
    {
         private readonly IOrderDAO<TCP001_PEDIDO> _efDataAccess;

        public OrderBusinessImp(IOrderDAO<TCP001_PEDIDO> efDataAccess)
        {
            _efDataAccess = efDataAccess;
        }

        public Task<int> AddOrder(TCP001_PEDIDO t)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteOrder(int cd_pedido)
        {
            throw new NotImplementedException();
        }

        public Task<TCP001_PEDIDO> GetOrderById(int cd_pedido)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<TCP001_PEDIDO>> GetOrders()
        {
          return await  _efDataAccess.GetOrders();
        }

        public async Task<IEnumerable<TCP001_PEDIDO>> GetTopTenOrders()
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateOrder(int cd_pedido)
        {
            throw new NotImplementedException();
        }
    }
}
