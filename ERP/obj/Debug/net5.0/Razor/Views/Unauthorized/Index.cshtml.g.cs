#pragma checksum "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Views\Unauthorized\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b39e4f88c123a55fd6c95a7f85660b9da983d344"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Unauthorized_Index), @"mvc.1.0.view", @"/Views/Unauthorized/Index.cshtml")]
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
#line 1 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Views\_ViewImports.cshtml"
using ERP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Views\_ViewImports.cshtml"
using ERP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Views\_ViewImports.cshtml"
using Business.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Views\_ViewImports.cshtml"
using Business.SQL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Views\_ViewImports.cshtml"
using ERP.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Views\_ViewImports.cshtml"
using ERP.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Views\_ViewImports.cshtml"
using ERP.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Views\_ViewImports.cshtml"
using Business.Entities.Dynamic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b39e4f88c123a55fd6c95a7f85660b9da983d344", @"/Views/Unauthorized/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f06666780c8e5dee53569ad909d5a5d76999708", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Unauthorized_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<style>\r\n    ");
            WriteLiteral(@"@import url(""https://fonts.googleapis.com/css?family=Lato"");

    /** {
            position: relative;
            margin: 0;
            padding: 0;
            box-sizing: border-box;
            font-family: ""Lato"", sans-serif;
        }*/

    .container {
        height: 540px;
        display: flex;
        flex-direction: column;
        justify-content: center;
        align-items: center;
        
    }

    h1 {
        margin: 40px 0 20px;
    }

    .lock {
        border-radius: 5px;
        width: 55px;
        height: 45px;
        background-color: #333;
        animation: dip 1s;
        animation-delay: 1.5s;
    }

        .lock::before, .lock::after {
            content: """";
            position: absolute;
            border-left: 5px solid #333;
            height: 20px;
            width: 15px;
            left: calc(50% - 12.5px);
        }

        .lock::before {
            top: -30px;
            border: 5px solid #333;
            borde");
            WriteLiteral(@"r-bottom-color: transparent;
            border-radius: 15px 15px 0 0;
            height: 30px;
            animation: lock 2s, spin 2s;
        }

        .lock::after {
            top: -10px;
            border-right: 5px solid transparent;
            animation: spin 2s;
        }

    ");
            WriteLiteral("@keyframes lock {\r\n        0% {\r\n            top: -45px;\r\n        }\r\n\r\n        65% {\r\n            top: -45px;\r\n        }\r\n\r\n        100% {\r\n            top: -30px;\r\n        }\r\n    }\r\n\r\n    ");
            WriteLiteral("@keyframes spin {\r\n        0% {\r\n            transform: scaleX(-1);\r\n            left: calc(50% - 30px);\r\n        }\r\n\r\n        65% {\r\n            transform: scaleX(1);\r\n            left: calc(50% - 12.5px);\r\n        }\r\n    }\r\n\r\n    ");
            WriteLiteral(@"@keyframes dip {
        0% {
            transform: translateY(0px);
        }

        50% {
            transform: translateY(10px);
        }

        100% {
            transform: translateY(0px);
        }
    }
</style>

<main id=""main"">

    <div class=""lock""></div>
    <div class=""message"">
        <h1>Access to this page is restricted</h1>
        <p>Please check with the admin if you believe this is a mistake.</p>
    </div>
</main>
<!-- partial -->
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
