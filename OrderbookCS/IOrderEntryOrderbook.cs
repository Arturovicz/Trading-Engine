using System;
using System.Threading.Tasks;
using TradingEngineServer.Orders;

namespace TradingEngineServer.Orderbook
{
    public interface IOrderEntryOrderbook : IReadOnlyOrderbook
    {
        void AddOrder(Order order);
        void ChangeOrder(ModifyOrder modifyOrder);
        void RemoveOrder(CancelOrder cancelOrder);
    }
}
