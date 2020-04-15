using Microsoft.Extensions.Logging;

namespace Sealside.Crosscutting.Logging
{
    public static class LoggerExtensions 
    {
        public static ILoggerFactory AddFile(this ILoggerFactory factory,
            string filePath)
        {
            factory.AddProvider(new LoggerProvider(filePath));
            return factory;
        }
    }
}
