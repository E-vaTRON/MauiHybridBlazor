namespace MauiHybridBlazor
{
    public partial class App : Application
    {
        public App(MainPageViewModel viewModel)
        {
            InitializeComponent();

            MainPage = new MainPage(viewModel);
        }
    }
}
