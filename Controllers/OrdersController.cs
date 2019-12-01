using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
            
        }

    }
}