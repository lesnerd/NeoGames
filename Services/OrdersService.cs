using System;
using System.Collections.Generic;
using NeoGames.DAL;
using NeoGames.DAL.Entities;
using NeoGames.Services.Entities;

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
        public OrdersResponse GetOrders(DateTime date)
        {
            var orders = ordersDAO.GetOrders(date);
            return new OrdersResponse(orders, DateTime.Now);
        }
    }
}