using Microsoft.EntityFrameworkCore;
using WebShoppie.Domain.Services.Customers;
using WebShoppie.Domain.Services.Orders;
using WebShoppie.Domain.Services.Products;
using WebShoppie.Storage;
using WebShoppie.Storage.Interfaces;
using WebShoppie.Storage.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<WebShoppieDbContext>(
    optionsBuilder => optionsBuilder.UseNpgsql(
        builder.Configuration.GetConnectionString(
            "Gent")) );

builder.Services.AddControllers();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
// AddSingleton - 1 object instantie die hergebruikt wordt zolang
// server runt voor elke vermelding interface in constructor
// AddScoped() - 1 instantie die hergebruikt wordt voor elke vermelding
// gedurende dit http request
// AddTransient() - elke keer interface vermeld wordt in constructor
// een nieuwe instantie


var app = builder.Build();
app.MapControllers();

app.Run();

