using System;
using System.Collections.Generic;
using NeoGames.DAL.Entities;

namespace NeoGames.Services.Entities
{
    public class OrdersResponse
    {
        public OrdersResponse(OrdersRecordResponse ordersResponse)
        {
            this.orders = ordersResponse.orders;
            this.nextIndex = ordersResponse.nextOrderDate;
        }
        public IEnumerable<OrderRecord> orders;
        public DateTime nextIndex;
         
    }
}