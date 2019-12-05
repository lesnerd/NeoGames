using System;
using NeoGames.Services.Entities;

namespace NeoGames.Contracts
{
    public interface IOrdersService
    {
        OrdersResponse GetOrders(DateTime date, int bulkSize);
    }
}