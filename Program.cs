using HotelWiz.Data;
using S11.Common.Interfaces;
using S11.Data.Models;
using S11.Data;
using S11.Services;
using Microsoft.EntityFrameworkCore;
using S11.Services.DTO;
using HotelWiz.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IssuesService>();
builder.Services.AddScoped<RoomService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<EmailService, EmailService>();
builder.Services.AddScoped<ReservationsService>();
builder.Services.AddScoped<TokenService>();
builder.Services.AddScoped<DashboardService>();

// Registrar la configuración de EmailSettings en el contenedor de servicios
builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));

builder.Services
    .AddIdentity<User, Role>(options =>
    {
        options.Password.RequireDigit = false;
        options.Password.RequireLowercase = false;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = false;
        options.Password.RequiredLength = 3;
        options.Password.RequiredUniqueChars = 1;
    })
    .AddEntityFrameworkStores<Contexto>();

builder.Services.AddDbContext<Contexto>(opt =>
#if DEBUG
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
#else
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Prod"))
#endif
    , ServiceLifetime.Transient
);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
