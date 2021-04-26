using Microsoft.AspNetCore.Components;

namespace BlazorHybridDesktop
{
    public partial class Main
    {
        [Inject] private CounterState CounterState { get; set; }

        protected override void OnInitialized() => CounterState.StateChanged += StateHasChanged;

        public void Dispose() => CounterState.StateChanged -= StateHasChanged;
    }
}
