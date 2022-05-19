using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EventBus.Distributed;

namespace Abp.Test.SampleDomain;

public class SampleEventHandler: ITransientDependency,
    IDistributedEventHandler<SampleEvent1>, 
    IDistributedEventHandler<SampleEvent2>
{
    private readonly ILogger<SampleEventHandler> _logger;
    private readonly IDistributedEventBus _bus;

    public SampleEventHandler(ILogger<SampleEventHandler> logger, IDistributedEventBus bus)
    {
        _logger = logger;
        _bus = bus;
    }    
    
    public Task HandleEventAsync(SampleEvent1 eventData)
    {
        _logger.LogInformation($"Received Event {eventData.GetType().FullName}");

        var a = _bus;
        
        Thread.Sleep(10000);
        
        _logger.LogInformation($"Finished processing Event {eventData.GetType().FullName}");
        
        return Task.CompletedTask;
    }

    public Task HandleEventAsync(SampleEvent2 eventData)
    {
        _logger.LogInformation($"Received Event {eventData.GetType().FullName}");

        var a = _bus;
        
        Thread.Sleep(10000);
        
        _logger.LogInformation($"Finished processing Event {eventData.GetType().FullName}");
        
        return Task.CompletedTask;
    }
}