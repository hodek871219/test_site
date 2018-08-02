using System;
using System.Collections.Generic;
using System.Text;
using Navistar.Model.common;
using System.Threading.Tasks;

namespace Navistar.DAO.Orders
{
    public interface IOrderDAO<T> where T : Entity
    {
        Task<ICollection<T>> GetOrders();
        Task<T> GetOrderById(int cd_pedido);
        Task<int> AddOrder(T t);
        Task<int> UpdateOrder(int cd_pedido);
        Task<int> DeleteOrder(int cd_pedido);
    }
}
