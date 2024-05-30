using BlazorChatApp.DataAccess.Contracts.Query.User;

namespace BlazorChatApp.DataAccess.Adapters.Interfaces;

public interface IUserAdapter
{
    public void ToDb(UploadUserModel chatToDb);
    public List<UploadUserModel> GetAllUsers();
}
