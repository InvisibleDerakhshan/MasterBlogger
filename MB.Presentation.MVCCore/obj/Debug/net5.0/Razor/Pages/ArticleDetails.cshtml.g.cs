#pragma checksum "M:\INVISIBLE\source\repos\MasterBlogger\MB.Presentation.MVCCore\Pages\ArticleDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d35123ec96d0e65d1dd9a80725fe2799cd7ab79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MB.Presentation.MVCCore.Pages.Pages_ArticleDetails), @"mvc.1.0.razor-page", @"/Pages/ArticleDetails.cshtml")]
namespace MB.Presentation.MVCCore.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{Id:long}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d35123ec96d0e65d1dd9a80725fe2799cd7ab79", @"/Pages/ArticleDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff777bbf70474f80581643d8b2fd7fe4e1f06fbf", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_ArticleDetails : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("commenting-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "M:\INVISIBLE\source\repos\MasterBlogger\MB.Presentation.MVCCore\Pages\ArticleDetails.cshtml"
  
    ViewData["Title"] = "ArticleDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<main class=\"post blog-post col-lg-12\">\r\n    <div class=\"container\">\r\n        <div class=\"post-single\">\r\n            <div class=\"post-thumbnail\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 298, "\"", 324, 1);
#nullable restore
#line 12 "M:\INVISIBLE\source\repos\MasterBlogger\MB.Presentation.MVCCore\Pages\ArticleDetails.cshtml"
WriteAttributeValue("", 304, Model.Article.Image, 304, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 325, "\"", 351, 1);
#nullable restore
#line 12 "M:\INVISIBLE\source\repos\MasterBlogger\MB.Presentation.MVCCore\Pages\ArticleDetails.cshtml"
WriteAttributeValue("", 331, Model.Article.Title, 331, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 352, "\"", 380, 1);
#nullable restore
#line 12 "M:\INVISIBLE\source\repos\MasterBlogger\MB.Presentation.MVCCore\Pages\ArticleDetails.cshtml"
WriteAttributeValue("", 360, Model.Article.Title, 360, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\r\n            </div>\r\n            <div class=\"post-details\">\r\n                <div class=\"post-meta d-flex justify-content-between\">\r\n                    <div class=\"category\">\r\n                        <a href=\"#\">");
#nullable restore
#line 17 "M:\INVISIBLE\source\repos\MasterBlogger\MB.Presentation.MVCCore\Pages\ArticleDetails.cshtml"
                               Write(Model.Article.ArticleCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </div>\r\n                </div>\r\n                <h1>\r\n                    ");
#nullable restore
#line 21 "M:\INVISIBLE\source\repos\MasterBlogger\MB.Presentation.MVCCore\Pages\ArticleDetails.cshtml"
               Write(Model.Article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <a href=""#"">
                        <i class=""fa fa-bookmark-o""></i>
                    </a>
                </h1>
                <div class=""post-footer d-flex align-items-center flex-column flex-sm-row"">
                    <div class=""d-flex align-items-center flex-wrap"">
                        <div class=""date"">
                            <i class=""icon-clock""></i> ");
#nullable restore
#line 29 "M:\INVISIBLE\source\repos\MasterBlogger\MB.Presentation.MVCCore\Pages\ArticleDetails.cshtml"
                                                  Write(Model.Article.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"comments meta-last\"><i class=\"icon-comment\"></i>12</div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"post-body\">\r\n                    <p>\r\n                        ");
#nullable restore
#line 35 "M:\INVISIBLE\source\repos\MasterBlogger\MB.Presentation.MVCCore\Pages\ArticleDetails.cshtml"
                   Write(Model.Article.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    ");
#nullable restore
#line 37 "M:\INVISIBLE\source\repos\MasterBlogger\MB.Presentation.MVCCore\Pages\ArticleDetails.cshtml"
               Write(Model.Article.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n                <div class=\"add-comment\">\r\n                    <header>\r\n                        <h3 class=\"h6\">Leave a reply</h3>\r\n                    </header>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d35123ec96d0e65d1dd9a80725fe2799cd7ab797923", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""form-group col-md-6"">
                                <input type=""text"" name=""Name"" id=""Name"" placeholder=""Name"" class=""form-control"">
                            </div>
                            <div class=""form-group col-md-6"">
                                <input type=""email"" name=""Email"" id=""Email"" placeholder=""Email Address (will not be published)"" class=""form-control"">
                            </div>
                            <div class=""form-group col-md-12"">
                                <textarea name=""Message"" id=""Message"" placeholder=""Type your comment"" class=""form-control""></textarea>
                            </div>
                            <input type=""hidden"" name=""ArticleId""");
                BeginWriteAttribute("value", " value=\"", 3899, "\"", 3924, 1);
#nullable restore
#line 81 "M:\INVISIBLE\source\repos\MasterBlogger\MB.Presentation.MVCCore\Pages\ArticleDetails.cshtml"
WriteAttributeValue("", 3907, Model.Article.Id, 3907, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"/>
                            <div class=""form-group col-md-12"">
                                <button type=""submit"" class=""btn btn-secondary"">Submit Comment</button>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MB.Presentation.MVCCore.Pages.ArticleDetailsModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MB.Presentation.MVCCore.Pages.ArticleDetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MB.Presentation.MVCCore.Pages.ArticleDetailsModel>)PageContext?.ViewData;
        public MB.Presentation.MVCCore.Pages.ArticleDetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591