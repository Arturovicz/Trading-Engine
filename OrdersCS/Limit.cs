using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingEngineServer.Orders
{
    public class Limit
    {
        public long Price { get; set; }
        public OrderbookEntry Head { get; set; }
        public OrderbookEntry Tail { get; set; }
        public uint GetLevelOrderCount()
        {
            uint orderCount = 0;
            OrderbookEntry headPointer = Head;
            while (headPointer != null)
            {
                if (headPointer.CurrentOrder.CurrentQuantity != 0)
                {
                    orderCount++;
                }
                headPointer = headPointer.Next;
                
            }
            return orderCount;
        }

        public uint GetLevelOrderQuantity()
        {
            uint orderQuntity = 0;
            OrderbookEntry headPointer = Head;
            while (headPointer != null)
            {
                orderQuntity += headPointer.CurrentOrder.CurrentQuantity;
                headPointer = headPointer.Next;
            }
            return orderQuntity;
        }




        public bool IsEmpty
        {
            get{return Head == null && Tail == null;}
        }
        public Side Side 
        {
            get
            {
                if (IsEmpty)
                {
                    return Side.Unkown;
                }
                else
                {
                    return Head.CurrentOrder.IsBuySide ? Side.Bid : Side.Ask;
                }
            }
            

        }
    }
}
