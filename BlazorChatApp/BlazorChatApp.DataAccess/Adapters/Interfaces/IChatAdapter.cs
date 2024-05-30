using BlazorChatApp.DataAccess.Contracts.Query.Chat;

namespace BlazorChatApp.DataAccess.Adapters.Models;

public interface IChatAdapter
{
    public void ToDb(UploadChatMessageModel chatToDb);
    public List<ChatMessageModel> GetAllMessages();
}