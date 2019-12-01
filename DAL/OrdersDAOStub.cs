using System.Collections.Generic;
using System;
using NeoGames.DAL.Entities;

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
            
        }

        // Should implement CRUD of the database table
        // Reason for the params (fitering) so the dal layer is not wasteful
        public IEnumerable<OrderRecord> GetOrders(int nubmerOfItems, int index)
        {
            return records;
        }
    }
}