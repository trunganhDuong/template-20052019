#pragma checksum "D:\Projects\Template_RealEstate_20052019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Policy\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5df068ac060b91e53fed770287a7953f6483d3c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_FrontEnd_Views_Shared_Components_Policy_Default), @"mvc.1.0.view", @"/Areas/FrontEnd/Views/Shared/Components/Policy/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/FrontEnd/Views/Shared/Components/Policy/Default.cshtml", typeof(AspNetCore.Areas_FrontEnd_Views_Shared_Components_Policy_Default))]
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
#line 1 "D:\Projects\Template_RealEstate_20052019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Policy\Default.cshtml"
using Template_RealEstate_20052019.Extensions;

#line default
#line hidden
#line 2 "D:\Projects\Template_RealEstate_20052019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Policy\Default.cshtml"
using Template_RealEstate_20052019.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5df068ac060b91e53fed770287a7953f6483d3c7", @"/Areas/FrontEnd/Views/Shared/Components/Policy/Default.cshtml")]
    public class Areas_FrontEnd_Views_Shared_Components_Policy_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GridModel<Template_RealEstate_20052019.Models.Article>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(155, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\Projects\Template_RealEstate_20052019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Policy\Default.cshtml"
 if (Model?.Data != null && Model.Data.Any())
{

#line default
#line hidden
            BeginContext(207, 516, true);
            WriteLiteral(@"    <div id=""policy"" class=""blog-area"">
        <div class=""blog-inner area-padding"">
            <div class=""blog-overly""></div>
            <div class=""container "">
                <div class=""row"">
                    <div class=""col-md-12 col-sm-12 col-xs-12"">
                        <div class=""section-headline text-center"">
                            <h2>Chính sách mới nhất</h2>
                        </div>
                    </div>
                </div>
                <div class=""row"">
");
            EndContext();
#line 19 "D:\Projects\Template_RealEstate_20052019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Policy\Default.cshtml"
                     foreach (var item in Model.Data)
                    {

#line default
#line hidden
            BeginContext(801, 283, true);
            WriteLiteral(@"                        <div class=""col-md-4 col-sm-4 col-xs-12"">
                            <div class=""single-blog"">
                                <div class=""single-blog-img"">
                                    <a href=""blog.html"">
                                        ");
            EndContext();
            BeginContext(1084, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9e3bff2778d043a0902b9b395f78f9f8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1094, "~/upload/", 1094, 9, true);
#line 25 "D:\Projects\Template_RealEstate_20052019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Policy\Default.cshtml"
AddHtmlAttributeValue("", 1103, item.Avatar, 1103, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1124, 273, true);
            WriteLiteral(@"
                                    </a>
                                </div>
                                <div class=""blog-meta"">
                                    <span class=""date-type"">
                                        <i class=""fa fa-calendar""></i>");
            EndContext();
            BeginContext(1398, 48, false);
#line 30 "D:\Projects\Template_RealEstate_20052019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Policy\Default.cshtml"
                                                                 Write(item.CreatedDate.ToString("dd/MM/yyyy hh:mm:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(1446, 246, true);
            WriteLiteral("\r\n                                    </span>\r\n                                </div>\r\n                                <div class=\"blog-text\">\r\n                                    <h4>\r\n                                        <a href=\"blog.html\">");
            EndContext();
            BeginContext(1693, 17, false);
#line 35 "D:\Projects\Template_RealEstate_20052019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Policy\Default.cshtml"
                                                       Write(item.ArticleTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1710, 130, true);
            WriteLiteral("</a>\r\n                                    </h4>\r\n                                    <p>\r\n                                        ");
            EndContext();
            BeginContext(1841, 9, false);
#line 38 "D:\Projects\Template_RealEstate_20052019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Policy\Default.cshtml"
                                   Write(item.Sapo);

#line default
#line hidden
            EndContext();
            BeginContext(1850, 162, true);
            WriteLiteral("\r\n                                    </p>\r\n                                </div>\r\n                                <span>\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2012, "\"", 2083, 4);
            WriteAttributeValue("", 2019, "/chinh-sach-mua-nha/", 2019, 20, true);
#line 42 "D:\Projects\Template_RealEstate_20052019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Policy\Default.cshtml"
WriteAttributeValue("", 2039, item.ArticleTitle.Slugify(), 2039, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 2067, "/", 2067, 1, true);
#line 42 "D:\Projects\Template_RealEstate_20052019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Policy\Default.cshtml"
WriteAttributeValue("", 2068, item.ArticleId, 2068, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2084, 142, true);
            WriteLiteral(" class=\"ready-btn\">Xem thêm</a>\r\n                                </span>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 46 "D:\Projects\Template_RealEstate_20052019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Policy\Default.cshtml"
                    }

#line default
#line hidden
            BeginContext(2249, 72, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 51 "D:\Projects\Template_RealEstate_20052019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Policy\Default.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GridModel<Template_RealEstate_20052019.Models.Article>> Html { get; private set; }
    }
}
#pragma warning restore 1591
