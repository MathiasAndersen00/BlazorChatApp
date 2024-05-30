using BlazorChatApp.DataAccess.DbModels.Identity;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using BlazorChatApp.DataAccess.Model;

namespace BlazorChatApp.DataAccess.DbModels.Chat;

public class ChatDbContextFactory : IDesignTimeDbContextFactory<ChatDbContext>
{
    public ChatDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ChatDbContext>();

        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var connectionString = configuration.GetConnectionString("DefaultChatConnection");
        optionsBuilder.UseSqlServer(connectionString);

        return new ChatDbContext(optionsBuilder.Options);
    }
}
