using System.Threading.Tasks;
using Volo.Abp.EventBus.Distributed;

namespace Abp.Test.SampleDomain;

public class SampleAppService: TestAppService, ISampleAppService
{
    private readonly IDistributedEventBus _bus;

    private const bool OnUnitOfWorkComplete = true;
    private const bool UseOutbox = true;
    
    public SampleAppService(
        IDistributedEventBus bus)
    {
        _bus = bus;
    }
    
    public async Task PublishEvent()
    {
        await _bus.PublishAsync(new SampleEvent1()
        {
            MyStringProp1 = "test"
        });
        
        await _bus.PublishAsync(new SampleEvent2()
        {
            MyStringProp1 = "test"
        });
    }
}