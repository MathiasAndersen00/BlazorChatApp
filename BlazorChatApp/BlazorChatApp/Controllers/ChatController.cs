using BlazorChatApp.DataAccess.Adapters.Models;
using BlazorChatApp.DataAccess.Contracts.Query.Chat;
using Microsoft.AspNetCore.Mvc;

namespace BlazorChatApp.Service.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ChatController : ControllerBase
{
    private readonly IChatAdapter _chatAdapter;

    public ChatController(IChatAdapter chatAdapter)
    {
        _chatAdapter = chatAdapter;
    }

    [HttpGet]
    [Route("GetAllMessages")]
    public IEnumerable<ChatMessageModel> GetAllMessages()
    {
        return _chatAdapter.GetAllMessages();
    }

    [HttpPost]
    [Route("AddNewMessage")]
    public void AddNewMessage([FromBody] UploadChatMessageModel chatMessage)
    {
        _chatAdapter.ToDb(chatMessage);
    }
}
