#pragma checksum "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23d085ec6630e9bed11e57e38fdeb8ae13889f4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Update), @"mvc.1.0.view", @"/Views/Home/Update.cshtml")]
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
#line 1 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\_ViewImports.cshtml"
using Task_Web_Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\_ViewImports.cshtml"
using Task_Web_Product.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23d085ec6630e9bed11e57e38fdeb8ae13889f4d", @"/Views/Home/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"286fb3deb620531a59a3c8375094491d6c3d03c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\Update.cshtml"
  
    ViewData["Title"]="Pick up your favorite goods";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n");
#nullable restore
#line 6 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\Update.cshtml"
      
        var get = ViewBag.items;
        foreach (var item in get)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"text-left\">\r\n                <img");
            BeginWriteAttribute("src", " src=", 239, "", 255, 1);
#nullable restore
#line 11 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\Update.cshtml"
WriteAttributeValue("", 244, item.image, 244, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"500px\"> </div>\r\n                <div class=\"text-right\">\r\n                <h6>");
#nullable restore
#line 13 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\Update.cshtml"
               Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <h6>Price : Rp.");
#nullable restore
#line 14 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\Update.cshtml"
                          Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <h7>Total : ");
#nullable restore
#line 15 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\Update.cshtml"
                       Write(item.total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h7>\r\n                <br>\r\n                <input");
            BeginWriteAttribute("value", " value=\"", 498, "\"", 506, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""cart"" placeholder=""  Add to chart"">
                <button onclick=""myFunction()"" name=""input"" type=""post"">Update</button>
                <button onclick=""myFunction()"" type=""post"">Remove</button>
                <br>
                <br>
                <br>
            </div>
");
#nullable restore
#line 24 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\Update.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
