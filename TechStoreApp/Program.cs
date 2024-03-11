using TechStoreApp.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAppDatabase(builder.Configuration);
builder.Services.AddAppIdentity();
builder.Services.AddAppMVC();
builder.Services.AddAppMVCRouting();
builder.Services.AddAppCoreAdmin();
builder.Services.AddAppServices();
builder.Services.AddAppAutoMapper();

var app = builder.Build();

app.ConfigurePipeline();

app.Run();
