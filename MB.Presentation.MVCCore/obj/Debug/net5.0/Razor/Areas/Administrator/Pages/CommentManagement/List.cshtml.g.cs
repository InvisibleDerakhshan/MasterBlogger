#pragma checksum "M:\INVISIBLE\source\repos\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b51776078051d6aed4fc55b4b44a8f3f5101d71e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Onion.Presentation.Areas.Administrator.Pages.CommentManagement.Areas_Administrator_Pages_CommentManagement_List), @"mvc.1.0.razor-page", @"/Areas/Administrator/Pages/CommentManagement/List.cshtml")]
namespace Onion.Presentation.Areas.Administrator.Pages.CommentManagement
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
#line 2 "M:\INVISIBLE\source\repos\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
using MB.Domain.CommentAgg;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b51776078051d6aed4fc55b4b44a8f3f5101d71e", @"/Areas/Administrator/Pages/CommentManagement/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"876095a2c6c38372b32de27da760084e90170f72", @"/Areas/Administrator/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Administrator_Pages_CommentManagement_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning float-left mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""card"">
    <div class=""card-header"">
        <h3 class=""float-left"">Comment List</h3>
    </div>
    <div class=""card-body"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Message</th>
                    <th>Article</th>
                    <th>Status</th>
                    <th>CreationDate</th>
                    <th>Operations</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 26 "M:\INVISIBLE\source\repos\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                 foreach (var comment in Model.Comments)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 29 "M:\INVISIBLE\source\repos\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                       Write(comment.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "M:\INVISIBLE\source\repos\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                       Write(comment.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "M:\INVISIBLE\source\repos\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                       Write(comment.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "M:\INVISIBLE\source\repos\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                       Write(comment.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 33 "M:\INVISIBLE\source\repos\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                       Write(comment.Article);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 35 "M:\INVISIBLE\source\repos\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                             if (comment.Status == Statuses.New)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fa fa-eye fa-2x text-info\"></i>\r\n");
#nullable restore
#line 38 "M:\INVISIBLE\source\repos\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "M:\INVISIBLE\source\repos\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                             if (comment.Status == Statuses.Cancelled)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fa fa-close fa-2x text-danger\"></i>\r\n");
#nullable restore
#line 42 "M:\INVISIBLE\source\repos\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "M:\INVISIBLE\source\repos\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                             if(comment.Status==Statuses.Confirmed)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fa fa-check fa-2x text-success\"></i>\r\n");
#nullable restore
#line 46 "M:\INVISIBLE\source\repos\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>");
#nullable restore
#line 48 "M:\INVISIBLE\source\repos\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                       Write(comment.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b51776078051d6aed4fc55b4b44a8f3f5101d71e8852", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "M:\INVISIBLE\source\repos\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                                                                                           WriteLiteral(comment.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 51 "M:\INVISIBLE\source\repos\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                             if (comment.Status == Statuses.New)
                            {
                               

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "M:\INVISIBLE\source\repos\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                                         
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 65 "M:\INVISIBLE\source\repos\MasterBlogger\MB.Presentation.MVCCore\Areas\Administrator\Pages\CommentManagement\List.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MB.Presentation.MVCCore.Areas.Administrator.Pages.CommentManagement.ListModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MB.Presentation.MVCCore.Areas.Administrator.Pages.CommentManagement.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MB.Presentation.MVCCore.Areas.Administrator.Pages.CommentManagement.ListModel>)PageContext?.ViewData;
        public MB.Presentation.MVCCore.Areas.Administrator.Pages.CommentManagement.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
