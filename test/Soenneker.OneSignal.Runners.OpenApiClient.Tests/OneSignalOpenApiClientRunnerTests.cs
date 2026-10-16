using Soenneker.Tests.HostedUnit;

namespace Soenneker.OneSignal.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class OneSignalOpenApiClientRunnerTests : HostedUnitTest
{
    public OneSignalOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
