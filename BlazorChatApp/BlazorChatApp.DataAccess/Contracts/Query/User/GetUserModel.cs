namespace BlazorChatApp.DataAccess.Contracts.Query.User;

public class GetUserModel : QueryModelBase
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }

    public string FullName
    {
        get
        {
            if (FirstName == null || FirstName == String.Empty || LastName == null || LastName == String.Empty) return "";

            return string.Join(" ", FirstName, LastName);
        }
    }
}
