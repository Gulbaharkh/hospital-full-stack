#pragma checksum "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Service\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e94df812104d968e984b4a60710dbf4e4d408bc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Index), @"mvc.1.0.view", @"/Views/Service/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e94df812104d968e984b4a60710dbf4e4d408bc3", @"/Views/Service/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0796f798bcb0def51a6d81017bf20864053e7d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Service_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ServiceViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Service\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""slides"">
    <div style=""background-image: url(/img/slider/ximg_bg_1.jpg.pagespeed.ic.gttODn5s4U.webp);"" class=""slide-heading"">
        <div class=""overlay""></div>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12 col-sm-12 col-xs-12 text-center headings animated fadeInUp"">
                    <div class=""slider-text-inner"">
                        <h1>Medicare <strong>Departments</strong></h1>
                        <h2>html5 Bootstrap Templates Made by <a");
            BeginWriteAttribute("href", " href=\"", 600, "\"", 607, 0);
            EndWriteAttribute();
            WriteLiteral(@">prisma.com</a></h2>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div id=""appointment"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12 col-md-offset-2"">
                <div class=""appointment-area"">
                    <h2 class=""line-block"">Make an appointment</h2>
                    <p class=""btn-appointment"">
                        <a href=""/html/appointment.html""><span>Book an Appointment<i class=""far fa-calendar-alt"" aria-hidden=""true""></i></span></a>
                    </p>
                </div>
            </div>
        </div>
    </div>
</div>
<div id=""services"">
    <div class=""container"">
        <div class=""row animate-box aos-init aos-animate"" data-aos=""fade-up"" data-aos-duration=""500"">
            <div class=""col-md-6 text-center services-heading"">
                <h2>Our Services</h2>
                <p>A small river named Duden flows by their place and supplies it w");
            WriteLiteral("ith the necessary regelialia.</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 44 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Service\Index.cshtml"
             foreach (var service in @Model.Services)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-6 animate-box aos-init aos-animate\" data-aos=\"fade-up\" data-aos-duration=\"500\">\r\n                    <div class=\"services\">\r\n                        <span class=\"icon\"><i");
            BeginWriteAttribute("class", " class=\"", 2014, "\"", 2035, 1);
#nullable restore
#line 48 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Service\Index.cshtml"
WriteAttributeValue("", 2022, service.Icon, 2022, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></span>\r\n                        <div class=\"services-text\">\r\n                            <h3><a href=\"#\">");
#nullable restore
#line 50 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Service\Index.cshtml"
                                       Write(service.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                            <p>\r\n                                ");
#nullable restore
#line 52 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Service\Index.cshtml"
                           Write(service.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 57 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Service\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        </div>

    </div>
</div>
<div id=""preference"">
    <div class=""preference"">
        <div class=""img"" style=""background-image: url(/img/ximg_bg_3.jpg.pagespeed.ic.WB3q4HCwKf.webp);"">
        </div>
        <div class=""preference-text"">
            <div class=""preference-heading aos-init aos-animate"" data-aos=""fade-up"" data-aos-duration=""500"">
                <h2>What makes us best?</h2>
            </div>
            <div class=""row"">
");
#nullable restore
#line 73 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Service\Index.cshtml"
                 foreach (var preference in Model.Preferences)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-6 col-md-12 col-xs-12\">\r\n                        <div class=\"features animate-box aos-init aos-animate\" data-aos=\"fade-up\" data-aos-duration=\"1000\">\r\n                            <span class=\"icon text-center\"><i");
            BeginWriteAttribute("class", " class=\"", 3189, "\"", 3213, 1);
#nullable restore
#line 77 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Service\Index.cshtml"
WriteAttributeValue("", 3197, preference.Icon, 3197, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></span>\r\n                            <div class=\"features-text\">\r\n                                <h3>");
#nullable restore
#line 79 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Service\Index.cshtml"
                               Write(preference.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <p>");
#nullable restore
#line 80 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Service\Index.cshtml"
                              Write(preference.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 84 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Service\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>

</div>
<div id=""consultation"" style=""background-image: url(/img/slider/ximg_bg_6.jpg.pagespeed.ic.3lEgMuESZQ.webp);""
     data-stellar-background-ratio=""0.5"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12 content animate-box aos-init aos-animate"" data-aos=""fade-up"" data-aos-duration=""500"">
                <div class=""date-counter text-center"">
                    <h2>We offer <strong>Free Consultation</strong></h2>
                    <h3>By Dr. <strong>");
#nullable restore
#line 98 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Service\Index.cshtml"
                                  Write(Model.Consultations.Doctor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h3>\r\n                    <p class=\"count-area\">\r\n                        <span class=\"count-item\" id=\"days\">");
#nullable restore
#line 100 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Service\Index.cshtml"
                                                      Write(Model.Consultations.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                        <span class=\"count-item\" id=\"hours\">");
#nullable restore
#line 101 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Service\Index.cshtml"
                                                       Write(Model.Consultations.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <span class=\"count-item\" id=\"minutes\">");
#nullable restore
#line 102 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Service\Index.cshtml"
                                                         Write(Model.Consultations.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                        <span class=\"count-item\" id=\"seconds\">");
#nullable restore
#line 103 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Service\Index.cshtml"
                                                         Write(Model.Consultations.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </p>
                    <p><strong>Limited offer, Hurry Up!</strong></p>
                    <p>
                        <a href=""/html/appointment.html"" class=""btn btn-primary btn-lg btn-appointment"">
                            Book an Appointment <i class=""far fa-calendar-alt""
                                                   aria-hidden=""true""></i>
                        </a>
                    </p>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
