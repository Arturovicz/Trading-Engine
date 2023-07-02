using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingEngineServer.Orders;

namespace TradingEngineServer.Orderbook
{
    public interface IRetrievalOrderbook : IOrderEntryOrderbook
    {
        List<OrderbookEntry> GetAskOrders();
        List<OrderbookEntry> GetBidOrders();
    }
}
