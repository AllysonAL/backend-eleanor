using Interface.Menu;
using Interface.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using static Infra.DependencyInjection.InfrastructureServiceCollectionExtensions;

var builder = Host.CreateApplicationBuilder();
builder.Services.AdicionarContext(builder.Configuration);
builder.Services.AddInterfaceServices();
builder.Build();

var serviceProvider = builder.Services.BuildServiceProvider();
serviceProvider.GetRequiredService<GerenciadorMenu>().Executar();