#pragma checksum "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\JobOrder\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9c74b97e14f4f1c14640d03fa7115741ff4c1c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_JobOrder_Index), @"mvc.1.0.view", @"/Areas/Member/Views/JobOrder/Index.cshtml")]
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
#line 2 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\_ViewImports.cshtml"
using WorkflowManagement.DTO.DTOs.NotificationDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\_ViewImports.cshtml"
using WorkflowManagement.DTO.DTOs.JobDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\_ViewImports.cshtml"
using WorkflowManagement.DTO.DTOs.ReportDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\_ViewImports.cshtml"
using WorkflowManagement.DTO.DTOs.AppUserDTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9c74b97e14f4f1c14640d03fa7115741ff4c1c2", @"/Areas/Member/Views/JobOrder/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"144eb19084de877bf3066143238208e75aa69715", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_JobOrder_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<JobListAllDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\JobOrder\Index.cshtml"
  
    int index = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\JobOrder\Index.cshtml"
 foreach (var item in Model)
{
    index++;


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card m-5\">\r\n        <h5 class=\"card-header\">");
#nullable restore
#line 11 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\JobOrder\Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\"><span class=\"text-danger\">Aciliyet Durumu: </span>");
#nullable restore
#line 13 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\JobOrder\Index.cshtml"
                                                                                Write(item.Urgency.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">");
#nullable restore
#line 14 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\JobOrder\Index.cshtml"
                            Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n            <p class=\"text-right\">\r\n");
#nullable restore
#line 18 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\JobOrder\Index.cshtml"
                 if (item.Reports.Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"btn btn-light btn-sm\" data-toggle=\"collapse\"");
            BeginWriteAttribute("href", " href=\"", 563, "\"", 593, 2);
            WriteAttributeValue("", 570, "#collapseExample-", 570, 17, true);
#nullable restore
#line 20 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\JobOrder\Index.cshtml"
WriteAttributeValue("", 587, index, 587, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" role=""button"" aria-expanded=""false"" aria-controls=""collapseExample"">
                        <i class=""fas fa-caret-down mr-1"" id=""showReports""></i>
                        <i class=""fas fa-caret-up mr-1"" id=""hideReports""></i>
                        Raporlara Git <span class=""badge badge-dark"">");
#nullable restore
#line 23 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\JobOrder\Index.cshtml"
                                                                Write(item.Reports.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </a>\r\n");
#nullable restore
#line 25 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\JobOrder\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9c74b97e14f4f1c14640d03fa7115741ff4c1c28879", async() => {
                WriteLiteral("Rapor Yaz");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\JobOrder\Index.cshtml"
                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\JobOrder\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"btn btn-dark btn-sm\" data-toggle=\"modal\" data-target=\"#exampleModal\" data-id=\"");
#nullable restore
#line 30 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\JobOrder\Index.cshtml"
                                                                                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Tamamlandı Olarak İşaretle</a>\r\n            </p>\r\n            <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 1338, "\"", 1365, 2);
            WriteAttributeValue("", 1343, "collapseExample-", 1343, 16, true);
#nullable restore
#line 32 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\JobOrder\Index.cshtml"
WriteAttributeValue("", 1359, index, 1359, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9c74b97e14f4f1c14640d03fa7115741ff4c1c212414", async() => {
                WriteLiteral("Rapor Yaz");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\JobOrder\Index.cshtml"
                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <table class=""table table-hover table-sm"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th>Tanım</th>
                            <th>Açıklama</th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 45 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\JobOrder\Index.cshtml"
                         foreach (var report in item.Reports)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 48 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\JobOrder\Index.cshtml"
                               Write(report.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 49 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\JobOrder\Index.cshtml"
                               Write(report.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9c74b97e14f4f1c14640d03fa7115741ff4c1c216104", async() => {
                WriteLiteral("Düzenle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\JobOrder\Index.cshtml"
                                                                 WriteLiteral(report.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 54 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\JobOrder\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 60 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\JobOrder\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Modal -->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title text-danger"" id=""exampleModalLabel"">UYARI</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                Bu görevi tamamlandı olarak işaretlemek istediğinizden emin misiniz?
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Vazgeç</button>
                <button id=""btnSave"" type=""button"" class=""btn btn-primary"">Evet</button>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $(""#exampleModal"").on(""show.bs.modal"", function (event) {
                let actElement = $(event.relatedTarget);
                let data = actElement.data(""id"");
                $(""#btnSave"").click(function () {
                    $.ajax({
                        type: ""GET"",
                        contentType: ""application/json; charset=utf-8"",
                        url: ""./JobOrder/CompleteJob"",
                        data: { jobId: data },
                        success: function () {
                            window.location.reload();
                        }
                    });
                });

            });
        });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<JobListAllDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
