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
    [Route("orders/")]
    public class OrdersController : ControllerBase
    {
        OrdersService ordersService;
        public OrdersController(OrdersService ordersService)
        {
            this.ordersService = ordersService;
        }

        // Validate the user request/input - validated that the values are legal/exist
        // Transform the service request
        //The controller should return 200/OK in case of a valid request and response
        //The controller should return 400/Bad request in case of invalid date
        //The controller should return 500/in case of internal server error for example the DB was inaccsisble 

        [HttpGet] 
        public IEnumerable<OrderRecord> Get(string date = null)
        {
            var dateTime = DateTime.Parse(date);
            var orderReponse = ordersService.GetOrders(dateTime);
            var orderResponseDTO = ordersResponseDTOTransformer.transform(orderReponse);
            return orderResponseDTO;
        }

    }
}