using Microsoft.EntityFrameworkCore;
using PropertyRentalAPI.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<PropertyRentalContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PropertyRentalConnection")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<PropertyRentalContext>();
    try
    {
        dbContext.Database.CanConnect();
        Console.WriteLine("Подключение к БД успешно установлено");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибка подключения к БД: {ex.Message}");
    }
}


app.Run();
