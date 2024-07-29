using System.ComponentModel;

namespace MauiHybridBlazor;

public class MainPageState : INotifyPropertyChanged
{
    #region [ Event ]
    public event PropertyChangedEventHandler? PropertyChanged;
    #endregion

    #region [ Fields ]
    private int counter;
    #endregion

    #region [ Ctor ]
    public MainPageState()
    {

    }
    #endregion

    #region [ Properties ]
    public int Counter
    {
        get { return counter; }
        set
        {
            counter = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Counter)));
        }
    }
    #endregion
}
