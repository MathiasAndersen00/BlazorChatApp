using BlazorChatApp.DataAccess.Contracts.Query;

namespace BlazorChatApp.DataAccess.Contracts.Query.User;

public class UploadUserModel : QueryModelBase
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
}
