using Microsoft.AspNetCore.Components;

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

    private async void OnMyMauiButtonClicked(object sender, EventArgs e)
    {
        var wasDispatchCalled = await blazorWebView.TryDispatchAsync( sp =>
        {
            var navMan = sp.GetRequiredService<NavigationManager>();
            //navMan.CallSomeNavigationApi("");
        });

        if (!wasDispatchCalled)
        {
            // Consider what to do if it the dispatch fails - that's up to your app to decide.
        }
    }
}
