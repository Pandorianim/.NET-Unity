#pragma checksum "C:\Users\jansk\source\repos\l9z2\l9z1\Views\Article\AnotherIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13cce6cdc46510192e5e6869d39bae449869d221"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Article_AnotherIndex), @"mvc.1.0.view", @"/Views/Article/AnotherIndex.cshtml")]
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
#line 1 "C:\Users\jansk\source\repos\l9z2\l9z1\Views\_ViewImports.cshtml"
using l9z1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jansk\source\repos\l9z2\l9z1\Views\_ViewImports.cshtml"
using l9z1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13cce6cdc46510192e5e6869d39bae449869d221", @"/Views/Article/AnotherIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f37baad023223b9a7def9c2c64fc239d7d687b37", @"/Views/_ViewImports.cshtml")]
    public class Views_Article_AnotherIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<l9z1.ViewModels.Article>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\jansk\source\repos\l9z2\l9z1\Views\Article\AnotherIndex.cshtml"
  
    ViewBag.Title = "Another Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 6 "C:\Users\jansk\source\repos\l9z2\l9z1\Views\Article\AnotherIndex.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<table>\r\n");
#nullable restore
#line 8 "C:\Users\jansk\source\repos\l9z2\l9z1\Views\Article\AnotherIndex.cshtml"
     foreach (var item in Model)
    {
        //Html.RenderPartial("_Student", item);
        await Html.RenderPartialAsync("_Article", item);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<l9z1.ViewModels.Article>> Html { get; private set; }
    }
}
#pragma warning restore 1591
