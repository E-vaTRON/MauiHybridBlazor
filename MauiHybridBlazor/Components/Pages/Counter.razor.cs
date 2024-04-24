using Microsoft.AspNetCore.Components;
using System.ComponentModel;

namespace MauiHybridBlazor;

public partial class Counter : ComponentBase
{
    #region [ CTor ]
    public Counter() { }
    #endregion

    #region [ Properties - Prototype ]
    #endregion

    #region [ Properties - States ]
    [Inject]
    protected MainPageViewModel ViewModel { get; private set; }
    #endregion

    #region
    protected override async Task OnInitializedAsync()
    {
        ViewModel.PropertyChanged += OnCounterChanged;

        await base.OnInitializedAsync();
    }

    //protected override async Task OnAfterRenderAsync(bool firstRender)
    //{
    //    if (firstRender)
    //    {
    //        await this.LoadDataAsync();
    //    }
    //    await base.OnAfterRenderAsync(firstRender);
    //}
    #endregion

    #region [ Event ]
    private void OnCounterChanged(object? sender, PropertyChangedEventArgs e)
    {
        StateHasChanged();
    }

    public void Dispose()
    {
        ViewModel.PropertyChanged -= OnCounterChanged;
    }

    private void OnCounterButtonClicked(EventArgs e)
    {
        ViewModel.CounterButtonCommand.Execute(this);
    }
    #endregion

    #region [ Data ]
    //private async Task LoadDataAsync()
    //{
    //    this.CounterLabel = State.Counter = 0;
    //}
    #endregion
}
