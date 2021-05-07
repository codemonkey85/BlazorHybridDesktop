using Microsoft.AspNetCore.Components;
using System.Net.Http;

namespace BlazorHybridDesktop
{
    public partial class Main
    {
        [Inject] private CounterState CounterState { get; set; }

        [Inject] private HttpClient HttpClient { get; set; }

        private Todo[] todos { get; set; }

        private string LabelTitle { get; set; } = "Hello, World!";

        protected override async void OnInitialized()
        {
            CounterState.StateChanged += StateHasChanged;
            todos = await HttpClient.GetAllTodos();
            StateHasChanged();
        }

        public void Dispose() => CounterState.StateChanged -= StateHasChanged;
    }
}
