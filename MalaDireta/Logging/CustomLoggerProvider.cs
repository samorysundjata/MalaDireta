using System.Collections.Concurrent;

namespace MalaDireta.Logging
{
    public class CustomLoggerProvider : ILoggerProvider
    {
        readonly CustomLoggingProviderConfiguration loggerConfig;

        readonly ConcurrentDictionary<string, CustomerLogger> loggers =
                 new ConcurrentDictionary<string, CustomerLogger>();

        public CustomLoggerProvider(CustomLoggingProviderConfiguration config)
        {
            loggerConfig = config;
        }

        ILogger ILoggerProvider.CreateLogger(string categoryName)
        {
            return loggers.GetOrAdd(categoryName, name => new CustomerLogger(name, loggerConfig));
        }

        public void Dispose()
        {
            loggers.Clear();
        }
    }
}
