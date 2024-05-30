using BlazorChatApp.DataAccess.Adapters.Interfaces;
using BlazorChatApp.DataAccess.Contracts.Query.User;
using Microsoft.AspNetCore.Mvc;

namespace BlazorChatApp.Service.Controllers;

[ApiController]
[Route("api/[controller]")]

public class UserController : ControllerBase
{
    private readonly IUserAdapter _userAdapter;

    public UserController(IUserAdapter userAdapter) 
    {
        _userAdapter = userAdapter;
    }

    [HttpGet]
    [Route("GetAllUsers")]
    public IEnumerable<UploadUserModel> GetAllUsers()
    {
        return _userAdapter.GetAllUsers();
    }

    [HttpPost]
    [Route("AddNewUser")]
    public void AddNewUser([FromBody] UploadUserModel user)
    {
        _userAdapter.ToDb(user);
    }
}
