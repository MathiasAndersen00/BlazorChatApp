namespace BlazorChatApp.DataAccess.DbModels;

public class DbModelBase
{
    public DbModelBase()
    {
        Id = Guid.NewGuid().ToString();
    }

    public virtual string Id { get; set; } = default!;
    public virtual string? ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();
}
