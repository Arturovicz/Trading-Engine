using OrdersCS;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingEngineServer.Orders;

namespace TradingEngineServer.Rejects
{
    public class Reject : IOrderCore
    {
        public Reject(IOrderCore rejectedOrder, RejectionReason rejectionReason)
        {
            RejectionReason = rejectionReason;

            _orderCore = rejectedOrder;
        }


        public RejectionReason RejectionReason { get; private set; }




        public long OrderId => _orderCore.OrderId;
        public string Username => _orderCore.Username;
        public int SecurityId => _orderCore.SecurityId;


        private readonly IOrderCore _orderCore;
    }
}
