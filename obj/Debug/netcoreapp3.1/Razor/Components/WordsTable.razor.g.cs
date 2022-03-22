#pragma checksum "D:\C#\Projects\My_List_v2\Components\WordsTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bd41be056d21d938d6105db51162222b60d82d9"
// <auto-generated/>
#pragma warning disable 1591
namespace My_List_v2.Components
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
    public partial class WordsTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "tableWrap mt-5");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table table-striped p-0 ");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "thead");
            __builder.AddAttribute(7, "class", "table-dark");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "tr");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.AddMarkupContent(11, "<th scope=\"col\">Word</th>\r\n            ");
            __builder.AddMarkupContent(12, "<th scope=\"col\">Translate</th>\r\n            ");
            __builder.OpenElement(13, "th");
            __builder.AddAttribute(14, "scope", "col");
            __builder.AddContent(15, " ");
#nullable restore
#line 7 "D:\C#\Projects\My_List_v2\Components\WordsTable.razor"
__builder.AddContent(16, Words.Count);

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, " my words");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "tbody");
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 11 "D:\C#\Projects\My_List_v2\Components\WordsTable.razor"
             foreach (var item in Words)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                ");
            __builder.OpenElement(24, "tr");
            __builder.AddAttribute(25, "class", "word");
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddMarkupContent(28, "\r\n                        ");
#nullable restore
#line 15 "D:\C#\Projects\My_List_v2\Components\WordsTable.razor"
__builder.AddContent(29, item.WordText);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "float-right");
            __builder.AddMarkupContent(33, "\r\n                            ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "class", "btn btn-success");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "D:\C#\Projects\My_List_v2\Components\WordsTable.razor"
                                                                      (() => SayWord.InvokeAsync(item))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(37, "\r\n                                <i class=\"fas fa-volume-up\"></i>\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n                    ");
            __builder.OpenElement(41, "td");
#nullable restore
#line 23 "D:\C#\Projects\My_List_v2\Components\WordsTable.razor"
__builder.AddContent(42, item.Translation);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.OpenElement(44, "td");
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.AddMarkupContent(46, "<button class=\"btn btn-primary\">\r\n                            <i class=\"fas fa-edit\"></i>\r\n                        </button>\r\n                        ");
            __builder.OpenElement(47, "button");
            __builder.AddAttribute(48, "class", "btn btn-danger");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "D:\C#\Projects\My_List_v2\Components\WordsTable.razor"
                                                                 (() => DeleteWord.InvokeAsync(item))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(50, "\r\n                            <i class=\"fas fa-trash-alt\"></i>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
#nullable restore
#line 33 "D:\C#\Projects\My_List_v2\Components\WordsTable.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "D:\C#\Projects\My_List_v2\Components\WordsTable.razor"
       

    
    
    [Parameter]
    public List<Word> Words { get; set; }

    [Parameter]
    public EventCallback<Word> DeleteWord { get; set; }

    [Parameter]
    public EventCallback<Word> SayWord { get; set; }














#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
