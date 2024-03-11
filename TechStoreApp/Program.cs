using TechStoreApp.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAppDatabase(builder.Configuration);
builder.Services.AddAppIdentity();
builder.Services.AddAppMVC();
builder.Services.AddAppMVCRouting();
builder.Services.AddAppServices();

var app = builder.Build();

app.ConfigurePipeline();

app.Run();
