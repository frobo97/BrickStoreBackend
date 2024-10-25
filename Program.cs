using BrickStoreBackend.Data;
using BrickStoreBackend.Models;
using BrickStoreBackend.Repository;
using Microsoft.EntityFrameworkCore;
using BrickStoreBackend.Service;

var builder = WebApplication.CreateBuilder(args);

// Register DbContext for DI with SQLite configuration
builder.Services.AddDbContext<DbContextSqLite>(options =>
    options.UseSqlite("Data Source=brickstore.db"));

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IUserRepository , UserRepository>();
// builder.Services.AddScoped<IUserSe>()


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// Adding a new product to the database manually
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<DbContextSqLite>();
    var productService = scope.ServiceProvider.GetRequiredService<IProductService>();

    // Add a new product
    var newProduct = new BrickProduct("Test Product", "This is a test product.", 20);
    // context.BrickProducts.Add(newProduct);
    var productFromDb = productService.GetProductById(10);
    productFromDb.Name = "Test Product updated";
    if (productService.UpdateProduct(productFromDb))
    {
        Console.WriteLine("_________________Product updated___________________________________");
    }

    // Save the changes to the database
    // context.SaveChanges();
    Console.WriteLine("Product added to the database.");
}

app.Run();