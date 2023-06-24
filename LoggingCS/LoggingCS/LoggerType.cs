using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingEngineServer.Logging
{
    public enum LoggerType
    {
        //Only TextLogger will be implemented 
        Text,
        Database,
        Console,
        Trace
    }
}
