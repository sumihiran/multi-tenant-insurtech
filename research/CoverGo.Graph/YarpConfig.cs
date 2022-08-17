using Yarp.ReverseProxy.Configuration;

namespace CoverGo.Graph;

internal sealed class YarpConfig
{
    private static readonly IReadOnlyList<RouteConfig> Routes = new[]
    {
        new RouteConfig()
        {
            RouteId = "route1",
            ClusterId = "cluster1",
            Match = new RouteMatch
            {
                Path = "/covergo/{**catch-all}"
            },
            Transforms = new []
            {
                new Dictionary<string, string>()
                {
                    {"PathPattern", "/{**catch-all}"}
                }
            }
        }
    };

    private static readonly IReadOnlyList<ClusterConfig> Clusters = new[]
    {
        new ClusterConfig()
        {
            ClusterId = "cluster1",
            Destinations = new Dictionary<string, DestinationConfig>(StringComparer.OrdinalIgnoreCase)
            {
                { "destination1", new DestinationConfig()
                {
                    Address = "https://api.covergo.com"
                } }
            }
        }
    };

    public static IProxyConfigProvider Provider => new InMemoryConfigProvider(Routes, Clusters);
}