using System;
using System.Text;
using System.Threading.Tasks;

namespace TradingEngineServer.Orders
{
    public record OrderRecord(long OrderId, uint Quantity, long Price, string Username, 
                              bool IsBuySide, int SecurityId, uint TheoreticalQueuePosition);
    
}
