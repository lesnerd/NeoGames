using System;
using System.Collections.Generic;
using NeoGames.DAL;
using NeoGames.DAL.Entities;

namespace NeoGames.Services
{
    // Should take care of the bussiness logic
    public class OrdersService
    {
        private OrdersDAOStub ordersDAO;
        public OrdersService(OrdersDAOStub ordersDAO)
        {
            this.ordersDAO = ordersDAO;
        }
        public IEnumerable<OrderRecord> GetOrders(DateTime date)
        {
            return ordersDAO.GetOrders(date);
        }
    }
}