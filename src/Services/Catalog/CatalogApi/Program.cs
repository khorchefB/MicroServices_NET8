var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCarter();

builder.Services.AddMarten((options) =>
{
    options.Connection(builder.Configuration.GetConnectionString("DataBase")!);
}).UseLightweightSessions();

builder.Services.AddMediatR((config) =>
{
    config.RegisterServicesFromAssemblies(typeof(Program).Assembly);
});
// Add services to the container 

var app = builder.Build();
app.MapCarter();

app.Run();
