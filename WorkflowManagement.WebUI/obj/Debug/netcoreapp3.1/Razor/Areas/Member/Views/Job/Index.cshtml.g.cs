#pragma checksum "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\Job\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30969d21a1cec6b504482c7cf34ff403a874fa39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Job_Index), @"mvc.1.0.view", @"/Areas/Member/Views/Job/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30969d21a1cec6b504482c7cf34ff403a874fa39", @"/Areas/Member/Views/Job/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"144eb19084de877bf3066143238208e75aa69715", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Job_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<JobListAllDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Job", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\Job\Index.cshtml"
  
    int index = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row m-3\">\r\n");
#nullable restore
#line 7 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\Job\Index.cshtml"
     foreach (var item in Model)
    {
        index++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-4\">\r\n            <div class=\"card m-2\">\r\n                <h5 class=\"card-header\">");
#nullable restore
#line 12 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\Job\Index.cshtml"
                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\"><span class=\"text-danger\">Aciliyet Durumu: </span>");
#nullable restore
#line 14 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\Job\Index.cshtml"
                                                                                        Write(item.Urgency.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 15 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\Job\Index.cshtml"
                                    Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n                    <p class=\"text-right\">\r\n");
#nullable restore
#line 19 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\Job\Index.cshtml"
                         if (item.Reports.Count > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"btn btn-light btn-sm\" data-toggle=\"collapse\"");
            BeginWriteAttribute("href", " href=\"", 700, "\"", 730, 2);
            WriteAttributeValue("", 707, "#collapseExample-", 707, 17, true);
#nullable restore
#line 21 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\Job\Index.cshtml"
WriteAttributeValue("", 724, index, 724, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" aria-expanded=\"false\" aria-controls=\"collapseExample\">\r\n                                <i class=\"fas fa-caret-down mr-1\"></i>Raporlara Git <span class=\"badge badge-dark\">");
#nullable restore
#line 22 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\Job\Index.cshtml"
                                                                                                              Write(item.Reports.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </a>\r\n");
#nullable restore
#line 24 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\Job\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </p>\r\n                    <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 1073, "\"", 1100, 2);
            WriteAttributeValue("", 1078, "collapseExample-", 1078, 16, true);
#nullable restore
#line 26 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\Job\Index.cshtml"
WriteAttributeValue("", 1094, index, 1094, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        <table class=""table table-hover table-sm"">
                            <thead class=""thead-dark"">
                                <tr>
                                    <th>Tanım</th>
                                    <th>Açıklama</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 35 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\Job\Index.cshtml"
                                 foreach (var report in item.Reports)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 38 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\Job\Index.cshtml"
                                       Write(report.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 39 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\Job\Index.cshtml"
                                       Write(report.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 41 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\Job\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 48 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\Job\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<nav aria-label=\"Page navigation example\" class=\"float-right mr-5\">\r\n    <ul class=\"pagination\">\r\n");
#nullable restore
#line 54 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\Job\Index.cshtml"
         for (int i = 1; i <= ViewBag.TotalPage; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li");
            BeginWriteAttribute("class", " class=\"", 2205, "\"", 2261, 2);
            WriteAttributeValue("", 2213, "page-item", 2213, 9, true);
#nullable restore
#line 56 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\Job\Index.cshtml"
WriteAttributeValue(" ", 2222, ViewBag.ActivePage == i?"active":"", 2223, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30969d21a1cec6b504482c7cf34ff403a874fa3911666", async() => {
#nullable restore
#line 57 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\Job\Index.cshtml"
                                                                                                  Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-activePage", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\Job\Index.cshtml"
                                                                     WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activePage"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-activePage", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activePage"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 59 "C:\Users\Oxir\Desktop\WorkflowManagement\WorkflowManagement.WebUI\Areas\Member\Views\Job\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</nav>\r\n");
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