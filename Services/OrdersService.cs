using System.Collections.Generic;
using NeoGames.DAL;
using NeoGames.DAL.Entities;

namespace NeoGames.Services
{
    // Should take care of the bussiness logic
    public class OrdersService
    {
        OrdersDAOStub ordersDAO;
        public OrdersService(OrdersDAOStub ordersDAO)
        {
            
        }
        public IEnumerable<OrderRecord> GetOrders()
        {
            return ordersDAO.GetOrders(5, 0);
        }
    }
}