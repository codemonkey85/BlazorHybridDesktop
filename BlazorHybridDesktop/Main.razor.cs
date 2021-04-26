namespace BlazorHybridDesktop
{
    public partial class Main
    {
        protected override void OnInitialized() => CounterState.StateChanged += StateHasChanged;

        public void Dispose() => CounterState.StateChanged -= StateHasChanged;
    }
}
