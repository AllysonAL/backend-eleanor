using Microsoft.Extensions.Hosting;
using static Infra.DependencyInjection.InfrastructureServiceCollectionExtensions;

var builder = Host.CreateApplicationBuilder();
builder.Services.AdicionarContext(builder.Configuration);

//nome do projeto em letra minúscula 