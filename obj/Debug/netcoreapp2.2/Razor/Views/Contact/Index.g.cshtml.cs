#pragma checksum "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cd4d1d2cd0e2c88281b570e5077650c0d492f7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contact/Index.cshtml", typeof(AspNetCore.Views_Contact_Index))]
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
#line 1 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\_ViewImports.cshtml"
using blog;

#line default
#line hidden
#line 2 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\_ViewImports.cshtml"
using blog.Models;

#line default
#line hidden
#line 3 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\_ViewImports.cshtml"
using blog.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cd4d1d2cd0e2c88281b570e5077650c0d492f7b", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07b827f7061c08fb2045185d938215d665304388", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Contact>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 6, true);
            WriteLiteral("    \r\n");
            EndContext();
#line 3 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Contact\Index.cshtml"
    if (Model.Count<=0)
   {

#line default
#line hidden
            BeginContext(59, 25, true);
            WriteLiteral("       <p> No Data </p>\r\n");
            EndContext();
#line 6 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Contact\Index.cshtml"
   }

#line default
#line hidden
            BeginContext(90, 463, true);
            WriteLiteral(@"    <table class=""table table-hover"">
          
          <thead style="" background-color:green"">
              <tr>
               <th>
                   Name
               </th>
               <th>
                   Email
                   
               </th>
               <th>
                   Subject
               </th>
               <th>
                   Message
               </th>
           </tr>
           </thead>

");
            EndContext();
#line 27 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Contact\Index.cshtml"
     foreach (var item in Model)
    {
       

#line default
#line hidden
            BeginContext(603, 64, true);
            WriteLiteral("           <tbody>\r\n               <tr>\r\n                   <td>");
            EndContext();
            BeginContext(668, 9, false);
#line 32 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Contact\Index.cshtml"
                  Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(677, 30, true);
            WriteLiteral("</td>\r\n                   <td>");
            EndContext();
            BeginContext(708, 10, false);
#line 33 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Contact\Index.cshtml"
                  Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(718, 30, true);
            WriteLiteral("</td>\r\n                   <td>");
            EndContext();
            BeginContext(749, 12, false);
#line 34 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Contact\Index.cshtml"
                  Write(item.Subject);

#line default
#line hidden
            EndContext();
            BeginContext(761, 30, true);
            WriteLiteral("</td>\r\n                   <td>");
            EndContext();
            BeginContext(792, 12, false);
#line 35 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Contact\Index.cshtml"
                  Write(item.Message);

#line default
#line hidden
            EndContext();
            BeginContext(804, 50, true);
            WriteLiteral("</td>\r\n               </tr>\r\n           </tbody>\r\n");
            EndContext();
#line 38 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Contact\Index.cshtml"
      
       
       
       
    }

#line default
#line hidden
            BeginContext(896, 3, true);
            WriteLiteral("   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591
