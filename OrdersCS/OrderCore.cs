using OrdersCS;

using System;
using System.Globalization;
using System.Threading.Tasks;

namespace TradingEngineServer.Orders
{
    public class OrderCore : IOrderCore
    {
        public OrderCore(long orderId, string username, int securityId) 
        {
            OrderId = orderId;
            Username = username;
            SecurityId = securityId;
        }


        public long OrderId { get; private set; }
        public int SecurityId { get; private set; }
        public string Username { get; private set; }
    }
}
