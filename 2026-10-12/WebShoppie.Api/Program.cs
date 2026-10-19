using WebShoppie.Domain.Services.Customers;
using WebShoppie.Storage.Customers;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddSingleton<ICustomerRepository, CustomerRepository>();
// AddSingleton - 1 object instantie die hergebruikt wordt zolang
// server runt voor elke vermelding interface in constructor
// AddScoped() - 1 instantie die hergebruikt wordt voor elke vermelding
// gedurende dit http request
// AddTransient() - elke keer interface vermeld wordt in constructor
// een nieuwe instantie


var app = builder.Build();
app.MapControllers();

app.Run();

