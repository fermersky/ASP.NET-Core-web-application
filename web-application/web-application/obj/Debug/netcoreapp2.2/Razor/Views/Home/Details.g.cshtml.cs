#pragma checksum "C:\Users\Данил\Desktop\asp.net-core\web-application\web-application\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ab88004544387f5a6a9b102f7eb4c8dde4c0233"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
#line 1 "C:\Users\Данил\Desktop\asp.net-core\web-application\web-application\Views\_ViewImports.cshtml"
using web_application.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\Данил\Desktop\asp.net-core\web-application\web-application\Views\_ViewImports.cshtml"
using web_application.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ab88004544387f5a6a9b102f7eb4c8dde4c0233", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"633a951eed8fa58d70a39fe32a75d4815c9f50c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Данил\Desktop\asp.net-core\web-application\web-application\Views\Home\Details.cshtml"
  
  var emp = @Model.Employee;
  ViewBag.PageTitle = "Details";

#line default
#line hidden
            BeginContext(103, 20, true);
            WriteLiteral("\r\n<div>\r\n  <p>Name: ");
            EndContext();
            BeginContext(124, 8, false);
#line 9 "C:\Users\Данил\Desktop\asp.net-core\web-application\web-application\Views\Home\Details.cshtml"
      Write(emp.Name);

#line default
#line hidden
            EndContext();
            BeginContext(132, 18, true);
            WriteLiteral("</p>\r\n  <p>Email: ");
            EndContext();
            BeginContext(151, 9, false);
#line 10 "C:\Users\Данил\Desktop\asp.net-core\web-application\web-application\Views\Home\Details.cshtml"
       Write(emp.Email);

#line default
#line hidden
            EndContext();
            BeginContext(160, 23, true);
            WriteLiteral("</p>\r\n  <p>Department: ");
            EndContext();
            BeginContext(184, 14, false);
#line 11 "C:\Users\Данил\Desktop\asp.net-core\web-application\web-application\Views\Home\Details.cshtml"
            Write(emp.Department);

#line default
#line hidden
            EndContext();
            BeginContext(198, 16, true);
            WriteLiteral("</p>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
