using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore;
using proyecto_sena.Data;
using proyecto_sena.implementacion;
using proyecto_sena.services;
var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration
.GetConnectionString("Defaultconnection");
builder.Services.AddDbContext<DBcontext>(options => options.UseNpgsql(connectionString));
builder.Services.AddScoped<Iusuarioservice, usuarioservice>();
// Add services to the container.
builder.Services.AddControllersWithViews();

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
builder.Services.AddScoped<Iusuarioservice, usuarioservice>();