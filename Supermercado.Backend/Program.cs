using Microsoft.EntityFrameworkCore;
using Supermercado.Abstractions.Interfaces;
using Supermercado.Data.EF;
using Supermercado.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("CONNECTIONSTRING");
var serverVersion = new MySqlServerVersion(new Version(8, 0, 31));
builder.Services.AddDbContext<SupermercadoDBContext>(options =>
options.UseMySql(connectionString, serverVersion));

// Add services to the container.
builder.Services.AddScoped<IProductoRepository, ProductoRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
