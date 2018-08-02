using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Navistar.Business.Orders;
using Navistar.Model.common;
using Navistar.DAO.Orders;
namespace Navistar.Business.OrdersImp
{
    public class OrderBusinessEFImp :IOrderBusinessEF
    {
        private readonly IOrderEFDAO  _efDataAccess;

        public OrderBusinessEFImp(IOrderEFDAO efDataAccess)
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

        public Task<ICollection<TCP001_PEDIDO>> GetOrders()
        {
            throw new NotImplementedException();
        }

        public async  Task<IEnumerable<TCP001_PEDIDO>> GetTopTenOrders()
        {
           var data=await  _efDataAccess.GetAllAsync();
            return data;
        }

        public Task<int> UpdateOrder(int cd_pedido)
        {
            throw new NotImplementedException();
        }
    }
}
