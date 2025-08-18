using Lab02CustomerWebAPI.Data;
using Lab02CustomerWebAPI.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration
                 .GetConnectionString("KlinelocaldbConnection");

builder.Services.AddDbContext<KlineAppDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

//builder.Services.AddSingleton<ICustomerRepository, CustomerInMemoryRepository>();
builder.Services.AddScoped<ICustomerRepository, CustomerDbRepository>();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
