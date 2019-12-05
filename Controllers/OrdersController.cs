using System;
using System.Net.Mime;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeoGames.Contracts;
using NeoGames.Controllers.Entities;
using NeoGames.Controllers.Transformers;
using NeoGames.Services;

namespace NeoGames.Controllers
{
    [ApiController]
    [Route("orders/")]
    public class OrdersController : ControllerBase
    {
        IOrdersService ordersService;
        IOrderResponseDTOTransformer ordersResponseDTOTransformer;
        public OrdersController(IOrdersService ordersService, IOrderResponseDTOTransformer ordersResponseDTOTransformer)
        {
            this.ordersService = ordersService;
            this.ordersResponseDTOTransformer = ordersResponseDTOTransformer;
        }

        // Validate the user request/input - validated that the values are legal/exist
        // Transform the service request
        //The controller should return 200/OK in case of a valid request and response
        //The controller should return 400/Bad request in case of invalid date
        //The controller should return 500/in case of internal server error for example the DB was inaccessible 

        [HttpGet] 
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<OrdersResponseDTO> Get(string date = null, int bulkSize = 5)
        {
            if(bulkSize < 0 || bulkSize >= int.MaxValue / 10)
                return BadRequest("Bulksize is invalid!");
            var dateTime = DateTime.Parse(date);
            try
            {
                var orderReponse = ordersService.GetOrders(dateTime, bulkSize);
                var orderResponseDTO = ordersResponseDTOTransformer.Transform(orderReponse); 
                return Ok(orderResponseDTO);
            }
            catch(Exception e)
            {
                return StatusCode(500, "Ops, something went wrong...");
            }
        }

    }
}