using System.Collections.Generic;
using System;
using NeoGames.DAL.Entities;
using System.Linq;

namespace NeoGames.DAL
{
    public class OrdersDAOStub
    {
        private IList<OrderRecord> records = new List<OrderRecord>()
        {
            new OrderRecord(1, 1, DateTime.Parse("2019-11-26 16:09:32.123")),
            new OrderRecord(2, 5, DateTime.Parse("2019-11-26 16:09:32.111")),
            new OrderRecord(3, 56, DateTime.Parse("2019-11-26 16:10:32.222")),
            new OrderRecord(4, 22, DateTime.Parse("2019-11-26 16:10:35.555")),
            new OrderRecord(5, 154.5m, DateTime.Parse("2019-11-26 16:11:00.555"))
        };
        public OrdersDAOStub()
        {
            records.OrderBy(r => r.PurchaseDate);
        }

        // Should implement CRUD to/from database
        // Reason for the parameters is fitering, so that the dal layer is not wasteful
        public OrdersRecordResponse GetOrders(DateTime date, int bulkSize)
        {
            OrdersRecordResponse response = new OrdersRecordResponse();
            IList<OrderRecord> filteredOrders = new List<OrderRecord>();
            foreach(var order in records)
            {
                if(bulkSize == 0)
                {
                    response.orders = filteredOrders;
                    response.nextOrderDate = order.PurchaseDate;
                    return response;
                }
                if(date == null)
                    continue;
                if(order.PurchaseDate < date)
                    continue;
                filteredOrders.Add(order);
                bulkSize--;
            }
            response.orders = filteredOrders;
            response.nextOrderDate = DateTime.MinValue;
            return response;
        }
    }
}