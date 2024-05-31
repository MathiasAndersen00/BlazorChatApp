using BlazorChatApp;
using BlazorChatApp.Components;
using BlazorChatApp.Components.Account;
using BlazorChatApp.DataAccess.DbModels.Identity;
using BlazorChatApp.DataAccess.DbModels.Identity.Tables;
using Havit.Blazor.Components.Web;
using BlazorChatApp.DataAccess.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<UserIdentityDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultIdentityConnection")
        ?? throw new InvalidOperationException("Connection string 'DefaultIdentityConnection' not found."), 
        b => b.MigrationsAssembly("BlazorChatApp.DataAccess"));
});

builder.Services.AddDbContext<ChatDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultChatConnection")
        ?? throw new InvalidOperationException("Connection string 'DefaultChatConnection' not found."),
        b => b.MigrationsAssembly("BlazorChatApp.DataAccess"));
});

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddHxServices();
builder.Services.AddHxMessenger();
builder.Services.AddHxMessageBoxHost();

builder.Services.AddCascadingAuthenticationState();

builder.ConfigureControllers();

builder.Services.AddScoped<UserIdentityDbContext>();
builder.Services.AddScoped<ChatDbContext>();

builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentityCore<US_User>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<UserIdentityDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<US_User>, IdentityNoOpEmailSender>();
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);

builder.ConfigureAdapters();
builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();
app.MapControllers();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(BlazorChatApp.Client._Imports).Assembly);

app.MapAdditionalIdentityEndpoints();

app.Run();
