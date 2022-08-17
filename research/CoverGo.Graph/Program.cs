using CoverGo.Graph;
using GraphQL.Server.Ui.Voyager;
using Yarp.ReverseProxy.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddReverseProxy();
builder.Services.AddSingleton<IProxyConfigProvider>(YarpConfig.Provider);


var app = builder.Build();
app.UseDeveloperExceptionPage();
app.MapReverseProxy();
app.UseGraphQLVoyager("/ui/voyager", new VoyagerOptions()
{
    GraphQLEndPoint = "/covergo/graphql"
});

await app.RunAsync();