using BlazorChatApp.DataAccess.Adapters;
using BlazorChatApp.DataAccess.Adapters.Interfaces;
using BlazorChatApp.DataAccess.Adapters.Models;

namespace BlazorChatApp;

public static class RegisterAdapters
{
    public static void ConfigureAdapters(this WebApplicationBuilder builder)
    {
        builder.Services.AddTransient<IChatAdapter, ChatAdapter>();
        builder.Services.AddTransient<IUserAdapter, UserAdapter>();
    }
}
