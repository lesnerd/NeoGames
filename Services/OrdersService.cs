using System;
using System.Data;
using NeoGames.DAL;
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
        public OrdersResponse GetOrders(DateTime date, int bulkSize)
        {
            try
            {
                var orders = ordersDAO.GetOrders(date, bulkSize);
                return new OrdersResponse(orders);
            }
            catch (System.Exception)
            {
                throw new DataException();
            }
 
        }
    }
}