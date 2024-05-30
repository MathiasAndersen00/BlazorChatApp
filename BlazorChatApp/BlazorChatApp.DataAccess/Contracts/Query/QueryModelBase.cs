using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorChatApp.DataAccess.Contracts.Query;

public class QueryModelBase : INotifyPropertyChanged
{
    public QueryModelBase()
    {
        Id = String.Empty;
        ConcurrencyStamp = String.Empty;
    }

    public string Id { get; set; }
    public string ConcurrencyStamp { get; set; }

    protected void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        PropertyChanged?.Invoke(this, e);
    }

    protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "")
    {
        OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}
