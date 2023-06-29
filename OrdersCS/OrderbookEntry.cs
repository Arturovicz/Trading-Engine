using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingEngineServer.Orders
{

    public class OrderbookEntry
    {
        public OrderbookEntry(Order currentOrder, Limit parentLimit) 
        {
            CreationTime = DateTime.UtcNow;
            ParentLimit = parentLimit;
            CurrentOrder = currentOrder;
        }

        public DateTime CreationTime { get; private set; }
        public Order CurrentOrder { get; private set; }         // normally, it is preferable to put 'init' instead of 'private set'
        public Limit ParentLimit { get; private set; }
        public OrderbookEntry Next { get;  set; }
        public OrderbookEntry Previous { get;  set; }

    }
}
