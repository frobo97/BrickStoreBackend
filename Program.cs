using BrickStoreBackend.Data;
using BrickStoreBackend.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Register DbContext for DI with SQLite configuration
builder.Services.AddDbContext<DbContextSqLite>(options =>
    options.UseSqlite("Data Source=brickstore.db"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// Adding a new product to the database manually
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<DbContextSqLite>();
    
    // Add a new product
    var newProduct = new BrickProduct("Test Product", "This is a test product.");
    context.BrickProducts.Add(newProduct);
    
    // Save the changes to the database
    context.SaveChanges();
    
    Console.WriteLine("Product added to the database.");
}

app.Run();
