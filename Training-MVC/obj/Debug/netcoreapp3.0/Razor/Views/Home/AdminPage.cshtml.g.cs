#pragma checksum "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\AdminPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44abcf922f8eb40708259c3c910d3a791c05e6a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AdminPage), @"mvc.1.0.view", @"/Views/Home/AdminPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44abcf922f8eb40708259c3c910d3a791c05e6a2", @"/Views/Home/AdminPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"286fb3deb620531a59a3c8375094491d6c3d03c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AdminPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Privacy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\AdminPage.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44abcf922f8eb40708259c3c910d3a791c05e6a24442", async() => {
                WriteLiteral(@"
  <meta charset=""utf-8"">
  <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
  <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
  <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
  <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
  <style>
    /* Remove the navbar's default rounded borders and increase the bottom margin */ 
    .navbar {
      margin-bottom: 50px;
      border-radius: 0;
      background-color: #191716;
    }
    
    /* Remove the jumbotron's default bottom margin */ 
     .jumbotron {
      margin-bottom: 0;
    }

    .margin{
      margin-top: 75px;
      margin-bottom: 75px;
      margin-right: 75px;
      margin-left: 75px;
    }
   
    /* Add a gray background color and some padding to the footer */
    footer {
      background-color: #f2f2f2;
      padding: 25px;
    }
  </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44abcf922f8eb40708259c3c910d3a791c05e6a26428", async() => {
                WriteLiteral(@"

<nav class=""navbar navbar-inverse"">
  <div class=""container-fluid"">
    <div class=""navbar-header"">
      <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target=""#myNavbar"">
        <span class=""icon-bar""></span>
        <span class=""icon-bar""></span>
        <span class=""icon-bar""></span>                        
      </button>
      <a class=""navbar-brand"" href=""#"">Admin</a>
    </div>
    <div class=""collapse navbar-collapse"" id=""myNavbar"">
      <ul class=""nav navbar-nav"">
        <li><a href=""/Home/Admin/"">Manage Product</a></li>
        <li><a href=""/Home/TransactionList/"">Transaction</a></li>
      </ul>
        <ul class=""nav navbar-nav navbar-right"">
         <li><a href=""/Admin/Logout/""><span class=""glyphicon glyphicon-log-out""></span> Logout</a></li>
      </ul>
    </div>
  </div>
</nav>

<h2 class=""text-center"">Product List</h2>

<div class=""margin"">
<table class=""table"">
  <thead class=""thead-dark"">
    <tr>
      <th scope=""col"">No</th>
 ");
                WriteLiteral("     <th scope=\"col\">Nama</th>\r\n      <th scope=\"col\">Image</th>\r\n      <th scope=\"col\">Description</th>\r\n      <th scope=\"col\">Price</th>\r\n      <th scope=\"col\">Action</th>\r\n    </tr>\r\n  </thead>\r\n  <tbody>\r\n");
#nullable restore
#line 80 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\AdminPage.cshtml"
          var count = 0; 
          var items = ViewBag.items;
          foreach(var product in items) {
            count++;

#line default
#line hidden
#nullable disable
                WriteLiteral("    <tr>\r\n      <th>");
#nullable restore
#line 85 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\AdminPage.cshtml"
     Write(count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n      <td>");
#nullable restore
#line 86 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\AdminPage.cshtml"
     Write(product.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n      <td><img style=\"width:70px\"");
                BeginWriteAttribute("src", " src=", 2552, "", 2571, 1);
#nullable restore
#line 87 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\AdminPage.cshtml"
WriteAttributeValue("", 2557, product.image, 2557, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></td>\r\n      <td>");
#nullable restore
#line 88 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\AdminPage.cshtml"
     Write(product.desc);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 89 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\AdminPage.cshtml"
     Write(product.price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n      <td><button");
                BeginWriteAttribute("id", " id=\"", 2657, "\"", 2677, 2);
                WriteAttributeValue("", 2662, "upd-", 2662, 4, true);
#nullable restore
#line 90 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\AdminPage.cshtml"
WriteAttributeValue("", 2666, product.id, 2666, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"button\" class=\"btn btn-success\" value=\"update\" onclick=\"javascript:submitUpdate(this)\"><span class=\"glyphicon glyphicon-edit\"></span></button></td>\r\n      <td><button");
                BeginWriteAttribute("id", " id=\"", 2851, "\"", 2871, 2);
                WriteAttributeValue("", 2856, "rem-", 2856, 4, true);
#nullable restore
#line 91 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\AdminPage.cshtml"
WriteAttributeValue("", 2860, product.id, 2860, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"button\" class=\"btn btn-danger\" value=\"remove\" onclick=\"javascript:remove(this)\"><span class=\"glyphicon glyphicon-trash\"></span></button></td>\r\n    </tr> ");
#nullable restore
#line 92 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\AdminPage.cshtml"
          }
      

#line default
#line hidden
#nullable disable
                WriteLiteral("</table> </div> \r\n         <footer class=\"border-top footer text-muted\">\r\n        <div class=\"container\">\r\n            &copy; 2020 - Bellroy - ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44abcf922f8eb40708259c3c910d3a791c05e6a211262", async() => {
                    WriteLiteral("Privacy");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    </footer>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </html>");
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