using System;
using System.Threading.Tasks;

namespace TradingEngineServer.Orderbook
{
    public interface IReadOnlyOrderbook
    {
        bool ContainsOrder(long orderId);
        OrderbookSpread GetSpread(long orderId);
        int Count();
    }
}
