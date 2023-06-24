using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingEngineServer.Logging
{
    public interface ILogger
    {

        void Debug(string module, string message);
        void Information(string module, string message);
        void Warning(string module, string message);
        void Error(string module, string message);

        void Debug(string module, Exception exception);
        void Information(string module, Exception exception);
        void Warning(string module, Exception exception);
        void Error(string module, Exception exception);
    }
}
