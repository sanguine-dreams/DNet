using DNet.Logging;
using Microsoft.Extensions.Logging;

// register logger (console)
// https://learn.microsoft.com/en-us/dotnet/core/extensions/logging?tabs=command-line
using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
ILogger logger = factory.CreateLogger("DNet");

// DI : inject ILogger
var log = new Log(logger);

// print info using ILogger
log.Info("Ali Hassan");

