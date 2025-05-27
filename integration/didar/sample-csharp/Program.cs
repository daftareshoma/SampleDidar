
using Azm.Logging.Serilog;
using Sample.Didar.Api;

var builder = WebApplication.CreateBuilder(args);
var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);
builder.WebHost.UseSerilogHelper();
var app = builder.Build();
startup.Configure(app, app.Environment);
app.Run();