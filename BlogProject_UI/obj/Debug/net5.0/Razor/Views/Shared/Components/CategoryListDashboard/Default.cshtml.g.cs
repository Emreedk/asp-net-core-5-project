#pragma checksum "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Views\Shared\Components\CategoryListDashboard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "417c372da34d942a3a030ff13e1d12a1b9c3407b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryListDashboard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryListDashboard/Default.cshtml")]
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
#line 1 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
using BlogProject_EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"417c372da34d942a3a030ff13e1d12a1b9c3407b", @"/Views/Shared/Components/CategoryListDashboard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1831ba975c6e3e8bd8bf8b6e72a3de21cd62a9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryListDashboard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Project Status</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th> # </th>
                                <th>Kategori Adı</th>
                                <th>Blog Sayısı</th>
                                <th>Durum</th>
                                <th>işlemler</th>
                            </tr>
                        </thead>

                        <tbody>
");
#nullable restore
#line 22 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 25 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 26 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
                                   Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 27 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
                                   Write(item.Blogs.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n");
#nullable restore
#line 29 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
                                         if (item.CategoryStatus)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"badge badge-success\">Aktif</span>\r\n");
#nullable restore
#line 32 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"badge badge-secondary\">Pasif</span>\r\n");
#nullable restore
#line 36 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </td>
                                    <td>
                                        <div class=""progress"">
                                            <div class=""progress-bar bg-gradient-success"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                        </div>
                                    </td>
                                </tr>
");
#nullable restore
#line 44 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Views\Shared\Components\CategoryListDashboard\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
