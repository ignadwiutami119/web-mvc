#pragma checksum "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d811d99625c32ed6e9329f083986d11056e86606"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d811d99625c32ed6e9329f083986d11056e86606", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"286fb3deb620531a59a3c8375094491d6c3d03c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h2 class=""display-4""><strong>Welcome To Bellroy</strong></h2>
    <p><i>Carry your goods in simply way</i></p>
    <br>
    <img src=""https://s3.amazonaws.com/cms.images.bellroy.com/cms_images/1301/bellroy.com-og-image.jpg?1525761447"" width=""1070""> 
    <ul>
");
#nullable restore
#line 11 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\Index.cshtml"
          
            var items = ViewBag.items;
            foreach(var item in items) {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""album py-5 bg-light"">
                <div class=""grid-container"">
               <div class=""grid-item"">
                <div class=""row"">
                <div class=""card mb-4 shadow-sm"">
                    <a class=""card-text""");
            BeginWriteAttribute("href", " href=\"", 700, "\"", 728, 2);
            WriteAttributeValue("", 707, "/Home/Detail/", 707, 13, true);
#nullable restore
#line 19 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 720, item.id, 720, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\Index.cshtml"
                                                                 Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=", 821, "", 837, 1);
#nullable restore
#line 21 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 826, item.image, 826, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"400px\"> <div>\r\n                    <h5>Price : Rp. ");
#nullable restore
#line 22 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\Index.cshtml"
                               Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5> </div>\r\n                <br>\r\n                <br>\r\n            </div> </div> </div> </div> </div> \r\n");
#nullable restore
#line 26 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </ul>\r\n</div>\r\n");
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
