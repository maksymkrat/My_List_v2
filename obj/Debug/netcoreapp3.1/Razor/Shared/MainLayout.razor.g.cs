#pragma checksum "D:\C#\Projects\My_List_v2\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f36d52f167464d7273269f04ca74ee12f240de6d"
// <auto-generated/>
#pragma warning disable 1591
namespace My_List_v2.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\C#\Projects\My_List_v2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\Projects\My_List_v2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C#\Projects\My_List_v2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\C#\Projects\My_List_v2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\C#\Projects\My_List_v2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\C#\Projects\My_List_v2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\C#\Projects\My_List_v2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\C#\Projects\My_List_v2\_Imports.razor"
using My_List_v2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\C#\Projects\My_List_v2\_Imports.razor"
using My_List_v2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\C#\Projects\My_List_v2\_Imports.razor"
using My_List_v2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\C#\Projects\My_List_v2\_Imports.razor"
using My_List_v2.Models.DeserializeTranslation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\C#\Projects\My_List_v2\_Imports.razor"
using My_List_v2.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\C#\Projects\My_List_v2\_Imports.razor"
using My_List_v2.Business;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\C#\Projects\My_List_v2\_Imports.razor"
using My_List_v2.Repository;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<My_List_v2.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "content px-4");
            __builder.AddMarkupContent(11, "\r\n        ");
#nullable restore
#line 13 "D:\C#\Projects\My_List_v2\Shared\MainLayout.razor"
__builder.AddContent(12, Body);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
