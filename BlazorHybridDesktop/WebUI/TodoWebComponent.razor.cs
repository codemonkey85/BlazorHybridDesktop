using Microsoft.AspNetCore.Components;

namespace BlazorHybridDesktop.WebUI
{
    public partial class TodoWebComponent
    {
        [Parameter] public Todo Todo { get; set; }
    }
}
