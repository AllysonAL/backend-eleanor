using Microsoft.Extensions.Hosting;
using static Infra.DependencyInjection.InfrastructureServiceCollectionExtensions;

var builder = Host.CreateApplicationBuilder();
builder.Services.AdicionarContext(builder.Configuration);