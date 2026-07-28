using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Smart_Inventory_Management_System.Repositories;
using Tech_Inventory_Management_System.Data;
using Tech_Inventory_Management_System.Interfaces.Repositories;
using Tech_Inventory_Management_System.Interfaces.Services;
using Tech_Inventory_Management_System.Middleware;
using Tech_Inventory_Management_System.Repositories;
using Tech_Inventory_Management_System.Services;

var builder = WebApplication.CreateBuilder(args);

// Add Controllers
builder.Services.AddControllers();

// Register Dependency Injection
builder.Services.AddSingleton<ICategoryRepository, InMemoryCategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

// Swagger
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