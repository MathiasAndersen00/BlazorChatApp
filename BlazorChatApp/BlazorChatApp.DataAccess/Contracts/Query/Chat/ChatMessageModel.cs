namespace BlazorChatApp.DataAccess.Contracts.Query.Chat;

public class ChatMessageModel : QueryModelBase
{
    public required string Message { get; set; }
    public required string Sender { get; set; }
}