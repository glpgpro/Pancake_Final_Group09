using Pancake_Final.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pancake_Final.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Pancake_Final.Components.Account;
using Pancake_Final.Configurations;
using Pancake_Final.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<Pancake_FinalContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Pancake_FinalContext") ?? throw new InvalidOperationException("Connection string 'Pancake_FinalContext' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();

builder.Services.AddScoped<IdentityUserAccessor>();

builder.Services.AddScoped<IdentityRedirectManager>();

builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = IdentityConstants.ApplicationScheme;
    options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
})
    .AddIdentityCookies();

builder.Services.AddIdentityCore<Pancake_FinalUser>(options =>
{
    // Sign-in options
    options.SignIn.RequireConfirmedAccount = true;

    // Password settings
    options.Password.RequireDigit = true;                  // Require at least one digit (e.g., 0-9)
    options.Password.RequiredLength = 6;                   // Minimum password length
    options.Password.RequireNonAlphanumeric = false;       // No special characters required
    options.Password.RequireUppercase = false;             // No uppercase letter required
    options.Password.RequireLowercase = true;              // At least one lowercase letter
    options.Password.RequiredUniqueChars = 1;              // Minimum unique characters in the password
})
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<Pancake_FinalContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();


builder.Services.AddTransient<IEmailSender, EmailSender>();
builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));

builder.Services.AddAuthorizationBuilder()
    .AddPolicy("RequireAdmin", policy => policy.RequireRole("Admin"))
    .AddPolicy("RequireSubscriber", policy => policy.RequireRole("Subscriber"));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.MapAdditionalIdentityEndpoints(); ;


app.Run();
