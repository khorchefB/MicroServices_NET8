var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


// Configure the HTTP request pipeline.
builder.Services
    .AddApplicationServices(builder.Configuration)
    .AddInfrastructureServices(builder.Configuration)
    .AddApiServices(builder.Configuration);

var app = builder.Build();
app.UseApiServices();
if (app.Environment.IsDevelopment())
{
    await app.InitilaliseDataBase();
}
app.Run();

