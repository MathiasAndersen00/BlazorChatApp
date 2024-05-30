namespace BlazorChatApp.DataAccess.DbModels.Chat.Tables;

public class CH_Chat : DbModelBase
{
    public virtual string? UserId { get; set; }
    public virtual string Message { get; set; } = string.Empty;
}