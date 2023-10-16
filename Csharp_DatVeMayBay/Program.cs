using Csharp_DatVeMayBay.Data;
using Csharp_DatVeMayBay.Services.EmailService;
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
    options.AddPolicy("AdminOnly", policy => policy.RequireClaim("Role", "Admin"));
});

//config database
builder.Services.AddDbContext<DBContext>(options =>
options.UseSqlServer(builder.Configuration
.GetConnectionString("DatvemaybayConnection")));

builder.Services.AddScoped<IEmailService, EmailService>();

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

//Verification route via email
app.MapControllerRoute(
    name: "VerifyRoute",
    pattern: "Account/Verify/{id}/{token}",
    defaults: new { controller = "Access", action = "Verify" }
);
//Reset password route via email
app.MapControllerRoute(
    name: "ChangePasswordRoute",
    pattern: "Account/ChangePassword/{id}/{token}",
    defaults: new { controller = "Access", action = "ChangePassword" }
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Client}/{action=Index}/{id?}");

app.Run();
