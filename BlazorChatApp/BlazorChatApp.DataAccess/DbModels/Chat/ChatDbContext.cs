using BlazorChatApp.DataAccess.DbModels.Chat.Tables;
using Microsoft.EntityFrameworkCore;

namespace IntervjuChat.DataAccess.Model;

public class ChatDbContext(DbContextOptions<ChatDbContext> options) : DbContext(options)
{
    public DbSet<CH_Chat> CH_Chats { get; set; }
}