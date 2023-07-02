using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingEngineServer.Logging
{
    public interface ITraceLogger : ILogger, IDisposable
    {
    }
}
