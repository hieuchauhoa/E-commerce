// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Suchimu.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hieu0\Desktop\Suchimu\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hieu0\Desktop\Suchimu\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hieu0\Desktop\Suchimu\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hieu0\Desktop\Suchimu\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hieu0\Desktop\Suchimu\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hieu0\Desktop\Suchimu\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hieu0\Desktop\Suchimu\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hieu0\Desktop\Suchimu\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hieu0\Desktop\Suchimu\Client\_Imports.razor"
using Suchimu.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hieu0\Desktop\Suchimu\Client\_Imports.razor"
using Suchimu.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\hieu0\Desktop\Suchimu\Client\_Imports.razor"
using Suchimu.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\hieu0\Desktop\Suchimu\Client\_Imports.razor"
using Suchimu.Client.Services.GameService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\hieu0\Desktop\Suchimu\Client\_Imports.razor"
using Suchimu.Client.Services.CategoryService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\hieu0\Desktop\Suchimu\Client\_Imports.razor"
using Suchimu.Client.Services.StudioService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\hieu0\Desktop\Suchimu\Client\_Imports.razor"
using Suchimu.Client.Services.StatsService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\hieu0\Desktop\Suchimu\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\hieu0\Desktop\Suchimu\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\hieu0\Desktop\Suchimu\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\hieu0\Desktop\Suchimu\Client\_Imports.razor"
using Suchimu.Client.Services.CartService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\hieu0\Desktop\Suchimu\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    public partial class TopMenu : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\hieu0\Desktop\Suchimu\Client\Shared\TopMenu.razor"
             
    protected override void OnInitialized()
    {
        CartService.OnChange += StateHasChanged;
    }

    public void Dispose()
    {
        CartService.OnChange -= StateHasChanged;
    }

    private int GetCartItemCount()
    {
        var cart = LocalStorage.GetItem<List<Game>>("cart");
        return cart != null ? cart.Count : 0;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartService CartService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISyncLocalStorageService LocalStorage { get; set; }
    }
}
#pragma warning restore 1591
