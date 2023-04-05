using Microsoft.Extensions.DependencyInjection;
using OhceKata;
using Console = OhceKata.Console;

var ServiceCollection = new ServiceCollection();
ServiceCollection.AddTransient<IGreeter, Greeter>();
ServiceCollection.AddTransient<IDateTime, DateTimeProvider>();
ServiceCollection.AddTransient<IConsole, Console>();
ServiceCollection.AddTransient<IDateTime, DateTimeProvider>();
ServiceCollection.AddTransient<IEchoGenerator, EchoGenerator>();
var services = ServiceCollection.BuildServiceProvider();

var app = new OhceApp(args[0], services.GetRequiredService<IConsole>(), services.GetRequiredService<IGreeter>(), services.GetRequiredService<IEchoGenerator>());
app.Start();

