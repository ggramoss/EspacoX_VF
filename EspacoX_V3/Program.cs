using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EspacoX_V3.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<EspacoX_V3Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EspacoX_V3Context") ?? throw new InvalidOperationException("Connection string 'EspacoX_V3Context' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
