using BlazorChatApp.DataAccess.Adapters.Interfaces;
using BlazorChatApp.DataAccess.Contracts.Query.Chat;
using BlazorChatApp.DataAccess.Contracts.Query.User;
using BlazorChatApp.DataAccess.Model;

namespace BlazorChatApp.DataAccess.Adapters;

public class UserAdapter : IUserAdapter
{
    private readonly ChatDbContext _context;

    public UserAdapter(ChatDbContext context)
    {
        _context = context;
    }

    public void ToDb(UploadUserModel userToDb)
    {
        //var userToAdd = new US_User()
        //{
        //    UserName = userToDb.UserName,
        //};

        //_context.US_Users.Add(userToAdd);
        //_context.SaveChanges();
    }

    public List<UploadUserModel> GetAllUsers()
    {
        //var userList = new List<UploadUserModel>();
        //var validUsers = _context.US_Users.Where(x => x.Id != null);

        //foreach (var user in validUsers)
        //{
        //    var newUser = new UploadUserModel()
        //    {
        //        UserId = user.Id,
        //        UserName = user.UserName,
        //    };

        //    userList.Add(newUser);
        //}

        //return userList;

        return new List<UploadUserModel>();
    }
}
