using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container. (Services, things we want to inject into other classes.)
builder.Services.AddControllers();
builder.Services.AddDbContext<StoreContext>(opt =>
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnect"));
});

// Build  the application.
var app = builder.Build();

// Middleware. Software that interacts with incoming and outgoing requests. 
app.MapControllers();

app.Run();