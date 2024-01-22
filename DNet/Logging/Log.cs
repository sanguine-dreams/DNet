using Microsoft.Extensions.Logging;

namespace DNet.Logging;

public class Log : ILog
{
    private readonly ILogger _logger;

    public Log(ILogger logger)
    {
        _logger = logger;
    }

    public void Info(string message)
    {
        _logger.LogInformation("Hello from Log, message = " + message);
    }
}
