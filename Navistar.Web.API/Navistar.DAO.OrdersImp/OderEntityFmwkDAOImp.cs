using Navistar.DAO.Orders;
using Navistar.Model.common;
using Navistar.DataContext;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Navistar.DataContext.Seed;

namespace Navistar.DAO.OrdersImp
{
    public class OderEntityFmwkDAOImp : Repository<TCP001_PEDIDO>, IOrderEFDAO
    {
        private readonly DBDataMartEntityFmwImp _dbContext;

        public OderEntityFmwkDAOImp(DBDataMartEntityFmwImp dbContext)
            : base(dbContext)
            => _dbContext = dbContext;

    }
}
