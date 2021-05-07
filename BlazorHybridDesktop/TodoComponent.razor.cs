using Microsoft.AspNetCore.Components;

namespace BlazorHybridDesktop
{
    public partial class TodoComponent
    {
        [Parameter] public Todo Todo { get; set; }
    }
}
