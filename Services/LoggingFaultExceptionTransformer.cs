using System.ServiceModel.Channels;
using System.Xml;
using SoapCore.Extensibility;

public class LoggingFaultExceptionTransformer : IFaultExceptionTransformer
{
    private readonly ILogger<LoggingFaultExceptionTransformer> _logger;

    public LoggingFaultExceptionTransformer(ILogger<LoggingFaultExceptionTransformer> logger)
    {
        _logger = logger;
    }

    public Message ProvideFault(Exception error, MessageVersion version, Message fault, XmlNamespaceManager nsManager)
    {
        _logger.LogError("SOAP Fault occurred: {ErrorMessage}", error.Message);
        _logger.LogError("Fault Message: {FaultMessage}", fault.ToString());
        return fault;
    }
}
