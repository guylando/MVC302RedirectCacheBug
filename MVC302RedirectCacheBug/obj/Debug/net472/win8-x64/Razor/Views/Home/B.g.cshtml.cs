#pragma checksum "C:\Users\stocker\Desktop\test\MVC302RedirectCacheBug\MVC302RedirectCacheBug\MVC302RedirectCacheBug\Views\Home\B.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46a46f3bdd678b8aae13f9c05e3ec719f33e7db3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_B), @"mvc.1.0.view", @"/Views/Home/B.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/B.cshtml", typeof(AspNetCore.Views_Home_B))]
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
#line 1 "C:\Users\stocker\Desktop\test\MVC302RedirectCacheBug\MVC302RedirectCacheBug\MVC302RedirectCacheBug\Views\_ViewImports.cshtml"
using MVC302RedirectCacheBug;

#line default
#line hidden
#line 2 "C:\Users\stocker\Desktop\test\MVC302RedirectCacheBug\MVC302RedirectCacheBug\MVC302RedirectCacheBug\Views\_ViewImports.cshtml"
using MVC302RedirectCacheBug.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46a46f3bdd678b8aae13f9c05e3ec719f33e7db3", @"/Views/Home/B.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb311149fe44bd636c82deff141a73866c940976", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_B : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1262, true);
            WriteLiteral(@"<h2>B</h2>
<p>Click the button</p>
<button id=""a"">Click here</button>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
<script>
    /**
     * https://stackoverflow.com/questions/14573223/set-cookie-and-get-cookie-with-javascript/24103596#24103596
     */
    function setCookie(name, value, days) {
        var expires = """";
        if (days) {
            var date = new Date();
            date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
            expires = ""; expires="" + date.toUTCString();
        }
        document.cookie = name + ""="" + (value || """") + expires + ""; path=/"";
    }
    function getCookie(name) {
        var nameEQ = name + ""="";
        var ca = document.cookie.split(';');
        for (var i = 0; i < ca.length; i++) {
            var c = ca[i];
            while (c.charAt(0) == ' ') c = c.substring(1, c.length);
            if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length, c.length);
        }
        r");
            WriteLiteral("eturn null;\r\n    }\r\n    function eraseCookie(name) {\r\n        document.cookie = name + \'=; Max-Age=-99999999;\';\r\n    }\r\n    $(\"#a\").on(\"click\", function () {\r\n        eraseCookie(\"ccc\");\r\n        window.location = \"/\";\r\n    });\r\n</script>");
            EndContext();
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
