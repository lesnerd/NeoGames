using System;
using System.Collections.Generic;
using NeoGames.DAL.Entities;

namespace NeoGames.Services.Entities
{
    public class OrdersResponse
    {
        public OrdersResponse(IEnumerable<OrderRecord> orders, DateTime date)
        {
            this.orders = orders;
            this.nextIndex = date;
        }
        public IEnumerable<OrderRecord> orders;
        public DateTime nextIndex;
         
    }
}