#pragma checksum "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c439551b90ecd5e8288cd6b5d7e4890b9f7a9323"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c439551b90ecd5e8288cd6b5d7e4890b9f7a9323", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0796f798bcb0def51a6d81017bf20864053e7d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    var count = 0;
 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"slider\">\r\n    <div id=\"carouselExampleIndicators\" class=\"carousel slide\" data-ride=\"carousel\">\r\n        <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 9 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
             foreach (var slider in Model.Sliders)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 317, "\"", 367, 2);
            WriteAttributeValue("", 325, "carousel-item", 325, 13, true);
#nullable restore
#line 11 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 338, (count == 0)? "active":"", 339, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"slider-item\"");
            BeginWriteAttribute("style", " style=\"", 415, "\"", 561, 12);
            WriteAttributeValue("", 423, "background-image:", 423, 17, true);
            WriteAttributeValue(" ", 440, "url(/img/slider/", 441, 17, true);
#nullable restore
#line 12 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
WriteAttributeValue("", 457, slider.ImageURL, 457, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 473, ");", 473, 2, true);
            WriteAttributeValue(" ", 475, "width:", 476, 7, true);
            WriteAttributeValue(" ", 482, "100%;", 483, 6, true);
            WriteAttributeValue(" ", 488, "background-repeat:", 489, 19, true);
            WriteAttributeValue(" ", 507, "no-repeat;", 508, 11, true);
            WriteAttributeValue(" ", 518, "background-size:", 519, 17, true);
            WriteAttributeValue(" ", 535, "cover;", 536, 7, true);
            WriteAttributeValue(" ", 542, "min-height:", 543, 12, true);
            WriteAttributeValue(" ", 554, "800px;", 555, 7, true);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""container"">
                            <div class=""row"">
                                <div data-aos=""fade-up"" data-aos-duration=""500"" class=""col-md-8 col-md-offset-2 col-md-pull-2 slider-text aos-init aos-animate"">
                                    <div class=""slider-text"">
                                        <h1>");
#nullable restore
#line 17 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
                                       Write(slider.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                                        <h2>\r\n                                            ");
#nullable restore
#line 19 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
                                       Write(Html.Raw(@slider.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </h2>
                                        <p><a class=""btn btn-primary btn-lg btn-make"" href=""/html/appointment.html""><span>Make an Appointment</span></a></p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
");
#nullable restore
#line 29 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
            Write(count++);

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
                          ;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>
</div>
<div id=""intro"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""intro animate-box aos-init aos-animate"" data-aos=""fade-up"" data-aos-duration=""500"">
");
#nullable restore
#line 48 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
                     foreach (var intro in Model.SliderIntros)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"intro-box\">\r\n                            <div class=\"intro-text\">\r\n                                <h3>");
#nullable restore
#line 52 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
                               Write(intro.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <p>");
#nullable restore
#line 53 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
                              Write(Html.Raw(@intro.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                            <span class=\"icon\"><i");
            BeginWriteAttribute("class", " class=\"", 2695, "\"", 2714, 1);
#nullable restore
#line 55 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
WriteAttributeValue("", 2703, intro.Icon, 2703, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></span>\r\n                            <a href=\"#\">Read more</a>\r\n                        </div>\r\n");
#nullable restore
#line 58 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>

<div id=""about"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-4"">
                <div class=""about-img"">
                    <img src=""/img/xabout.jpg.pagespeed.ic.Fgk92-nbFh.webp"" style=""width: 100%;""");
            BeginWriteAttribute("alt", " alt=\"", 3168, "\"", 3174, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
            </div>
            <div class=""col-1""></div>
            <div class=""col-md-7"">
                <h2>About Medicare</h2>
                <p>
                    Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the
                    blind texts.
                </p>
                <div class=""accordion"">
");
#nullable restore
#line 81 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
                     for (int i = 0; i < Model.Abouts.Count(); i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 3701, "\"", 3754, 2);
            WriteAttributeValue("", 3709, "accordion__header", 3709, 17, true);
#nullable restore
#line 83 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 3726, (i == 0)? "is-active":"", 3727, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <h2>");
#nullable restore
#line 84 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
                           Write(Model.Abouts[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n                            <span class=\"accordion__toggle\"></span>\r\n                        </div>\r\n                        <div");
            BeginWriteAttribute("class", " class=\"", 3950, "\"", 4001, 2);
            WriteAttributeValue("", 3958, "accordion__body", 3958, 15, true);
#nullable restore
#line 88 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 3973, (i == 0)? "is-active":"", 3974, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <p>\r\n                                ");
#nullable restore
#line 90 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
                           Write(Html.Raw(@Model.Abouts[i].Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n");
#nullable restore
#line 93 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
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
                    <p class=""btn btn-app"">
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
                <p>A small river named Duden flows by their place and supplies it with the necessary regelialia.</p>
            </div>
            WriteLiteral("\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 122 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
             foreach (var service in @Model.Services)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-6 animate-box aos-init aos-animate\" data-aos=\"fade-up\" data-aos-duration=\"500\">\r\n                    <div class=\"services\">\r\n                        <span class=\"icon\"><i");
            BeginWriteAttribute("class", " class=\"", 5552, "\"", 5573, 1);
#nullable restore
#line 126 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
WriteAttributeValue("", 5560, service.Icon, 5560, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></span>\r\n                        <div class=\"services-text\">\r\n                            <h3><a href=\"#\">");
#nullable restore
#line 128 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
                                       Write(service.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                            <p>\r\n                                ");
#nullable restore
#line 130 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
                           Write(Html.Raw(service.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 135 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n<div id=\"preference\">\r\n    <div class=\"preference\">\r\n        <div class=\"img\"");
            BeginWriteAttribute("style", " style=\"", 6059, "\"", 6122, 4);
            WriteAttributeValue("", 6067, "background-image:", 6067, 17, true);
            WriteAttributeValue(" ", 6084, "url(/img/", 6085, 10, true);
#nullable restore
#line 144 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
WriteAttributeValue("", 6094, Model.PreferenceImgs.Image, 6094, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6121, ")", 6121, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
        </div>
        <div class=""preference-text"">
            <div class=""preference-heading aos-init aos-animate"" data-aos=""fade-up"" data-aos-duration=""500"">
                <h2>What makes us best?</h2>
            </div>
            <div class=""row"">
");
#nullable restore
#line 151 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
                 foreach (var preference in Model.Preferences)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-6 col-md-12 col-xs-12\">\r\n                        <div class=\"features animate-box aos-init aos-animate\" data-aos=\"fade-up\" data-aos-duration=\"1000\">\r\n                            <span class=\"icon text-center\"><i");
            BeginWriteAttribute("class", " class=\"", 6721, "\"", 6745, 1);
#nullable restore
#line 155 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
WriteAttributeValue("", 6729, preference.Icon, 6729, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></span>\r\n                            <div class=\"features-text\">\r\n                                <h3>");
#nullable restore
#line 157 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
                               Write(preference.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <p>");
#nullable restore
#line 158 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
                              Write(Html.Raw(preference.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 162 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>

</div>
<div id=""doctor"">
    <div class=""container"">
        <div class=""row aos-init aos-animate"" data-aos=""fade-up"" data-aos-duration=""500"">
            <div class=""col-md-6 text-center doctor-heading"">
                <h2>Well experienced doctors</h2>
                <p>A small river named Duden flows by their place and supplies it with the necessary regelialia.</p>
            </div>
        </div>
        <div class=""row animate-box"">
");
#nullable restore
#line 177 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
             foreach (var doctor in @Model.Doctors)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-3 col-sm-6 col-xs-12 text-center aos-init aos-animate\" data-aos=\"fade-up\" data-aos-duration=\"500\">\r\n                    <div class=\"doctor\">\r\n                        <div class=\"img\"");
            BeginWriteAttribute("style", " style=\"", 7855, "\"", 7912, 4);
            WriteAttributeValue("", 7863, "background-image:", 7863, 17, true);
            WriteAttributeValue(" ", 7880, "url(/img/slider/", 7881, 17, true);
#nullable restore
#line 181 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
WriteAttributeValue("", 7897, doctor.Image, 7897, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7910, ");", 7910, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"doctor-info\">\r\n                            <h3><a href=\"#\">");
#nullable restore
#line 184 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
                                       Write(doctor.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                            <span>");
#nullable restore
#line 185 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
                             Write(Html.Raw(doctor.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <ul class=\"doctor-social\">\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 8231, "\"", 8254, 1);
#nullable restore
#line 187 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
WriteAttributeValue("", 8238, doctor.Facebook, 8238, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-facebook-f\"></i></a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 8338, "\"", 8360, 1);
#nullable restore
#line 188 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
WriteAttributeValue("", 8345, doctor.Twitter, 8345, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-twitter\"></i></a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 8441, "\"", 8464, 1);
#nullable restore
#line 189 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
WriteAttributeValue("", 8448, doctor.Linkedin, 8448, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-linkedin-in\"></i></a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 8549, "\"", 8573, 1);
#nullable restore
#line 190 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
WriteAttributeValue("", 8556, doctor.Instagram, 8556, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-instagram\"></i></a></li>\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 195 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>

</div>
<div id=""counter"" class=""counter-section animated""
     style=""background-image: url(/img/slider/ximg_bg_2.jpg.pagespeed.ic.oy6InjPz6E.webp); background-position: 50% 50%;""
     data-stellar-background-ratio=""0.5"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""col-md-10 center aos-init aos-animate"" data-aos=""fade-up"" data-aos-duration=""500"">
            <div class=""row"">
");
#nullable restore
#line 207 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
                 foreach (var counter in Model.Counters)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-3 col-sm-6 text-center\">\r\n                        <div class=\"counter-info\">\r\n                            <span class=\"icon\"><i");
            BeginWriteAttribute("class", " class=\"", 9448, "\"", 9469, 1);
#nullable restore
#line 211 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
WriteAttributeValue("", 9456, counter.Icon, 9456, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></span>\r\n                            <span class=\"counter\">");
#nullable restore
#line 212 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
                                             Write(counter.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <span class=\"counter-name\">");
#nullable restore
#line 213 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
                                                  Write(counter.Item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 216 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>
<div id=""blog"">
    <div class=""container"">
        <div class=""row animate-box aos-init aos-animate"" data-aos=""fade-up"" data-aos-duration=""500"">
            <div class=""col-md-6 text-center blog-heading"">
                <h2>Recent blog</h2>
                <p>
                    Dignissimos asperiores vitae velit veniam totam fuga molestias accusamus alias autem provident. Odit ab
                    aliquam dolor eius.
                </p>
            </div>
        </div>
        <div class=""row aos-init aos-animate"" data-aos=""fade-up"" data-aos-duration=""1000"">
");
#nullable restore
#line 233 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
             foreach (var blog in Model.Blogs)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4\">\r\n                    <div class=\"blog-content\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 10531, "\"", 10538, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"blog-img\"");
            BeginWriteAttribute("style", " style=\"", 10556, "\"", 10604, 4);
            WriteAttributeValue("", 10564, "background-image:", 10564, 17, true);
            WriteAttributeValue(" ", 10581, "url(/img/", 10582, 10, true);
#nullable restore
#line 237 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
WriteAttributeValue("", 10591, blog.Image, 10591, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 10602, ");", 10602, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral("                        </a>\r\n                        <div class=\"blog-text\">\r\n                            <h3><a href=\"blog.html\">");
#nullable restore
#line 244 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
                                               Write(blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                            <p>");
#nullable restore
#line 245 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
                          Write(Html.Raw(@blog.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p><a href=\"#\">Read more <i class=\"fas fa-chevron-right\"></i></a></p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 250 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral(@"<div id=""consultation"" style=""background-image: url(/img/slider/ximg_bg_6.jpg.pagespeed.ic.3lEgMuESZQ.webp);""
     data-stellar-background-ratio=""0.5"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12 content animate-box aos-init aos-animate"" data-aos=""fade-up"" data-aos-duration=""500"">
                <div id=""time"" class=""date-counter text-center"">
                    <h2>We offer <strong>Free Consultation</strong></h2>
                    <h3>By Dr. <strong>");
#nullable restore
#line 265 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
                                  Write(Model.Consultations.Doctor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h3>\r\n                    <p class=\"count-area\">\r\n                        <span class=\"count-item\" id=\"days\">");
#nullable restore
#line 267 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
                                                      Write(Model.Consultations.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                        <span class=\"count-item\" id=\"hours\">");
#nullable restore
#line 268 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
                                                       Write(Model.Consultations.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <span class=\"count-item\" id=\"minutes\">");
#nullable restore
#line 269 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
                                                         Write(Model.Consultations.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                        <span class=\"count-item\" id=\"seconds\">");
#nullable restore
#line 270 "C:\Users\Gulbahar\source\repos\Final Project\Final Project\Views\Home\Index.cshtml"
                                                         Write(Model.Consultations.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </p>

                    <p><strong>Limited offer, Hurry Up!</strong></p>
                    <p>
                        <a id=""btn-submit"" href=""/html/appointment.html"" class=""btn btn-primary btn-lg btn-appointment"">
                            Book an Appointment <i class=""far fa-calendar-alt""
                                                   aria-hidden=""true""></i>
                        </a>
                    </p>
                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591