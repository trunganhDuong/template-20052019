#pragma checksum "D:\Projects\Template_RealEstate_20052019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Slider\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4c83b942f6c9cd25f6e02614569a5b39d95a0ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_FrontEnd_Views_Shared_Components_Slider_Default), @"mvc.1.0.view", @"/Areas/FrontEnd/Views/Shared/Components/Slider/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/FrontEnd/Views/Shared/Components/Slider/Default.cshtml", typeof(AspNetCore.Areas_FrontEnd_Views_Shared_Components_Slider_Default))]
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
#line 1 "D:\Projects\Template_RealEstate_20052019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Slider\Default.cshtml"
using Template_RealEstate_20052019.Areas.FrontEnd.Models;

#line default
#line hidden
#line 2 "D:\Projects\Template_RealEstate_20052019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Slider\Default.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4c83b942f6c9cd25f6e02614569a5b39d95a0ca", @"/Areas/FrontEnd/Views/Shared/Components/Slider/Default.cshtml")]
    public class Areas_FrontEnd_Views_Shared_Components_Slider_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Slide>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(173, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "D:\Projects\Template_RealEstate_20052019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Slider\Default.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(199, 145, true);
            WriteLiteral("    <div id=\"home\" class=\"slider-area\">\r\n        <div class=\"bend niceties preview-2\">\r\n            <div id=\"ensign-nivoslider\" class=\"slides\">\r\n");
            EndContext();
#line 11 "D:\Projects\Template_RealEstate_20052019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Slider\Default.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(409, 24, true);
            WriteLiteral("                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 433, "\"", 454, 1);
#line 13 "D:\Projects\Template_RealEstate_20052019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Slider\Default.cshtml"
WriteAttributeValue("", 439, item.ImageName, 439, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(455, 40, true);
            WriteLiteral(" alt=\"\" title=\"#slider-direction-1\" />\r\n");
            EndContext();
#line 14 "D:\Projects\Template_RealEstate_20052019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Slider\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(514, 574, true);
            WriteLiteral(@"            </div>

            <!-- direction 1 -->
            <div id=""slider-direction-1"" class=""slider-direction slider-one"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-md-12 col-sm-12 col-xs-12"">
                            <div class=""slider-content"">
                                <!-- layer 1 -->
                                <div class=""layer-1-1 hidden-xs wow slideInDown"" data-wow-duration=""2s"" data-wow-delay="".2s"">
                                    <h2 class=""title1"">");
            EndContext();
            BeginContext(1089, 36, false);
#line 25 "D:\Projects\Template_RealEstate_20052019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Slider\Default.cshtml"
                                                  Write(projectInformation.Value.ProjectName);

#line default
#line hidden
            EndContext();
            BeginContext(1125, 267, true);
            WriteLiteral(@"</h2>
                                </div>
                                <!-- layer 2 -->
                                <div class=""layer-1-2 wow slideInUp"" data-wow-duration=""2s"" data-wow-delay="".1s"">
                                    <h1 class=""title2"">");
            EndContext();
            BeginContext(1393, 32, false);
#line 29 "D:\Projects\Template_RealEstate_20052019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Slider\Default.cshtml"
                                                  Write(projectInformation.Value.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1425, 3741, true);
            WriteLiteral(@"</h1>
                                </div>
                                <!-- layer 3 -->
                                <div class=""layer-1-3 hidden-xs wow slideInUp"" data-wow-duration=""2s"" data-wow-delay="".2s"">
                                    <a class=""ready-btn right-btn page-scroll"" href=""#contact"">Đăng ký nhận thông tin dự án</a>
                                    <a class=""ready-btn page-scroll"" href=""#overview"">Tổng quan</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <!-- direction 2 -->
            <div id=""slider-direction-2"" class=""slider-direction slider-two"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-md-12 col-sm-12 col-xs-12"">
                            <div class=""slider-content text-center"">
                                <!-- layer 1 -->
        ");
            WriteLiteral(@"                        <div class=""layer-1-1 hidden-xs wow slideInUp"" data-wow-duration=""2s"" data-wow-delay="".2s"">
                                    <h2 class=""title1"">The Best Business Information </h2>
                                </div>
                                <!-- layer 2 -->
                                <div class=""layer-1-2 wow slideInUp"" data-wow-duration=""2s"" data-wow-delay="".1s"">
                                    <h1 class=""title2"">We're In The Business Of Get Quality Business Service</h1>
                                </div>
                                <!-- layer 3 -->
                                <div class=""layer-1-3 hidden-xs wow slideInUp"" data-wow-duration=""2s"" data-wow-delay="".2s"">
                                    <a class=""ready-btn right-btn page-scroll"" href=""#services"">See Services</a>
                                    <a class=""ready-btn page-scroll"" href=""#about"">Learn More</a>
                                </div>
                           ");
            WriteLiteral(@" </div>
                        </div>
                    </div>
                </div>
            </div>

            <!-- direction 3 -->
            <div id=""slider-direction-3"" class=""slider-direction slider-two"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-md-12 col-sm-12 col-xs-12"">
                            <div class=""slider-content"">
                                <!-- layer 1 -->
                                <div class=""layer-1-1 hidden-xs wow slideInUp"" data-wow-duration=""2s"" data-wow-delay="".2s"">
                                    <h2 class=""title1"">The Best business Information </h2>
                                </div>
                                <!-- layer 2 -->
                                <div class=""layer-1-2 wow slideInUp"" data-wow-duration=""2s"" data-wow-delay="".1s"">
                                    <h1 class=""title2"">Helping Business Security  & Peace of Mind for Your Family</h1");
            WriteLiteral(@">
                                </div>
                                <!-- layer 3 -->
                                <div class=""layer-1-3 hidden-xs wow slideInUp"" data-wow-duration=""2s"" data-wow-delay="".2s"">
                                    <a class=""ready-btn right-btn page-scroll"" href=""#services"">See Services</a>
                                    <a class=""ready-btn page-scroll"" href=""#about"">Learn More</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- End Slider Area -->
");
            EndContext();
#line 94 "D:\Projects\Template_RealEstate_20052019\Template_RealEstate_20052019\Areas\FrontEnd\Views\Shared\Components\Slider\Default.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<ProjectInformation> projectInformation { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Slide>> Html { get; private set; }
    }
}
#pragma warning restore 1591
