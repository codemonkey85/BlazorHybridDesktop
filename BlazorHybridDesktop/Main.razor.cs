using Microsoft.AspNetCore.Components;
using System.Net.Http;

namespace BlazorHybridDesktop
{
    public partial class Main
    {
        [Inject] private TodosState TodosState { get; set; }

        [Inject] private HttpClient HttpClient { get; set; }

        private string LabelTitle { get; set; } = "Hello, World!";

        private bool ShowWeb { get; set; } = false;

        protected override async void OnInitialized()
        {
            TodosState.Todos = await HttpClient.GetAllTodos();
            StateHasChanged();
        }

        private void CheckboxClicked(bool isChecked)
        {
            ShowWeb = isChecked;
            StateHasChanged();
        }
    }
}
