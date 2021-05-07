using System.Net.Http;
using Microsoft.AspNetCore.Components;

namespace BlazorHybridDesktop.WebUI
{
    public partial class IndexComponent
    {
        [Inject] private TodosState TodosState { get; set; }

        [Inject] private HttpClient HttpClient { get; set; }

        protected override async void OnInitialized()
        {
            TodosState.Todos = await HttpClient.GetAllTodos();
            StateHasChanged();
        }
    }
}
