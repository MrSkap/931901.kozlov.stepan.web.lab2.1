#pragma checksum "C:\Users\User\Documents\GitHub\931901.kozlov.stepan.web.lab2.1\WebApp1\WebApp1\Views\CalcService\AccessServiceDirectly.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e83d52da6dcc4b40f5d4e5bd2aad8765a040af98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CalcService_AccessServiceDirectly), @"mvc.1.0.view", @"/Views/CalcService/AccessServiceDirectly.cshtml")]
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
#line 1 "C:\Users\User\Documents\GitHub\931901.kozlov.stepan.web.lab2.1\WebApp1\WebApp1\Views\_ViewImports.cshtml"
using WebApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\GitHub\931901.kozlov.stepan.web.lab2.1\WebApp1\WebApp1\Views\_ViewImports.cshtml"
using WebApp1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\User\Documents\GitHub\931901.kozlov.stepan.web.lab2.1\WebApp1\WebApp1\Views\CalcService\AccessServiceDirectly.cshtml"
using WebApp1.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e83d52da6dcc4b40f5d4e5bd2aad8765a040af98", @"/Views/CalcService/AccessServiceDirectly.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf4ee4a035400545fcc1cb7a64e77d8344989791", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_CalcService_AccessServiceDirectly : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\Documents\GitHub\931901.kozlov.stepan.web.lab2.1\WebApp1\WebApp1\Views\CalcService\AccessServiceDirectly.cshtml"
  
    ViewBag.Title = "AccessServiceDirectly - Backend1";
    var model = Service.GetCalcModel();

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>AccessServiceDirectly</h1>\n\n<b>Rand value first:</b> ");
#nullable restore
#line 9 "C:\Users\User\Documents\GitHub\931901.kozlov.stepan.web.lab2.1\WebApp1\WebApp1\Views\CalcService\AccessServiceDirectly.cshtml"
                     Write(model.X);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br />\n<b>Rand value second:</b> ");
#nullable restore
#line 11 "C:\Users\User\Documents\GitHub\931901.kozlov.stepan.web.lab2.1\WebApp1\WebApp1\Views\CalcService\AccessServiceDirectly.cshtml"
                      Write(model.Y);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br />\n\n<b>Add:</b>\n<br />\n");
#nullable restore
#line 16 "C:\Users\User\Documents\GitHub\931901.kozlov.stepan.web.lab2.1\WebApp1\WebApp1\Views\CalcService\AccessServiceDirectly.cshtml"
Write(model.Add);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br />\n\n<b>Dif:</b>\n<br />\n");
#nullable restore
#line 21 "C:\Users\User\Documents\GitHub\931901.kozlov.stepan.web.lab2.1\WebApp1\WebApp1\Views\CalcService\AccessServiceDirectly.cshtml"
Write(model.Sub);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br />\n\n<b>Mult:</b>\n<br />\n");
#nullable restore
#line 26 "C:\Users\User\Documents\GitHub\931901.kozlov.stepan.web.lab2.1\WebApp1\WebApp1\Views\CalcService\AccessServiceDirectly.cshtml"
Write(model.Mult);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br />\n\n<b>Div:</b>\n<br />\n");
#nullable restore
#line 31 "C:\Users\User\Documents\GitHub\931901.kozlov.stepan.web.lab2.1\WebApp1\WebApp1\Views\CalcService\AccessServiceDirectly.cshtml"
Write(model.Div);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br />");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public CalcService Service { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
