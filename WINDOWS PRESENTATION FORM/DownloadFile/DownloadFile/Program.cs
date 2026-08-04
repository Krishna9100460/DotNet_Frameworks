using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DownloadFile.Data;
using DownloadFile.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DownloadFileContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DownloadFileContext") ?? throw new InvalidOperationException("Connection string 'DownloadFileContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

using(var scope=app.Services.CreateScope())
{
    var services=scope.ServiceProvider;
    SeedData.Initialize(services);
}
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/HelloWorld/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=HelloWorld}/{action=Index}/{id?}");

app.Run();
