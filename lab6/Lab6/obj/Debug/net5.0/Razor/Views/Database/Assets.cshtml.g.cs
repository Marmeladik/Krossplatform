#pragma checksum "C:\Users\Vlad I\Documents\UNIV\CrossPlatformLabs\Lab6\Lab6\Views\Database\Assets.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43b7d2f2131a42e424ca56309686f8f38fb75bd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Database_Assets), @"mvc.1.0.view", @"/Views/Database/Assets.cshtml")]
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
#line 1 "C:\Users\Vlad I\Documents\UNIV\CrossPlatformLabs\Lab6\Lab6\Views\_ViewImports.cshtml"
using Lab6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vlad I\Documents\UNIV\CrossPlatformLabs\Lab6\Lab6\Views\_ViewImports.cshtml"
using Lab6.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Vlad I\Documents\UNIV\CrossPlatformLabs\Lab6\Lab6\Views\Database\Assets.cshtml"
using Lab6.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43b7d2f2131a42e424ca56309686f8f38fb75bd9", @"/Views/Database/Assets.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7372bf70236edba20ac8048cdbb1bf29472b7ee3", @"/Views/_ViewImports.cshtml")]
    public class Views_Database_Assets : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Asset>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Vlad I\Documents\UNIV\CrossPlatformLabs\Lab6\Lab6\Views\Database\Assets.cshtml"
  
    ViewData["Title"] = "Assets";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Assets</h1>\n");
#nullable restore
#line 11 "C:\Users\Vlad I\Documents\UNIV\CrossPlatformLabs\Lab6\Lab6\Views\Database\Assets.cshtml"
     foreach (Asset asset in ViewBag.Assets)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>");
#nullable restore
#line 13 "C:\Users\Vlad I\Documents\UNIV\CrossPlatformLabs\Lab6\Lab6\Views\Database\Assets.cshtml"
        Write(asset.Asset_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\Vlad I\Documents\UNIV\CrossPlatformLabs\Lab6\Lab6\Views\Database\Assets.cshtml"
                        Write(asset.Asset_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\Vlad I\Documents\UNIV\CrossPlatformLabs\Lab6\Lab6\Views\Database\Assets.cshtml"
                                          Write(asset.Other_Details);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 14 "C:\Users\Vlad I\Documents\UNIV\CrossPlatformLabs\Lab6\Lab6\Views\Database\Assets.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Asset> Html { get; private set; }
    }
}
#pragma warning restore 1591