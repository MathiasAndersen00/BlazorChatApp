using BlazorChatApp.Components.Account;
using BlazorChatApp.Service.Controllers;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorChatApp;

public static class RegisterControllers
{
    public static void ConfigureControllers(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IdentityUserAccessor>();
        builder.Services.AddScoped<IdentityRedirectManager>();
        builder.Services.AddScoped<AuthenticationStateProvider, PersistingRevalidatingAuthenticationStateProvider>();
        builder.Services.AddScoped<ChatController>();
    }
}
