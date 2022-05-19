using System.Threading.Tasks;

namespace Abp.Test.SampleDomain;

public interface ISampleAppService
{
    Task PublishEvent();
}