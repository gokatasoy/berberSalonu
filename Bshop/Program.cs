using Bshop.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Connection string'i appsettings.json'dan alýyoruz
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// DbContext'i servis koleksiyonuna ekliyoruz
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));


// Cookie Tabanlý Authentication Ayarlarý
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Auth/Login"; // Giriþ yapýlmamýþsa yönlendirilecek yol
        options.AccessDeniedPath = "/Auth/AccessDenied"; // Yetkisiz eriþim durumunda yönlendirilecek yol
    });

// MVC servislerini ekliyoruz
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Middleware pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Route konfigürasyonu
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
