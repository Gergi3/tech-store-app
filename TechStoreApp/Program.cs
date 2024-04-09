using TechStoreApp.Config;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddServices(builder.Configuration);

var app = builder.Build();
app.ConfigurePipeline();
app.Run();

