using BlazorChatApp.DataAccess.DbModels.Chat.Tables;
using BlazorChatApp.DataAccess.Adapters.Models;
using BlazorChatApp.DataAccess.Contracts.Query.Chat;
using BlazorChatApp.DataAccess.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazorChatApp.DataAccess.Adapters;

public class ChatAdapter : IChatAdapter
{
    private readonly ChatDbContext _context;

    public ChatAdapter(ChatDbContext context)
    {
        _context = context;
    }

    public void ToDb(UploadChatMessageModel chatToDb)
    {
        var chatToAdd = new CH_Chat()
        {
            Message = chatToDb.Message,
            UserId = chatToDb.UserId
        };

        _context.CH_Chats.Add(chatToAdd);
        _context.SaveChanges();
    }

    public List<ChatMessageModel> GetAllMessages() 
    {
        var chatMessageList = new List<ChatMessageModel>();
        var chatMessages = _context.CH_Chats.Where(x => x.Id != null);

        foreach (var chatMessage in chatMessages)
        {
            var chat = new ChatMessageModel()
            {
                Id = chatMessage.Id,
                Message = chatMessage.Message,
                Sender = chatMessage.UserId
            };
            chatMessageList.Add(chat);
        }

        return chatMessageList;
    }
}