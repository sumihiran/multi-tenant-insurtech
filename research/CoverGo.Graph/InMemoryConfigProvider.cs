using Microsoft.Extensions.Primitives;
using Yarp.ReverseProxy.Configuration;

namespace CoverGo.Graph;

public class InMemoryConfigProvider : IProxyConfigProvider
{
    private readonly InMemoryConfig _config;

    public InMemoryConfigProvider(IReadOnlyList<RouteConfig> routes, IReadOnlyList<ClusterConfig> clusters)
    {
        _config = new InMemoryConfig(routes, clusters);
    }

    public IProxyConfig GetConfig() => _config;

    private class InMemoryConfig : IProxyConfig
    {

        public InMemoryConfig(IReadOnlyList<RouteConfig> routes, IReadOnlyList<ClusterConfig> clusters)
        {
            Routes = routes;
            Clusters = clusters;
            ChangeToken = new CancellationChangeToken(new CancellationToken());
        }

        public IReadOnlyList<RouteConfig> Routes { get; }

        public IReadOnlyList<ClusterConfig> Clusters { get; }
        public IChangeToken ChangeToken { get; }
    }
}