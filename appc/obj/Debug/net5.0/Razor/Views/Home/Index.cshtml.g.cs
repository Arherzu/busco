#pragma checksum "C:\Users\AYRTON\Desktop\PROYECTOS\PC03\busco\appc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7aa47e718f2c3fc3ac07127a0f2ea7a06bde67f"
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
#line 1 "C:\Users\AYRTON\Desktop\PROYECTOS\PC03\busco\appc\Views\_ViewImports.cshtml"
using appc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AYRTON\Desktop\PROYECTOS\PC03\busco\appc\Views\_ViewImports.cshtml"
using appc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7aa47e718f2c3fc3ac07127a0f2ea7a06bde67f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4aac02ab290ff5a873ab4a1fc0c4cfa2a16163bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RegistrarProducto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\AYRTON\Desktop\PROYECTOS\PC03\busco\appc\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Lista de productos</h1>\r\n    \r\n\r\n");
#nullable restore
#line 10 "C:\Users\AYRTON\Desktop\PROYECTOS\PC03\busco\appc\Views\Home\Index.cshtml"
     if (Model.Count == 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>No hay productos aún.</p>\r\n");
#nullable restore
#line 12 "C:\Users\AYRTON\Desktop\PROYECTOS\PC03\busco\appc\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n    \r\n");
#nullable restore
#line 15 "C:\Users\AYRTON\Desktop\PROYECTOS\PC03\busco\appc\Views\Home\Index.cshtml"
     foreach (var solicitud in Model) {
        if (solicitud.Usuario == null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Productos disponibles: ");
#nullable restore
#line 17 "C:\Users\AYRTON\Desktop\PROYECTOS\PC03\busco\appc\Views\Home\Index.cshtml"
                                 Write(solicitud.Nomprod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 18 "C:\Users\AYRTON\Desktop\PROYECTOS\PC03\busco\appc\Views\Home\Index.cshtml"
        } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>");
#nullable restore
#line 19 "C:\Users\AYRTON\Desktop\PROYECTOS\PC03\busco\appc\Views\Home\Index.cshtml"
          Write(solicitud.Nomprod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 20 "C:\Users\AYRTON\Desktop\PROYECTOS\PC03\busco\appc\Views\Home\Index.cshtml"
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RegistrarProducto>> Html { get; private set; }
    }
}
#pragma warning restore 1591