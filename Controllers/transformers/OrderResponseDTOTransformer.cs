using NeoGames.Controllers.Entities;
using NeoGames.Services.Entities;

namespace NeoGames.Controllers.Transformers
{
    public class OrderResponseDTOTransformer
    {
        public OrdersResponseDTO Transform(OrdersResponse ordersResponse)
        {
            return new OrdersResponseDTO(ordersResponse.orders, ordersResponse.nextIndex);
        }
    }
}