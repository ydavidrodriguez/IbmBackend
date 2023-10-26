using Algar.Hours.Api;
using Algar.Hours.Common;
using Algar.Hours.External;
using Algar.Hours.Persistence;
using Algar.Hours.Application;


var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddWebApi()
    .AddCommon()
    .AddExternal(builder.Configuration)
    .AddPersistence(builder.Configuration)
    .AddApplication();

builder.Services.AddControllers();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
}
);

app.MapControllers();
app.Run();


