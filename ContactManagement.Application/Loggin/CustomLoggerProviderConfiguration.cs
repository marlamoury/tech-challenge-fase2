using Microsoft.Extensions.Logging;

namespace ContactManagement.Application.Loggin;

public class CustomLoggerProviderConfiguration
{
    public LogLevel LogLevel { get; set; } = LogLevel.Warning;
    public int EventId { get; set; } = 0;
}