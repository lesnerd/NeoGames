using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NeoGames.DAL.Entities;
using NeoGames.Services;

namespace NeoGames.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        OrdersService ordersService;
        public OrdersController(OrdersService ordersService)
        {
            this.ordersService = ordersService;
        }

        // Validate the user request/input - validated that the values are legal/exist
        // Transform the service request
        // TODO: which one ot use???
        //[HttpGet("{date}")]
        [HttpGet]
        public IEnumerable<OrderRecord> Get(string date)
        {
            var dateTime = DateTime.Parse(date);
            return ordersService.GetOrders(dateTime);
        }

    }
}