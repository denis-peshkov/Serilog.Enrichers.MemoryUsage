namespace Serilog.Extensions;

/// <summary>
///   Extension methods for setting up client IP, client agent and correlation identifier enrichers <see cref="LoggerEnrichmentConfiguration"/>.
/// </summary>
public static class MemoryUsageLoggerConfigurationExtensions
{
    /// <summary>
    ///   Registers the memory enricher to enrich logs with used memory in process.
    /// </summary>
    /// <exception cref="ArgumentNullException">enrichmentConfiguration</exception>
    /// <returns>The logger configuration so that multiple calls can be chained.</returns>
    public static LoggerConfiguration WithMemory(
        this LoggerEnrichmentConfiguration enrichmentConfiguration)
    {
        if (enrichmentConfiguration == null)
        {
            throw new ArgumentNullException(nameof(enrichmentConfiguration));
        }

        return enrichmentConfiguration.With(new MemoryEnricher());
    }
}
