using NeoGames.Controllers.Entities;
using NeoGames.Services.Entities;

namespace NeoGames.Contracts
{
    public interface IOrderResponseDTOTransformer
    {
        OrdersResponseDTO Transform(OrdersResponse ordersResponse);
    }
}
