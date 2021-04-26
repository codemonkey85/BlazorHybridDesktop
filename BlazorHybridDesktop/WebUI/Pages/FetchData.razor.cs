using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.FileProviders;
using System.IO;

namespace BlazorHybridDesktop.WebUI.Pages
{
    public partial class FetchData
    {
        private WeatherForecast[] forecasts;

        protected override async Task OnInitializedAsync()
        {
            // The static web asset is loaded from the wwwroot from _content/<AssemblyOrNugetName>/weather.json
            // see https://docs.microsoft.com/aspnet/core/razor-pages/ui-class?view=aspnetcore-3.1&tabs=visual-studio#consume-content-from-a-referenced-rcl for more info

            IFileInfo fileInfo = FileProvider.GetFileInfo("_content/BlazorHybridDesktop/weather.json");

            if (fileInfo?.Exists ?? false)
            {
                using (Stream stream = fileInfo.CreateReadStream())
                {
                    forecasts = await JsonSerializer.DeserializeAsync<WeatherForecast[]>(stream, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                }
            }
        }
    }
}
