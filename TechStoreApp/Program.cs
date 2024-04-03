using TechStoreApp.Config;
using TechStoreApp.Handlers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAppDatabase(builder.Configuration);
builder.Services.AddAppIdentity();
builder.Services.AddAppMVC();
builder.Services.AddAppMVCRouting();
builder.Services.AddAppCoreAdmin();
builder.Services.AddAppServices();
builder.Services.AddAppAutoMapper();
builder.Services.AddSignalR();
builder.Services.AddAppCors(builder.Configuration);

builder.Services.AddExceptionHandler<NotFoundExceptionHandler>();

var app = builder.Build();

app.ConfigurePipeline();

app.Run();

