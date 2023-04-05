using Microsoft.Extensions.DependencyInjection;
using OhceKata;
using Console = OhceKata.Console;

var ServiceCollection = new ServiceCollection();
ServiceCollection.AddTransient<IGreeter, Greeter>();
ServiceCollection.AddTransient<IDateTime, DateTimeProvider>();
ServiceCollection.AddTransient<IConsole, Console>();
ServiceCollection.AddTransient<IDateTime, DateTimeProvider>();
ServiceCollection.AddTransient<IEchoGenerator, EchoGenerator>();
ServiceCollection.AddTransient<OhceApp>();
var services = ServiceCollection.BuildServiceProvider();

var app = services.GetRequiredService<OhceApp>();
app.Start(args[0]);

