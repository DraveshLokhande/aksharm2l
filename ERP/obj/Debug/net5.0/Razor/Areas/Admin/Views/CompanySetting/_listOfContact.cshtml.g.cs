#pragma checksum "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\Admin\Views\CompanySetting\_listOfContact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78f32a00f09a30fee5de46a378766b37baea012e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_CompanySetting__listOfContact), @"mvc.1.0.view", @"/Areas/Admin/Views/CompanySetting/_listOfContact.cshtml")]
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
#line 1 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\Admin\_ViewImports.cshtml"
using ERP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\Admin\_ViewImports.cshtml"
using ERP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\Admin\_ViewImports.cshtml"
using Business.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\Admin\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\Admin\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\Admin\_ViewImports.cshtml"
using ERP.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\Admin\_ViewImports.cshtml"
using ERP.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\Admin\_ViewImports.cshtml"
using ERP.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\Admin\_ViewImports.cshtml"
using Business.Entities.Dynamic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\Admin\Views\CompanySetting\_listOfContact.cshtml"
using Business.SQL;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78f32a00f09a30fee5de46a378766b37baea012e", @"/Areas/Admin/Views/CompanySetting/_listOfContact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9944a1c594c39df98753be59f62bb100aa180b8b", @"/Areas/Admin/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_CompanySetting__listOfContact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedDataTable<CompanyContactTxnMetadata>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/assets/vendors/simple-datatables/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/assets/vendors/simple-datatables/simple-datatables.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "78f32a00f09a30fee5de46a378766b37baea012e5925", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div id=""CompanyTable"">
    <div class=""row"">
        <div class=""col-lg-6"">
            <h6 class=""cards-title"">
                Contacts
            </h6>
        </div>
        <div class=""col-lg-6 text-align-right"">
            <a onclick=""fnAddContact()""
               class=""btn btn-primary px-5""
               href=""javascript:void(0)""
               offcanvas-title=""Add Contact""
               data-id=""0""
               data-bs-toggle=""offcanvas""
               data-bs-target=""#canvas_contact""
               aria-controls=""canvas_contact"">
                Add Contact
            </a>
        </div>
    </div>
    <div class=""row"">
        <table class=""table table-striped"" id=""tblContact"">
            <thead>
                <tr>
                    <th>Sr. No.</th>
                    <th>Designation</th>
                    <th>Contact Person</th>
                    <th>Email</th>
                    <th>Mobile</th>
                    <th>Department</th>

         ");
            WriteLiteral("       </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\Admin\Views\CompanySetting\_listOfContact.cshtml"
                 if(Model!=null)
                {
                foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 43 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\Admin\Views\CompanySetting\_listOfContact.cshtml"
                       Write(item.SrNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 44 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\Admin\Views\CompanySetting\_listOfContact.cshtml"
                       Write(item.DesignationText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 45 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\Admin\Views\CompanySetting\_listOfContact.cshtml"
                       Write(item.PersonName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 46 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\Admin\Views\CompanySetting\_listOfContact.cshtml"
                       Write(item.PersonEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 47 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\Admin\Views\CompanySetting\_listOfContact.cshtml"
                       Write(item.PersonalMobileNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 48 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\Admin\Views\CompanySetting\_listOfContact.cshtml"
                       Write(item.DepartmentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a class=\'btn deletecontact\' href=\"#!\"");
            BeginWriteAttribute("id", " id=\"", 1790, "\"", 1824, 1);
#nullable restore
#line 50 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\Admin\Views\CompanySetting\_listOfContact.cshtml"
WriteAttributeValue("", 1795, item.CompanyContactPersonsID, 1795, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("compnayid", " compnayid=\"", 1825, "\"", 1852, 1);
#nullable restore
#line 50 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\Admin\Views\CompanySetting\_listOfContact.cshtml"
WriteAttributeValue("", 1837, item.CompanyID, 1837, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\'icon dripicons-trash\'></i></a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 53 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\Admin\Views\CompanySetting\_listOfContact.cshtml"
                }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>
<div class=""offcanvas offcanvas-end"" tabindex=""-1"" id=""canvas_contact"" aria-labelledby=""offcanvascontactLabel"">
    <div class=""offcanvas-header"">
        <h5 class=""offcanvas-title"" id=""offcanvascontactLabel"">Contact</h5>
        <button type=""button"" class=""btn-close te  xt-reset"" data-bs-dismiss=""offcanvas"" aria-l abel=""Close""></button>
    </div>
    <div class=""offcanvas-body pt-3 pb-5"">
        <div id=""dvContactInfo"">
        </div>
    </div>
</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78f32a00f09a30fee5de46a378766b37baea012e12138", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script>\r\n    var urlDeleteCompanyFromUser = \'");
#nullable restore
#line 72 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\Admin\Views\CompanySetting\_listOfContact.cshtml"
                               Write(Url.Action("DeleteContact", "CompanySetting"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    var urlAddContact = \'");
#nullable restore
#line 73 "C:\Users\Lenovo\Documents\GitHub\aksharm2l\ERP\Areas\Admin\Views\CompanySetting\_listOfContact.cshtml"
                    Write(Url.Action("AddContact", "CompanySetting"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
    $(document).ready(function () {
        let table1 = document.querySelector('#tblContact');
        let dataTable = new simpleDatatables.DataTable(table1);

        ////Unbind the original image 'href' set by the controller...
        // $('.deletecontact').attr('href', 'javascript://');
        // $('#tblstore').on('click', 'a.deleteStore', function () {
        //    var _id = $(this).attr('id');
        //     var _compnayid = $(this).attr('compnayid');

        //     var _parameters = { id: _id, companyid: _compnayid };
        //    $.ajax({
        //        url: urlDeleteCompanyFromUser,
        //        type: ""GET"",
        //        data: _parameters,
        //        success: function (data, textStatus, jqXHR) {
        //            $('#CompanyTable').html(data);
        //        }
        //    });
        //});


    });
    function fnAddContact() {
        var _id = $(this).data('id');
        var _cid=$(""#CompanyID"").val();
        var _parameters = { id: ");
            WriteLiteral(@"_id, compnayid: _cid };
        $.ajax({
            url: urlAddContact,
            type: ""POST"",
            data: _parameters,
            success: function (data, textStatus, jqXHR) {
                $('#dvContactInfo').html(data);
                $(""#canvas_contact"").show();//('hide');
            }
        });
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedDataTable<CompanyContactTxnMetadata>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
