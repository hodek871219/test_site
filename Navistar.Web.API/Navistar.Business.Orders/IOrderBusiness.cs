using System;
using System.Collections.Generic;
using System.Text;
using Navistar.Model.common;
using System.Threading.Tasks;

namespace Navistar.Business.Orders
{
    public interface IOrderBusiness<T> where T : Entity
    {
        Task<ICollection<T>> GetOrders();
        Task<IEnumerable<T>> GetTopTenOrders();
        Task<T> GetOrderById(int cd_pedido);
        Task<int> AddOrder(T t);
        Task<int> UpdateOrder(int cd_pedido);
        Task<int> DeleteOrder(int cd_pedido);
    }
}
