#pragma checksum "C:\Git\BlazorHybridDesktop\BlazorHybridDesktop\WebUI\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed6c69ae77c862855d9d9cbf43230b8873bb1867"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorHybridDesktop.WebUI.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Git\BlazorHybridDesktop\BlazorHybridDesktop\_Imports.razor"
using Microsoft.MobileBlazorBindings;

#line default
#line hidden
#line 2 "C:\Git\BlazorHybridDesktop\BlazorHybridDesktop\_Imports.razor"
using Microsoft.MobileBlazorBindings.Elements;

#line default
#line hidden
#line 3 "C:\Git\BlazorHybridDesktop\BlazorHybridDesktop\_Imports.razor"
using Xamarin.Essentials;

#line default
#line hidden
#line 4 "C:\Git\BlazorHybridDesktop\BlazorHybridDesktop\_Imports.razor"
using Xamarin.Forms;

#line default
#line hidden
#line 1 "C:\Git\BlazorHybridDesktop\BlazorHybridDesktop\WebUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Git\BlazorHybridDesktop\BlazorHybridDesktop\WebUI\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#line 3 "C:\Git\BlazorHybridDesktop\BlazorHybridDesktop\WebUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "C:\Git\BlazorHybridDesktop\BlazorHybridDesktop\WebUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Git\BlazorHybridDesktop\BlazorHybridDesktop\WebUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 6 "C:\Git\BlazorHybridDesktop\BlazorHybridDesktop\WebUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "C:\Git\BlazorHybridDesktop\BlazorHybridDesktop\WebUI\_Imports.razor"
using BlazorHybridDesktop.WebUI.Shared;

#line default
#line hidden
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n\t");
            __builder.OpenComponent<BlazorHybridDesktop.WebUI.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n\t");
            __builder.AddMarkupContent(9, "<div class=\"top-row px-4\">\r\n\t\t<a href=\"https://blazor.net\" target=\"_blank\" class=\"ml-md-auto\">About</a>\r\n\t</div>\r\n\r\n\t");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "content px-4");
            __builder.AddMarkupContent(12, "\r\n\t\t");
            __builder.AddContent(13, 
#line 13 "C:\Git\BlazorHybridDesktop\BlazorHybridDesktop\WebUI\Shared\MainLayout.razor"
         Body

#line default
#line hidden
            );
            __builder.AddMarkupContent(14, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591