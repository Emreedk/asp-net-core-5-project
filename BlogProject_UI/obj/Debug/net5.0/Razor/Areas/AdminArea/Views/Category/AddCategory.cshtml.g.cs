#pragma checksum "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Areas\AdminArea\Views\Category\AddCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a817312a53c9017acbca6d295e8b8a7d89e947a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminArea_Views_Category_AddCategory), @"mvc.1.0.view", @"/Areas/AdminArea/Views/Category/AddCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a817312a53c9017acbca6d295e8b8a7d89e947a", @"/Areas/AdminArea/Views/Category/AddCategory.cshtml")]
    public class Areas_AdminArea_Views_Category_AddCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogProject_EntityLayer.Concrete.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Areas\AdminArea\Views\Category\AddCategory.cshtml"
  
    ViewData["Title"] = "AddCategory";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Areas\AdminArea\Views\Category\AddCategory.cshtml"
 using (Html.BeginForm("AddCategory", "Category", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Areas\AdminArea\Views\Category\AddCategory.cshtml"
Write(Html.Label("Kategori Adı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Areas\AdminArea\Views\Category\AddCategory.cshtml"
                               ;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Areas\AdminArea\Views\Category\AddCategory.cshtml"
Write(Html.TextBoxFor(x => x.CategoryName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Areas\AdminArea\Views\Category\AddCategory.cshtml"
                                                                          ;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Areas\AdminArea\Views\Category\AddCategory.cshtml"
Write(Html.ValidationMessageFor(x => x.CategoryName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 15 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Areas\AdminArea\Views\Category\AddCategory.cshtml"
Write(Html.Label("Kategori Açıklaması"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Areas\AdminArea\Views\Category\AddCategory.cshtml"
                                      ;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Areas\AdminArea\Views\Category\AddCategory.cshtml"
Write(Html.TextAreaFor(x => x.CategoryDescription, 15, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Areas\AdminArea\Views\Category\AddCategory.cshtml"
                                                                                         ;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Areas\AdminArea\Views\Category\AddCategory.cshtml"
Write(Html.ValidationMessageFor(x => x.CategoryDescription, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\">Kaydet</button>\r\n");
#nullable restore
#line 20 "C:\Users\emree\Desktop\Emre-Github\asp-net-core-5-project\BlogProject_UI\Areas\AdminArea\Views\Category\AddCategory.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogProject_EntityLayer.Concrete.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
