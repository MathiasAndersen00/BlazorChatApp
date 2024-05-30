namespace BlazorChatApp.DataAccess.Contracts.Query.Chat;

public class UploadChatMessageModel : QueryModelBase
{
    private string _message = "";
    private string _userId = "";

    public string Message 
    {
        get => _message;
        set 
        {
            _message = value;
            OnPropertyChanged(Message);
        } 
    }
    public string? UserId 
    {
        get => _userId;
        set
        {
            _userId = value;
            OnPropertyChanged(Message);
        }
    }
}
