#pragma checksum "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.20_BlogProject\BlogProject_UI\Views\Writer\WriterEditProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4e8450e2113ade303878e34794cbc77deef5032"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Writer_WriterEditProfile), @"mvc.1.0.view", @"/Views/Writer/WriterEditProfile.cshtml")]
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
#line 1 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.20_BlogProject\BlogProject_UI\Views\_ViewImports.cshtml"
using BlogProject_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.20_BlogProject\BlogProject_UI\Views\_ViewImports.cshtml"
using BlogProject_UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4e8450e2113ade303878e34794cbc77deef5032", @"/Views/Writer/WriterEditProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1831ba975c6e3e8bd8bf8b6e72a3de21cd62a9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Writer_WriterEditProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogProject_EntityLayer.Concrete.Writer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.20_BlogProject\BlogProject_UI\Views\Writer\WriterEditProfile.cshtml"
  
    ViewData["Title"] = "WriterEditProfile";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.20_BlogProject\BlogProject_UI\Views\Writer\WriterEditProfile.cshtml"
 using (Html.BeginForm("WriterEditProfile", "Writer", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12 grid-margin stretch-card\">\r\n\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h4 class=\"card-title\">Profil Güncelle</h4>\r\n                <br />\r\n                ");
#nullable restore
#line 15 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.20_BlogProject\BlogProject_UI\Views\Writer\WriterEditProfile.cshtml"
           Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4e8450e2113ade303878e34794cbc77deef50324927", async() => {
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputName1\">Adınız</label>\r\n                        ");
#nullable restore
#line 19 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.20_BlogProject\BlogProject_UI\Views\Writer\WriterEditProfile.cshtml"
                   Write(Html.TextBoxFor(x => x.WriterName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputName1\">Soyadınız</label>\r\n                        ");
#nullable restore
#line 23 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.20_BlogProject\BlogProject_UI\Views\Writer\WriterEditProfile.cshtml"
                   Write(Html.TextBoxFor(x => x.WriterSurname, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputName1\">Kullanıcı Adınız</label>\r\n                        ");
#nullable restore
#line 27 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.20_BlogProject\BlogProject_UI\Views\Writer\WriterEditProfile.cshtml"
                   Write(Html.TextBoxFor(x => x.WriterUserName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputEmail3\">Email</label>\r\n                        ");
#nullable restore
#line 31 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.20_BlogProject\BlogProject_UI\Views\Writer\WriterEditProfile.cshtml"
                   Write(Html.TextBoxFor(x => x.WriterMail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputPassword4\">Şifre</label>\r\n                        ");
#nullable restore
#line 36 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.20_BlogProject\BlogProject_UI\Views\Writer\WriterEditProfile.cshtml"
                   Write(Html.TextBoxFor(x => x.WriterPassword, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                    </div>
                    <div class=""form-group"">
                        <label>Profil Fotoğrafı</label>
                        <input type=""file"" name=""img[]"" class=""file-upload-default"">
                        <div class=""input-group col-xs-12"">
                            <input type=""text"" class=""form-control file-upload-info"" disabled placeholder=""Resim Seç"">
                            <span class=""input-group-append"">
                                <button class=""file-upload-browse btn btn-gradient-primary"" type=""button"">Yükle</button>
                            </span>
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label for=""exampleTextarea1"">Hakkımda</label>
                        ");
#nullable restore
#line 51 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.20_BlogProject\BlogProject_UI\Views\Writer\WriterEditProfile.cshtml"
                   Write(Html.TextAreaFor(x => x.WriterAbout, 6, 10, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    </div>\r\n                    <button type=\"submit\" class=\"btn btn-gradient-primary mr-2\">Güncelle</button>\r\n                    <button class=\"btn btn-light\">İptal Et</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 60 "C:\Users\emree\Desktop\BlogProject ASP.NET CORE\2022.01.20_BlogProject\BlogProject_UI\Views\Writer\WriterEditProfile.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogProject_EntityLayer.Concrete.Writer> Html { get; private set; }
    }
}
#pragma warning restore 1591
