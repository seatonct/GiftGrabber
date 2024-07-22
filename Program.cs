using System;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using GiftGrabber.Data;

// Create a WebApplication builder
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Add controllers with JSON options to ignore cycles in object references during serialization
builder.Services.AddControllers().AddJsonOptions(opts =>
{
    opts.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

// Add CORS configuration
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactClient", builder =>
    {
        builder.WithOrigins("http://localhost:3000")
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add authentication with cookie scheme
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
    {
        options.Cookie.Name = "GiftGrabberLoginCookie";
        options.Cookie.SameSite = SameSiteMode.Strict;          // SameSite policy to prevent CSRF
        options.Cookie.HttpOnly = true;                         // The cookie cannot be accessed through JS (protects against XSS)
        options.Cookie.MaxAge = new TimeSpan(7, 0, 0, 0);       // cookie expires in a week regardless of activity
        options.SlidingExpiration = true;                       // extend the cookie lifetime with activity up to 7 days.
        options.ExpireTimeSpan = new TimeSpan(24, 0, 0);        // Cookie will expire in 24 hours without activity
        options.Events.OnRedirectToLogin = (context) =>         // Event to handle unauthorized access
        {
            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
            return Task.CompletedTask;
        };
        options.Events.OnRedirectToAccessDenied = (context) =>  // Event to handle access denied
        {
            context.Response.StatusCode = StatusCodes.Status403Forbidden;
            return Task.CompletedTask;
        };
    });

// Configure Identity services for user and role management
builder.Services.AddIdentityCore<IdentityUser>(config =>
            {
                config.Password.RequireDigit = false;
                config.Password.RequiredLength = 8;
                config.Password.RequireLowercase = false;
                config.Password.RequireNonAlphanumeric = false;
                config.Password.RequireUppercase = false;
                config.User.RequireUniqueEmail = true;
            })
    .AddRoles<IdentityRole>()  //add the role service.  
    .AddEntityFrameworkStores<GiftGrabberDbContext>(); // Use Entity Framework Core with DbContext

// allows passing datetimes without time zone data 
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// allows our api endpoints to access the database through Entity Framework Core
builder.Services.AddNpgsql<GiftGrabberDbContext>(builder.Configuration["GiftGrabberDbConnectionString"]);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();  // Redirect HTTP requests to HTTPS
app.UseAuthentication();    // Add authentication middleware to the pipeline
app.UseAuthorization();     // Add authorization middleware to the pipeline

app.UseCors("AllowReactClient"); // Enable CORS for the specified policy

app.MapControllers(); // Map controller endpoints

app.Run(); // Run the application
