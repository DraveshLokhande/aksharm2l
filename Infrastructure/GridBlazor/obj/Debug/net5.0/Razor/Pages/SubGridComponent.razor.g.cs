#pragma checksum "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\SubGridComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b37304758c2e98841614fb9d300188ed5bdc1ec5"
// <auto-generated/>
#pragma warning disable 1591
namespace GridBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    public partial class SubGridComponent<T> : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\SubGridComponent.razor"
 if (_visible)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "    <td></td>\r\n    ");
            __builder.OpenElement(1, "td");
            __builder.AddAttribute(2, "colspan", 
#nullable restore
#line 6 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\SubGridComponent.razor"
                  Cols

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 6 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\SubGridComponent.razor"
__builder.AddContent(3, _subGridRender);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 7 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridBlazor\Pages\SubGridComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
