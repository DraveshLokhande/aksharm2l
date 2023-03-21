#pragma checksum "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridCell.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72bbaa33530efa8b5d985067426d577c5ddb8774"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__GridCell), @"mvc.1.0.view", @"/Views/Shared/_GridCell.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridCell.cshtml"
using GridShared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridCell.cshtml"
using GridShared.Columns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridCell.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72bbaa33530efa8b5d985067426d577c5ddb8774", @"/Views/Shared/_GridCell.cshtml")]
    #nullable restore
    public class Views_Shared__GridCell : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<IGridColumn, object>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridCell.cshtml"
  
    const string TdClass = "grid-cell";
    const string TdStyle = "display:none;";

    IGridColumn column = Model.Item1;
    object item = Model.Item2;

    string _cssStyles;
    if (column.Hidden)
    {
        _cssStyles = ((GridStyledColumn)column).GetCssStylesString() + " " + TdStyle;
    }
    else
    {
        _cssStyles = ((GridStyledColumn)column).GetCssStylesString();
    }

    if (column.ParentGrid.Direction == GridDirection.RTL)
        _cssStyles = string.Concat(_cssStyles, " text-align:right;direction:rtl;").Trim();

    string _cssClass = ((GridStyledColumn)column).GetCssClassesString() + " " + TdClass;
    string columnCssClasses = column.GetCellCssClasses(item);
    if (!string.IsNullOrWhiteSpace(columnCssClasses))
    {
        _cssClass += " " + columnCssClasses;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 34 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridCell.cshtml"
 if (column.ComponentType != null)
{
    object model = new {
        Item = item,
        Grid = column.ParentGrid,
        Actions = column.Actions,
        Functions = column.Functions,
        Object = column.Object
    };

#line default
#line hidden
#nullable disable
            WriteLiteral("    <td");
            BeginWriteAttribute("class", " class=\"", 1197, "\"", 1215, 1);
#nullable restore
#line 43 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridCell.cshtml"
WriteAttributeValue("", 1205, _cssClass, 1205, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 1216, "\"", 1235, 1);
#nullable restore
#line 43 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridCell.cshtml"
WriteAttributeValue("", 1224, _cssStyles, 1224, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-name=\"");
#nullable restore
#line 43 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridCell.cshtml"
                                                     Write(column.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 43 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridCell.cshtml"
                                                                   Write(await Component.InvokeAsync(column.ComponentType, model));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 44 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridCell.cshtml"
}
else
{
    IGridCell _cell = column.GetCell(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <td");
            BeginWriteAttribute("class", " class=\"", 1390, "\"", 1408, 1);
#nullable restore
#line 48 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridCell.cshtml"
WriteAttributeValue("", 1398, _cssClass, 1398, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 1409, "\"", 1428, 1);
#nullable restore
#line 48 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridCell.cshtml"
WriteAttributeValue("", 1417, _cssStyles, 1417, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-name=\"");
#nullable restore
#line 48 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridCell.cshtml"
                                                     Write(column.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 48 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridCell.cshtml"
                                                                    Write(new HtmlString(_cell.ToString()));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 49 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\Infrastructure\GridMvc\Views\Shared\_GridCell.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<IGridColumn, object>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
