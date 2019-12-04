
using System;
using System.Collections.Generic;

namespace NeoGames.DAL.Entities
{
    public class OrdersRecordResponse
    {
        public IEnumerable<OrderRecord> orders { get; set; }
        public DateTime nextOrderDate { get; set; }
    }

}