using System.Net.Http;
using Microsoft.AspNetCore.Components;

namespace BlazorHybridDesktop
{
    public partial class NativeIndexComponent
    {
        [Inject] private TodosState TodosState { get; set; }

        [Inject] private HttpClient HttpClient { get; set; }

        protected override async void OnInitialized()
        {
            if (TodosState.Todos == null)
            {
                TodosState.Todos = await HttpClient.GetAllTodos();
            }
            StateHasChanged();
        }
    }
}
