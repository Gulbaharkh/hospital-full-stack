#pragma checksum "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Shared\Components\ContactPage\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11dce3ac240d4fd7275b7ff9b84b8cebc32259d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ContactPage_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ContactPage/Default.cshtml")]
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
#line 1 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\_ViewImports.cshtml"
using Final_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\_ViewImports.cshtml"
using Final_Project.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\_ViewImports.cshtml"
using Final_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11dce3ac240d4fd7275b7ff9b84b8cebc32259d6", @"/Views/Shared/Components/ContactPage/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0796f798bcb0def51a6d81017bf20864053e7d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ContactPage_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactInfo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-md-3\">\r\n    <p><span><i class=\"fas fa-map-marker-alt\"></i></span> ");
#nullable restore
#line 4 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Shared\Components\ContactPage\Default.cshtml"
                                                     Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(", <br> ");
#nullable restore
#line 4 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Shared\Components\ContactPage\Default.cshtml"
                                                                          Write(Model.AddressDetail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"col-md-3\">\r\n    <p><span><i class=\"fas fa-phone\"></i></span> <a href=\"tel://1234567920\">");
#nullable restore
#line 7 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Shared\Components\ContactPage\Default.cshtml"
                                                                       Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n</div>\r\n<div class=\"col-md-3\">\r\n    <p><span><i class=\"fas fa-envelope\"></i></span> <a href=\"mailto:info@yoursite.com\">");
#nullable restore
#line 10 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Shared\Components\ContactPage\Default.cshtml"
                                                                                  Write(Model.MailAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n</div>\r\n<div class=\"col-md-3\">\r\n    <p><span><i class=\"fas fa-globe\"></i></span> <a href=\"#\">");
#nullable restore
#line 13 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Shared\Components\ContactPage\Default.cshtml"
                                                        Write(Model.Website);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591