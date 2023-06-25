using OrdersCS;

using System;
using System.Threading.Tasks;

namespace TradingEngineServer.Orders
{
    public class ModifyOrder : IOrderCore
    {
        public ModifyOrder(IOrderCore orderCore, long modifyPrice, uint modifyQuantity, bool isBuySide) 
        {
            Price = modifyPrice;
            Quantity = modifyQuantity;
            IsBuySide = isBuySide;

            _orderCore = orderCore;
        }

        public long OrderId => _orderCore.OrderId;
        public string Username => _orderCore.Username;
        public int SecurityId => _orderCore.SecurityId;

        public long Price { get; private set; }
        public uint Quantity{ get; private set; }
        public bool IsBuySide{ get; private set; }


        public CancelOrder ToCancelOrder()
        {
            return new CancelOrder(this);
        }

        public Order ToNewOrder()
        {
            return new Order(this);
        }


        private readonly IOrderCore _orderCore;
    }
}
