#pragma checksum "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\CustomerChat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "202b621d31f7264870902af22e487582ec81bb77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CustomerChat), @"mvc.1.0.view", @"/Views/Home/CustomerChat.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"202b621d31f7264870902af22e487582ec81bb77", @"/Views/Home/CustomerChat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"286fb3deb620531a59a3c8375094491d6c3d03c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CustomerChat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\CustomerChat.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\CustomerChat.cshtml"
        
        var get = ViewBag.username;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>Hello</h2>\r\n        <h2 id=\"username\">");
#nullable restore
#line 7 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\CustomerChat.cshtml"
                     Write(get);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
            WriteLiteral(@"
<style>
    div.panel-body {
        overflow: scroll;
        width: 1100px;
        height: 300px;
    }
</style>
<br>
<div class=""text-center"">
<h1>Customer Services</h1>
</div>
<div class=""chat-panel panel panel-default"">
    <div class=""panel-body"" id=""chat"">
        <input type=""hidden"" id=""displayname""/>
");
#nullable restore
#line 24 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\CustomerChat.cshtml"
          
            var x = ViewBag.history;
            foreach (var i in x)
            {
                if (i.username == "admin" && i.message != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <p style=""color:red; text-align:left;"">Admin</p>
        <p style=""color:red; text-align:left;"">
        <strong><img src=""https://cdn.esquimaltmfrc.com/wp-content/uploads/2015/09/flat-faces-icons-circle-man-6.png"" title=""Admin"" style=""width:40px""></strong>");
#nullable restore
#line 32 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\CustomerChat.cshtml"
                                                                                                                                                           Write(i.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 33 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\CustomerChat.cshtml"
                }
                else if(i.username != "admin" && i.message != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <p style=""color:black; text-align:right;"">User</p>
        <p style=""color:black; text-align:right;"">
        <strong><img src=""https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTLMXEtafCkq2nYjPZIUEslsXoVXNBzURoDLeblurcyeQWK0_ly8g&s"" title=""User"" style=""width:40px""></strong>");
#nullable restore
#line 38 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\CustomerChat.cshtml"
                                                                                                                                                                            Write(i.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 39 "D:\TRAININGC#\FEBRUARI\MVC\Training-MVC\Views\Home\CustomerChat.cshtml"
                }
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <p id=""discussion""></p>
    </div>
    <div class=""text-center"">
    <div class=""panel-footer"">
        <br>
        <div class=""input-group"">
            <input id=""user"" type=""hidden"" name=""user"" class=""form-control input-sm"" placeholder=""Name"" value=""User""/>
            <input id=""message"" type=""text"" name=""message"" class=""form-control input-sm"" placeholder=""Message""/>
            <span class=""input-group-btn"">
                <input type=""button"" class=""btn btn-success btn-sm"" id=""sendmessage"" value=""Send"" style=""width: 300px; height: 28px;"">
            </span>
            </div>
        <br>
        </div>
        <br>
    </div>
</div>
<div class=""text-center"">
    <button class=""btn btn-block btn-danger"" onclick=""location.href='/Home/Clearchat'"">Problem Solved</button>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
        <script>
           $(document).ready(function () {
    
            let connection = new signalR.HubConnectionBuilder().withUrl(""/chatHub"").build();
            connection.start().then(function() {
                console.log(""Berhasil"");
                $('#sendmessage').on('click', function (event) {
                    event.preventDefault();
                    var get_username = document.getElementById(""username"").innerHTML;
                    let message = $('#message').val();
                    connection.invoke(""SendMessage"", get_username, message)
                        .then(data => {
                            console.log('Berhasil kirim data')
                        }).catch(err => {
                        return console.error(err.toString());
                    })
                });
                connection.on(""GotAMessage"", function (get_username, message) {
                   if (get_username == ""admin"") 
                    {
                    // Add ");
                WriteLiteral(@"the message to the page.
                    $('#discussion').append('<p style=""color:;text-align:left;"">'+'Admin'+'</p>' +'<p style=""color:red; text-align:left;""><strong><img = src=""https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTLMXEtafCkq2nYjPZIUEslsXoVXNBzURoDLeblurcyeQWK0_ly8g&s"" style=""width:40px"" title=""Admin"">'
                        + ' </strong> ' + message + '</p>');
                    }
                    else if (get_username != ""admin"") 
                    {
                    // Add the message to the page.
                    $('#discussion').append('<p style=""color:black;text-align:right;"">'+get_username+'</p>' +'<p style=""color:black; text-align:right;""><strong><img = src=""https://cdn.esquimaltmfrc.com/wp-content/uploads/2015/09/flat-faces-icons-circle-man-6.png"" style=""width:40px"" title=""User"">'
                        + ' </strong> ' + message + '</p>');
                    }
                });
            }).catch(function (err) {
                return console.er");
                WriteLiteral("ror(err.toString());\r\n            });\r\n                })\r\n        </script>\r\n    ");
            }
            );
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
