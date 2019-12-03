using System;
using System.Collections.Generic;
using NeoGames.DAL.Entities;

namespace NeoGames.Controllers.entities
{
    public class OrdersResponseDTO
    {
        public IEnumerable<OrderRecord> orders;
        public DateTime nextIndex;
         
    }
}