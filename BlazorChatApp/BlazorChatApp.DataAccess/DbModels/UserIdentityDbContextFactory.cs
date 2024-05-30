using BlazorChatApp.DataAccess.DbModels.Identity;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BlazorChatApp.DataAccess.DbModels;

public class UserIdentityDbContextFactory : IDesignTimeDbContextFactory<UserIdentityDbContext>
{
    public UserIdentityDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<UserIdentityDbContext>();

        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var connectionString = configuration.GetConnectionString("DefaultIdentityConnection");
        optionsBuilder.UseSqlServer(connectionString);

        return new UserIdentityDbContext(optionsBuilder.Options);
    }
}

