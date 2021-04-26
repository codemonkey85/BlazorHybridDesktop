using Microsoft.AspNetCore.Components;

namespace BlazorHybridDesktop.WebUI.Pages
{
    public partial class Counter
    {
        [Inject] public CounterState CounterState { get; set; }

        protected override void OnInitialized() => CounterState.StateChanged += StateHasChanged;

        public void Dispose() => CounterState.StateChanged -= StateHasChanged;
    }
}

