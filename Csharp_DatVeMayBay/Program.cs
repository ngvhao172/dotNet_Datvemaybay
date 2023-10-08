using Csharp_DatVeMayBay.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

/*Authentication*/
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultSignOutScheme = CookieAuthenticationDefaults.AuthenticationScheme;
})
.AddCookie(options =>
{
    options.LoginPath = "/login";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(20); 
    options.LogoutPath = "/logout";
    options.SlidingExpiration = true;//hết phiên làm việc
});
/*SESSION*/
/*builder.Services.AddDistributedMemoryCache();*/

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(2);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

//config database
builder.Services.AddDbContext<DBContext>(options =>
options.UseSqlServer(builder.Configuration
.GetConnectionString("DatvemaybayConnection")));

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

app.UseAuthentication();
app.UseAuthorization();

app.UseSession();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Client}/{action=Index}/{id?}");

app.Run();
