using BlazorChatApp.DataAccess.DbModels.Identity.Tables;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorChatApp.DataAccess.DbModels.Identity;

public class UserIdentityDbContext(DbContextOptions<UserIdentityDbContext> options) : IdentityDbContext(options)
{
    public DbSet<US_User> US_Users { get; set; }
}
