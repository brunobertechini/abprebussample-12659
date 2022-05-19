using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Abp.Test;

[Dependency(ReplaceServices = true)]
public class TestBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Test";
}
