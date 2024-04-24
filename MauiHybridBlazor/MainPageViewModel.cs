using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace MauiHybridBlazor;

public partial class MainPageViewModel : ObservableRecipient
{
    #region [ State ]
    #endregion

    #region [ Ctor ]
    public MainPageViewModel() 
    {
    }
    #endregion

    #region [ Properties ]
    [ObservableProperty]
    public int counter;
    #endregion

    #region [ RelayCommand ]
    [RelayCommand]
    public void CounterButton()
    {
        this.Counter++;
    }
    #endregion
}
