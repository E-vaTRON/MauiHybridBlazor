namespace MauiHybridBlazor;

public partial class MainPage : ContentPage
{
    protected MainPageViewModel ViewModel;

    public MainPage(MainPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = ViewModel = viewModel;
    }

    private void Button_Pressed(object sender, EventArgs e)
    {
        this.ViewModel.CounterButtonCommand.Execute(this);
    }
}
