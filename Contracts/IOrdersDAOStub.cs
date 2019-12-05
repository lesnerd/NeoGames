using System;
using NeoGames.DAL.Entities;

namespace NeoGames.Contracts
{
    public interface IOrdersDAOStub
    {
        OrdersRecordResponse GetOrders(DateTime date, int bulkSize);
    }
}