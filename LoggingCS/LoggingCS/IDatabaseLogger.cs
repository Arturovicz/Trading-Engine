using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TradingEngineServer.Logging
{
    public interface IDatabaseLogger: ILogger, IDisposable
    {
    }
}
