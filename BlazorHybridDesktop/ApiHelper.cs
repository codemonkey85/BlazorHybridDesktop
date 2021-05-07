using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorHybridDesktop
{
    public static class ApiHelper
    {
        public static async Task<Todo> GetTodo(this HttpClient httpClient, int id) => await httpClient.GetFromJsonAsync<Todo>($"todos/{id}");

        public static async Task<Todo[]> GetAllTodos(this HttpClient httpClient) => await httpClient.GetFromJsonAsync<Todo[]>($"todos");
    }
}
