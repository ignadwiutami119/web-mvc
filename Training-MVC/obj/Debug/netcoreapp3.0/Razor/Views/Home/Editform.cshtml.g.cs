#pragma checksum "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\Editform.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f51343be6e0b7ad628877c26909926e78a123eb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Editform), @"mvc.1.0.view", @"/Views/Home/Editform.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f51343be6e0b7ad628877c26909926e78a123eb8", @"/Views/Home/Editform.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"286fb3deb620531a59a3c8375094491d6c3d03c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Editform : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\Editform.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\Editform.cshtml"
     
        var get = ViewBag.items;
        foreach (var item in get)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f51343be6e0b7ad628877c26909926e78a123eb84249", async() => {
                WriteLiteral("\r\n                <p4>ID Product :</p4>\r\n                <p4 id=\"id_product\">");
#nullable restore
#line 10 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\Editform.cshtml"
                               Write(item.id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p4>\r\n                <input  id=\"title\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 298, "\"", 306, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"title\" placeholder=\"  Title\">\r\n                <input  id=\"image\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 391, "\"", 399, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"cart\"  placeholder=\"  Image (url)\">\r\n                <input  id=\"desc\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 489, "\"", 497, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"cart\"  placeholder=\"  description\">\r\n                <input  id=\"price\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 588, "\"", 596, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"cart\"  placeholder=\"  Price\">\r\n                <input  id=\"rate\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 680, "\"", 688, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"cart\"  placeholder=\"  Rate\">\r\n                <button id=\"button\" type=\"button\" class=\"btn btn-primary\" value=\"update\" onclick=\"javascript:AddProduct(this)\">Add Product</button><br><br>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <br>\r\n            <br>\r\n            <br>\r\n            <button id=\"button_go\" type=\"button\" class=\"btn btn-primary\" value=\"update\" onclick=\"location.href=\'/Home/Index\'\">Back To Home</button><br><br>\r\n");
#nullable restore
#line 22 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\Editform.cshtml"
    }
   

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script type=""text/javascript"">
function AddProduct(buttonSubmit)
{
    var id = document.getElementById(""id_product"").innerHTML;
    var title = document.getElementById(""title"").value;
    var image = document.getElementById(""image"").value;
    var desc = document.getElementById(""desc"").value;
    var price = document.getElementById(""price"").value;
    var rate = document.getElementById(""rate"").value;
    location.href='/Home/EditProduct?id='+id'&title='+title+'&image='+image+'&desc='+desc+'&price='+price+'&rate='+rate;
}
</script>");
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
