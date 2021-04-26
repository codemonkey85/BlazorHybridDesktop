using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace BlazorHybridDesktop.WebUI.Shared
{
    public partial class SurveyPrompt
    {
        [Parameter]
        public string Title { get; set; }

        async Task LaunchSurvey() => await Launcher.OpenAsync("https://go.microsoft.com/fwlink/?linkid=2121313");
    }
}
