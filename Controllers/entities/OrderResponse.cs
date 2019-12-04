using System;
using System.Collections.Generic;
using NeoGames.DAL.Entities;

namespace NeoGames.Controllers.Entities
{
    public class OrdersResponseDTO
    {
        public OrdersResponseDTO(IEnumerable<OrderRecord> orders, DateTime nextIndex)
        {
            this.orders = orders;
            this.nextIndex = nextIndex;
        }
        public IEnumerable<OrderRecord> orders;
        public DateTime nextIndex;
         
    }
}