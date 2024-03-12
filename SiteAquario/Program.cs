using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SiteAquario.Models;
//using SiteAquario.Data;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<SiteAquarioContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("SiteAquarioContext") ?? throw new InvalidOperationException("Connection string 'SiteAquarioContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Contexto>(options => options.UseSqlServer("Server=<LocalHost>\\SQLEXPRESS;DataBase = bd_aquario; Trusted_Connection = True; User ID=Admin; Password=Admin"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
