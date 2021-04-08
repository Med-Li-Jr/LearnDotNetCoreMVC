#pragma checksum "D:\LearningPaths\DotNet\LearnDotNetCoreMVC\LearnDotNetCoreMVC\Views\Organizations\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e776bb4324f93cff914d77a884914a4dc51a8aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Organizations_Index), @"mvc.1.0.view", @"/Views/Organizations/Index.cshtml")]
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
#line 1 "D:\LearningPaths\DotNet\LearnDotNetCoreMVC\LearnDotNetCoreMVC\Views\_ViewImports.cshtml"
using LearnDotNetCoreMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\LearningPaths\DotNet\LearnDotNetCoreMVC\LearnDotNetCoreMVC\Views\_ViewImports.cshtml"
using LearnDotNetCoreMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e776bb4324f93cff914d77a884914a4dc51a8aa", @"/Views/Organizations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1a32ecab8ced263ffd46e4bd14469b2df0f055f", @"/Views/_ViewImports.cshtml")]
    public class Views_Organizations_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LearnDotNetCoreMVC.Models.Entities.Organization>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "detailOrganization", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("blue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Organizations/indexOrganization.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\LearningPaths\DotNet\LearnDotNetCoreMVC\LearnDotNetCoreMVC\Views\Organizations\Index.cshtml"
  
    ViewData["Title"] = "Request Page";
    string HasrError = (string)(ViewData["HasError"] ?? "false");
    string MessageResponse = (string)(ViewData["MessageResponse"] ?? "pas d'erreur");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-content"">
    <div class=""main-content-inner"">
        <div class=""breadcrumbs ace-save-state"" id=""breadcrumbs"">
            <ul class=""breadcrumb"">
                <li>
                    <i class=""ace-icon fa fa-home home-icon""></i>
                    <a href=""#"">Home</a>
                </li>
                <li class=""active"">Organisations</li>
            </ul><!-- /.breadcrumb -->

        </div>

        <div class=""page-content"">

            <div class=""page-header"">
                <h1>
                    Dashboard Organisations
                </h1>
            </div><!-- /.page-header -->

            <div class=""row"">
                <div class=""col-xs-12"">
                    <!-- PAGE CONTENT BEGINS -->
                    <!-- div.dataTables_borderWrap -->
");
#nullable restore
#line 33 "D:\LearningPaths\DotNet\LearnDotNetCoreMVC\LearnDotNetCoreMVC\Views\Organizations\Index.cshtml"
                     if (!HasrError.Equals("true"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div>
                            <table id=""dynamic-table"" class=""table table-striped table-bordered table-hover"">
                                <thead>
                                    <tr>
                                        <th>Nom</th>
                                        <th>Email</th>
                                        <th>Account Type</th>
                                        <th class=""hidden-480"">Account Status</th>

                                        <th>Action</th>
                                    </tr>
                                </thead>

                                <tbody id=""tbodyListeDemande"">

");
#nullable restore
#line 50 "D:\LearningPaths\DotNet\LearnDotNetCoreMVC\LearnDotNetCoreMVC\Views\Organizations\Index.cshtml"
                                      
                                        foreach (var organization in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n\r\n                                                <td>\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e776bb4324f93cff914d77a884914a4dc51a8aa7768", async() => {
#nullable restore
#line 56 "D:\LearningPaths\DotNet\LearnDotNetCoreMVC\LearnDotNetCoreMVC\Views\Organizations\Index.cshtml"
                                                                                                                    Write(organization.NameFr);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-value", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "D:\LearningPaths\DotNet\LearnDotNetCoreMVC\LearnDotNetCoreMVC\Views\Organizations\Index.cshtml"
                                                                                           WriteLiteral(organization.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["value"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-value", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["value"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 59 "D:\LearningPaths\DotNet\LearnDotNetCoreMVC\LearnDotNetCoreMVC\Views\Organizations\Index.cshtml"
                                               Write(organization.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n\r\n                                                <td class=\"hidden-480\">\r\n");
#nullable restore
#line 63 "D:\LearningPaths\DotNet\LearnDotNetCoreMVC\LearnDotNetCoreMVC\Views\Organizations\Index.cshtml"
                                                     if (organization.AccountType.Equals("client"))
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <span class=\"label label-sm label-success\">");
#nullable restore
#line 65 "D:\LearningPaths\DotNet\LearnDotNetCoreMVC\LearnDotNetCoreMVC\Views\Organizations\Index.cshtml"
                                                                                              Write(organization.AccountType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 66 "D:\LearningPaths\DotNet\LearnDotNetCoreMVC\LearnDotNetCoreMVC\Views\Organizations\Index.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <span class=\"label label-sm label-warning\">");
#nullable restore
#line 69 "D:\LearningPaths\DotNet\LearnDotNetCoreMVC\LearnDotNetCoreMVC\Views\Organizations\Index.cshtml"
                                                                                              Write(organization.AccountType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 70 "D:\LearningPaths\DotNet\LearnDotNetCoreMVC\LearnDotNetCoreMVC\Views\Organizations\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </td>\r\n                                                <td class=\"hidden-480\">\r\n");
#nullable restore
#line 73 "D:\LearningPaths\DotNet\LearnDotNetCoreMVC\LearnDotNetCoreMVC\Views\Organizations\Index.cshtml"
                                                     if (organization.AccountStatus.Equals("active"))
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <span class=\"label label-sm label-success\">");
#nullable restore
#line 75 "D:\LearningPaths\DotNet\LearnDotNetCoreMVC\LearnDotNetCoreMVC\Views\Organizations\Index.cshtml"
                                                                                              Write(organization.AccountStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 76 "D:\LearningPaths\DotNet\LearnDotNetCoreMVC\LearnDotNetCoreMVC\Views\Organizations\Index.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <span class=\"label label-sm label-warning\">");
#nullable restore
#line 79 "D:\LearningPaths\DotNet\LearnDotNetCoreMVC\LearnDotNetCoreMVC\Views\Organizations\Index.cshtml"
                                                                                              Write(organization.AccountStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 80 "D:\LearningPaths\DotNet\LearnDotNetCoreMVC\LearnDotNetCoreMVC\Views\Organizations\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    <div>\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e776bb4324f93cff914d77a884914a4dc51a8aa15034", async() => {
                WriteLiteral("\r\n                                                            <i class=\"ace-icon fa fa-search-plus bigger-130\"></i>\r\n                                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-value", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "D:\LearningPaths\DotNet\LearnDotNetCoreMVC\LearnDotNetCoreMVC\Views\Organizations\Index.cshtml"
                                                                                                            WriteLiteral(organization.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["value"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-value", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["value"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                        <a class=\"red\" href=\"#\"");
            BeginWriteAttribute("onclick", "\r\n                                                           onclick=\"", 4586, "\"", 4687, 3);
            WriteAttributeValue("", 4656, "deleteModal(\'", 4656, 13, true);
#nullable restore
#line 89 "D:\LearningPaths\DotNet\LearnDotNetCoreMVC\LearnDotNetCoreMVC\Views\Organizations\Index.cshtml"
WriteAttributeValue("", 4669, organization.Id, 4669, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4685, "\')", 4685, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                                            <i class=""ace-icon fa fa-trash-o bigger-130""></i>
                                                        </a>
                                                    </div>
                                                </td>
                                            </tr>
");
#nullable restore
#line 95 "D:\LearningPaths\DotNet\LearnDotNetCoreMVC\LearnDotNetCoreMVC\Views\Organizations\Index.cshtml"

                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n");
#nullable restore
#line 101 "D:\LearningPaths\DotNet\LearnDotNetCoreMVC\LearnDotNetCoreMVC\Views\Organizations\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""error-container"">
                            <div class=""well"">
                                <h1 class=""grey lighter smaller"">
                                    <span class=""blue bigger-125"">
                                        <i class=""ace-icon fa fa-sitemap""></i>
                                    </span>
                                    ");
#nullable restore
#line 110 "D:\LearningPaths\DotNet\LearnDotNetCoreMVC\LearnDotNetCoreMVC\Views\Organizations\Index.cshtml"
                               Write(MessageResponse);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </h1>\r\n\r\n                                <hr />\r\n\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 117 "D:\LearningPaths\DotNet\LearnDotNetCoreMVC\LearnDotNetCoreMVC\Views\Organizations\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <div id=""modal-form-confirm-delete"" class=""modal"" tabindex=""-1"">
                        <div class=""modal-dialog"">
                            <div class=""modal-content"">
                                <div class=""modal-header"">
                                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                                    <h4 class=""blue"">Confirm Delete</h4>
                                </div>

                                <div class=""modal-body"">
                                    <div class=""row"">

                                        <div class=""error-container"">
                                            <div class=""well"">
                                                <h2 class=""lighter smaller""> <span class=""blue"">Do you want to delete ?</span></h2>
                                            </div>
                                        </div>

                                    </div>
           ");
            WriteLiteral("                     </div>\r\n\r\n                                <div class=\"modal-footer\" id=\"footerModal\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e776bb4324f93cff914d77a884914a4dc51a8aa21567", async() => {
                WriteLiteral("\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- PAGE CONTENT ENDS -->
                </div><!-- /.col -->
            </div><!-- /.row -->
        </div><!-- /.page-content -->
    </div>
</div><!-- /.main-content -->


");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e776bb4324f93cff914d77a884914a4dc51a8aa23274", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("defer", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LearnDotNetCoreMVC.Models.Entities.Organization>> Html { get; private set; }
    }
}
#pragma warning restore 1591
