using Microsoft.AspNetCore.Authentication.Cookies;
using PetHotel.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Contexto>
(options => options.UseMySql(
    "server=localhost;initial catalog=Tb_Clientes;uid=root;pwd=123456",
    Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.29-mysql")));



builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.AccessDeniedPath = "/Clientes/AccessDenied/";
        options.LoginPath = "/Clientes/Login/";

    });

builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.CheckConsentNeeded = context => true;   
    options.MinimumSameSitePolicy = SameSiteMode.None;  
    
});



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

app.UseCookiePolicy();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=reservations}/{action=Create}/{id?}");

app.Run();
