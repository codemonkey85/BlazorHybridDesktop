using Microsoft.AspNetCore.Components;
using System.Net.Http;

namespace BlazorHybridDesktop.WebUI.Pages
{
    public partial class Index
    {
        [Inject] private TodosState TodosState { get; set; }

        [Inject] private HttpClient HttpClient { get; set; }
    }
}
