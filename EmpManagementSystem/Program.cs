using EmpManagementSystem.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add DbContext to the DI container with SQL Server connection
builder.Services.AddDbContext<EmployeeDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container for MVC (Controllers + Views)
builder.Services.AddControllersWithViews();  // Add support for Razor views (if you need to render dynamic views later)

// Add services to the container (API controllers)
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Configure the HTTP request pipeline

// Enable HTTPS Redirection
app.UseHttpsRedirection();

// Enable Static file serving (for index.html and other static assets)
app.UseStaticFiles();

// Enable Authorization
app.UseAuthorization();

// Add routing for controllers and views
app.MapControllers();

// Define the default route for serving index.html
app.MapGet("/employees", async context =>
{
    var env = context.RequestServices.GetRequiredService<IWebHostEnvironment>();
    var pathToFile = Path.Combine(env.WebRootPath, "index.html");
    if (File.Exists(pathToFile))
    {
        context.Response.ContentType = "text/html";
        await context.Response.SendFileAsync(pathToFile);
    }
    else
    {
        context.Response.StatusCode = 404;
        await context.Response.WriteAsync("File not found.");
    }
});

app.Run();
