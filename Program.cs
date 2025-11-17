using Microsoft.AspNetCore.StaticFiles;

var builder = WebApplication.CreateBuilder(args);

// Session'ý yapýlandýrýyoruz
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);  // Session süresi
    options.Cookie.HttpOnly = true;  // Güvenlik için HttpOnly flag'ini açýyoruz
    options.Cookie.IsEssential = true;  // Cookie'nin gerekli olduðunu belirtiyoruz
});

builder.Services.AddControllersWithViews();
builder.Services.AddSession(); // Session servisini ekle





var app = builder.Build();
app.UseSession();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=FirstPage}/{id?}"
    );

app.Run();


