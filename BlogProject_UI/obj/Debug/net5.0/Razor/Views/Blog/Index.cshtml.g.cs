#pragma checksum "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85971e17c0218195d82369d3e7e1c76f71e834fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Views\_ViewImports.cshtml"
using BlogProject_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Views\_ViewImports.cshtml"
using BlogProject_UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Views\Blog\Index.cshtml"
using BlogProject_EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85971e17c0218195d82369d3e7e1c76f71e834fe", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1831ba975c6e3e8bd8bf8b6e72a3de21cd62a9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""main-content-w3layouts-agileits"">
    <div class=""container"">
        <h3 class=""tittle"">Bloglar</h3>
        <div class=""inner-sec"">
            <!--left-->
            <div class=""left-blog-info-w3layouts-agileits text-left"">
                <div class=""row"">
");
#nullable restore
#line 14 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Views\Blog\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4 card\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 592, "\"", 625, 2);
            WriteAttributeValue("", 599, "/Blog/BlogReadAll/", 599, 18, true);
#nullable restore
#line 17 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Views\Blog\Index.cshtml"
WriteAttributeValue("", 617, item.Id, 617, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 665, "\"", 707, 2);
            WriteAttributeValue("", 671, "/CoreBlogTema/images/", 671, 21, true);
#nullable restore
#line 18 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Views\Blog\Index.cshtml"
WriteAttributeValue("", 692, item.BlogImage, 692, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 739, "\"", 745, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                            <div class=""card-body"">
                                <ul class=""blog-icons my-4"">
                                    <li>
                                        <a href=""#"">
                                            <i class=""far fa-calendar-alt""></i>");
#nullable restore
#line 24 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Views\Blog\Index.cshtml"
                                                                          Write(item.BlogCreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </a>
                                    </li>
                                    <li class=""mx-2"">
                                        <a href=""#"">
                                            <i class=""far fa-comment""></i>");
#nullable restore
#line 29 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Views\Blog\Index.cshtml"
                                                                     Write(item.Comments.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </a>
                                    </li>

                                    <li>
                                        <a href=""#"">
                                            <i class=""far fa-thumbs-up""></i>");
#nullable restore
#line 35 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Views\Blog\Index.cshtml"
                                                                       Write(item.Likes.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""#"">
                                            <i class=""fas fa-user""></i>");
#nullable restore
#line 40 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Views\Blog\Index.cshtml"
                                                                  Write(item.Writer.WriterUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </a>\r\n                                    </li>\r\n\r\n\r\n                                </ul>\r\n                                <h5 class=\"text-black-50\">\r\n                                    <a href=\"single.html\">");
#nullable restore
#line 47 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Views\Blog\Index.cshtml"
                                                     Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </h5>\r\n                                <h5 class=\"card-title\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2393, "\"", 2426, 2);
            WriteAttributeValue("", 2400, "/Blog/BlogReadAll/", 2400, 18, true);
#nullable restore
#line 50 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2418, item.Id, 2418, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 50 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Views\Blog\Index.cshtml"
                                                                    Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </h5>\r\n");
#nullable restore
#line 52 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Views\Blog\Index.cshtml"
                                 if (item.BlogContent.Length > 100)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"card-text mb-3\">");
#nullable restore
#line 54 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Views\Blog\Index.cshtml"
                                                         Write(item.BlogContent.Substring(0, item.BlogContent.Substring(0, 100).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</p>\r\n");
#nullable restore
#line 55 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Views\Blog\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 2815, "\"", 2848, 2);
            WriteAttributeValue("", 2822, "/Blog/BlogReadAll/", 2822, 18, true);
#nullable restore
#line 56 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2840, item.Id, 2840, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Devamını Oku...</a>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 59 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Views\Blog\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <!--//left-->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
