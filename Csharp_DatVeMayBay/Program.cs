using Csharp_DatVeMayBay.Adapter_Pattern;
using Csharp_DatVeMayBay.Command_Pattern;
using Csharp_DatVeMayBay.Data;
using Csharp_DatVeMayBay.Observer_Pattern;
using Csharp_DatVeMayBay.Services.EmailService;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

/*Authentication*/
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultSignOutScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme= CookieAuthenticationDefaults.AuthenticationScheme;
})
    .AddCookie(options =>
    {
        options.LoginPath = "/login";
        options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
        options.LogoutPath = "/logout";
        options.SlidingExpiration = true;//hết phiên làm việc
    }
);

builder.Services.AddAuthentication()
    .AddGoogle(googleOptions =>
    {
        IConfigurationSection ggAuthNSection = builder.Configuration.GetSection("Authentication:Google");

        googleOptions.ClientId = ggAuthNSection["ClientId"];
        googleOptions.ClientSecret = ggAuthNSection["ClientSecret"];

    });

/*SESSION*/
builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

/*Authorization*/
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Admin", policy => policy.RequireClaim(ClaimTypes.Role, "Admin"));
});

//config database
builder.Services.AddDbContext<DBContext>(options =>
options.UseSqlServer(builder.Configuration
.GetConnectionString("DatvemaybayConnection")));

builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<FlightService>();


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

app.UseStatusCodePagesWithReExecute("/Error/{0}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Client}/{action=Index}/{id?}");

app.Run();
