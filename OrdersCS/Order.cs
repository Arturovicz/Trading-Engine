using OrdersCS;

using System;
using System.Threading.Tasks;

namespace TradingEngineServer.Orders
{
    public class Order : IOrderCore
    {
        public Order(IOrderCore orderCore, long price, uint quantity, bool isBuySide) 
        {
            Price = price;
            IsBuySide = isBuySide;
            InitialQuantity = quantity;
            CurrentQuantity = quantity;
            _orderCore = orderCore;
        }  

        public Order(ModifyOrder modifyOrder) : 
            this(modifyOrder, modifyOrder.Price, modifyOrder.Quantity, modifyOrder.IsBuySide) 
        {
            
        }

        public long Price { get; private set; }
        public uint CurrentQuantity { get; private set; }
        public uint InitialQuantity { get; private set; }
        public bool IsBuySide { get; private set; }

        

        long IOrderCore.OrderId => _orderCore.OrderId;
        string IOrderCore.Username => _orderCore.Username;
        int IOrderCore.SecurityId => _orderCore.SecurityId;

        /*
        long OrderId => _orderCore.OrderId;
        string Username => _orderCore.Username;
        int SecurityId => _orderCore.SecurityId;
        */
        public void IncreaseQuantity(uint quantityDelta) 
        {
            CurrentQuantity += quantityDelta;
        }

        public void DecreaseQuantity(uint quantityDelta)
        {   
            if (quantityDelta > CurrentQuantity)
            {
                throw new InvalidOperationException($"Quantity Delta > Corrent Quantity for OrderID={OrderId}");
            }
            CurrentQuantity -= quantityDelta;
        }

        private readonly IOrderCore _orderCore;

    }
}
