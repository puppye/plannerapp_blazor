#pragma checksum "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\Pages\Auth\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89e1efa23dff5edadc756506299f7d250338b567"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PlannerApp.Client.Pages.Auth
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using PlannerApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using PlannerApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using PlannerApp.Shared.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\_Imports.razor"
using Blazor.FileReader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\Pages\Auth\Register.razor"
using PlannerApp.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/auth/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\dell\Documents\AK Academy\PlannerApp\Blazor WASM\Project\PlannerApp\src\PlannerApp.Client\Pages\Auth\Register.razor"
       
    RegisterRequest model = new RegisterRequest();

    bool isBusy = false;
    string message = string.Empty;
    Models.AlertMessageType messageType = Models.AlertMessageType.Success;

    public async Task RegisterUser()
    {
        isBusy = true;
        var result = await authService.RegisterUserAsync(model);
        if(result.IsSuccess)
        {
            message = result.Message;
            messageType = Models.AlertMessageType.Success;
        }
        else
        {
            message = result.Errors.FirstOrDefault() ?? result.Message;
            messageType = Models.AlertMessageType.Error;
        }
        isBusy = false;
    }

    void GoToLogin()
    {
        navigationManager.NavigateTo("/auth/login");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationService authService { get; set; }
    }
}
#pragma warning restore 1591
