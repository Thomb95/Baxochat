#pragma checksum "c:\Users\Thoma\source\repos\baxochat\baxochat\Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d39c81780e79fd30a3d584dc91c92328356c2e38"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace baxochat.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\Thoma\source\repos\baxochat\baxochat\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Thoma\source\repos\baxochat\baxochat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Thoma\source\repos\baxochat\baxochat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\Thoma\source\repos\baxochat\baxochat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\Thoma\source\repos\baxochat\baxochat\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\Thoma\source\repos\baxochat\baxochat\Client\_Imports.razor"
using baxochat.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\Thoma\source\repos\baxochat\baxochat\Client\_Imports.razor"
using baxochat.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Thoma\source\repos\baxochat\baxochat\Client\Pages\FetchData.razor"
using baxochat.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "c:\Users\Thoma\source\repos\baxochat\baxochat\Client\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetJsonAsync<WeatherForecast[]>("WeatherForecast");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
