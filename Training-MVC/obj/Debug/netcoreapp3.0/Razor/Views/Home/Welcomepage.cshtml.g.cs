#pragma checksum "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\Welcomepage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe7d87e6897dfe0cfba715ee70c50ce7c1c0f28a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Welcomepage), @"mvc.1.0.view", @"/Views/Home/Welcomepage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe7d87e6897dfe0cfba715ee70c50ce7c1c0f28a", @"/Views/Home/Welcomepage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"286fb3deb620531a59a3c8375094491d6c3d03c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Welcomepage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\Welcomepage.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe7d87e6897dfe0cfba715ee70c50ce7c1c0f28a4450", async() => {
                WriteLiteral(@"
  <title>Welcome to Bellroy</title>
  <meta charset=""utf-8"">
  <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
  <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
  <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
  <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
  <style>
    /* Remove the navbar's default margin-bottom and rounded borders */ 
    .navbar {
      margin-bottom: 0;
      border-radius: 0;
    }
    
    /* Add a gray background color and some padding to the footer */
    footer {
      background-color: #f2f2f2;
      padding: 25px;
    }
    
  .carousel-inner img {
      width: 100%; /* Set width to 100% */
      margin: auto;
      min-height:200px;
  }

  /* Hide the carousel text when the screen is less than 600 pixels wide */
 (max-width: 600px) {
    .carousel-caption {
      display: none; 
    }
  }");
                WriteLiteral("\r\n  </style>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe7d87e6897dfe0cfba715ee70c50ce7c1c0f28a6504", async() => {
                WriteLiteral(@"

<nav class=""navbar navbar-inverse"">
  <div class=""container-fluid"">
    <div class=""navbar-header"">
      <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target=""#myNavbar"">
        <span class=""icon-bar""></span>
        <span class=""icon-bar""></span>
        <span class=""icon-bar""></span>                        
      </button>
      <a class=""navbar-brand"" href=""#"">Bellroy</a>
    </div>
    <div class=""collapse navbar-collapse"" id=""myNavbar"">
      <ul class=""nav navbar-nav"">
        <li class=""active""><a href=""/Home/Welcomepage/"">Home</a></li>
        <li><a href=""/Home/Product/"">Products</a></li>
        <li><a href=""/Home/Cart/"">Cart</a></li>
        <li><a href=""/Home/Privacy"">Privacy</a></li>
      </ul>
      <ul class=""nav navbar-nav navbar-right"">
         <li><a href=""/Admin/Logout/""><span class=""glyphicon glyphicon-log-out""></span> Logout</a></li>
      </ul>
    </div>
  </div>
</nav>

<div id=""myCarousel"" class=""carousel slide"" data-ride=""caro");
                WriteLiteral(@"usel"">
    <!-- Indicators -->
    <ol class=""carousel-indicators"">
      <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
      <li data-target=""#myCarousel"" data-slide-to=""1""></li>
      <li data-target=""#myCarousel"" data-slide-to=""2""></li>
    </ol>

    <!-- Wrapper for slides -->
    <div class=""carousel-inner"" role=""listbox"">

        
      <div class=""item active"">
        <img src=""https://rushfaster.com.au/blog/wp-content/uploads/2017/09/bellroy-bdwa-lifestyle-web-02.jpg"" alt=""Image"">
        <div class=""carousel-caption"">
           <h3>Carrying it forward,</h3>
          <p>Since 2010</p>
        </div>      
      </div>

      <div class=""item"">
        <img src=""https://heygents.com.au/wp-content/uploads/2019/08/bellroy-bslb-lifestyle-web-10.jpg"" style=""width:70% alt=""Image"">
        <div class=""carousel-caption"">
           <h3>Carrying it forward,</h3>
          <p>Since 2010</p>
        </div>      
      </div>

      <div class=""item"">
     ");
                WriteLiteral(@"   <img src=""https://www.thecoolector.com/wp-content/uploads/2019/05/bellroy-wallet-1050x700.jpg""  alt=""Image"">
        <div class=""carousel-caption"">
          <h3>Carrying it forward,</h3>
          <p>Since 2010</p>
        </div>      
      </div>

    </div>

    <!-- Left and right controls -->
    <a class=""left carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
      <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
      <span class=""sr-only"">Previous</span>
    </a>
    <a class=""right carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""next"">
      <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
      <span class=""sr-only"">Next</span>
    </a>
</div>
  
<div class=""container text-center"">  
    <br><br>  
  <h3>Bring your goods in simply way</h3><br><br><br>
  <div class=""row"">

");
#nullable restore
#line 120 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\Welcomepage.cshtml"
  
    var items = ViewBag.items;
    foreach(var item in items) {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div class=\"col-sm-4\">\r\n      <img");
                BeginWriteAttribute("src", " src=", 4185, "", 4201, 1);
#nullable restore
#line 124 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\Welcomepage.cshtml"
WriteAttributeValue("", 4190, item.image, 4190, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-responsive\" style=\"width:100%\" alt=\"Image\">\r\n      <a style=\"color:#111010\"");
                BeginWriteAttribute("href", " href=\"", 4288, "\"", 4316, 2);
                WriteAttributeValue("", 4295, "/Home/Detail/", 4295, 13, true);
#nullable restore
#line 125 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\Welcomepage.cshtml"
WriteAttributeValue("", 4308, item.id, 4308, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 125 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\Welcomepage.cshtml"
                                                       Write(item.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a><br><br><br>\r\n    </div> ");
#nullable restore
#line 126 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\Welcomepage.cshtml"
           }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n  </div>\r\n</div><br>\r\n\r\n <footer class=\"border-top footer text-muted\">\r\n        <div class=\"container\">\r\n            &copy; 2020 - Bellroy - ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe7d87e6897dfe0cfba715ee70c50ce7c1c0f28a11767", async() => {
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
                WriteLiteral("\r\n        </div>\r\n    </footer>\r\n\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
