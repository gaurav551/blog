#pragma checksum "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4534598dd0a2cdddd3ef97f103847301250bb7ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Search), @"mvc.1.0.view", @"/Views/Post/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/Search.cshtml", typeof(AspNetCore.Views_Post_Search))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4534598dd0a2cdddd3ef97f103847301250bb7ff", @"/Views/Post/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07b827f7061c08fb2045185d938215d665304388", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Post>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AuthorProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:Red;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:blue;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SeeMore1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("stretched-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 31, true);
            WriteLiteral("\r\n <!-- <div class=\"row\">    \r\n");
            EndContext();
#line 4 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\Search.cshtml"
   foreach (var x in Model)  
  {
   
     

#line default
#line hidden
            BeginContext(98, 92, true);
            WriteLiteral("   <div class=\"col-sm-4\">\r\n     <br>\r\n<div class=\"card\">\r\n  <div class=\"card-header\">\r\n     ");
            EndContext();
            BeginContext(190, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4534598dd0a2cdddd3ef97f103847301250bb7ff6256", async() => {
                BeginContext(270, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(272, 10, false);
#line 12 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\Search.cshtml"
                                                                                 Write(x.Category);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-category", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 12 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\Search.cshtml"
                                                            WriteLiteral(x.Category);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-category", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(286, 66, true);
            WriteLiteral("\r\n  </div>\r\n  <div class=\"card-body\">\r\n    <h5 class=\"card-title\">");
            EndContext();
            BeginContext(353, 88, false);
#line 15 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\Search.cshtml"
                      Write(Html.Raw(x.Description.Length>200? x.Description.Substring(0,199)+"..." : x.Description));

#line default
#line hidden
            EndContext();
            BeginContext(441, 17, true);
            WriteLiteral("</h5>\r\n    \r\n<p> ");
            EndContext();
            BeginContext(458, 122, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4534598dd0a2cdddd3ef97f103847301250bb7ff9616", async() => {
                BeginContext(546, 4, true);
                WriteLiteral(" By ");
                EndContext();
                BeginContext(551, 24, false);
#line 17 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\Search.cshtml"
                                                                                           Write(x.UserName.Split('@')[0]);

#line default
#line hidden
                EndContext();
                BeginContext(575, 1, true);
                WriteLiteral(" ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-username", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 17 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\Search.cshtml"
                                                                   WriteLiteral(x.UserName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-username", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(580, 19, true);
            WriteLiteral(" <small></small>   ");
            EndContext();
            BeginContext(600, 26, false);
#line 17 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\Search.cshtml"
                                                                                                                                            Write(x.Date.ToString("MMMM dd"));

#line default
#line hidden
            EndContext();
            BeginContext(626, 44, true);
            WriteLiteral(" </p>\r\n\r\n  \r\n    <a  class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 670, "\"", 696, 2);
            WriteAttributeValue("", 677, "/Post/SeeMore/", 677, 14, true);
#line 20 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\Search.cshtml"
WriteAttributeValue("", 691, x.Id, 691, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(697, 52, true);
            WriteLiteral("> SeeMore</a>\r\n    \r\n\r\n  </div>\r\n</div>\r\n   </div>\r\n");
            EndContext();
#line 26 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\Search.cshtml"
     


  }

#line default
#line hidden
            BeginContext(765, 37, true);
            WriteLiteral("  </div>   -->\r\n  <div class=\"row\">\r\n");
            EndContext();
#line 32 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\Search.cshtml"
   foreach (var x in Model)  
  {
   
    

#line default
#line hidden
            BeginContext(849, 292, true);
            WriteLiteral(@"      <div class=""col-md-6"">
      <div class=""row no-gutters border rounded overflow-hidden flex-md-row mb-4 shadow-sm h-md-250 position-relative"">
        <div class=""col p-4 d-flex flex-column position-static"">
          <strong class=""d-inline-block mb-2 text-danger""  >
           
");
            EndContext();
#line 41 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\Search.cshtml"
            if(x.Id%2 == 0)
{


#line default
#line hidden
            BeginContext(1175, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1199, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4534598dd0a2cdddd3ef97f103847301250bb7ff14779", async() => {
                BeginContext(1299, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1301, 10, false);
#line 44 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\Search.cshtml"
                                                                                                                        Write(x.Category);

#line default
#line hidden
                EndContext();
                BeginContext(1311, 1, true);
                WriteLiteral(" ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-category", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\Search.cshtml"
                                                                               WriteLiteral(x.Category);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-category", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1316, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 45 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\Search.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1330, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1354, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4534598dd0a2cdddd3ef97f103847301250bb7ff18151", async() => {
                BeginContext(1455, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1457, 10, false);
#line 48 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\Search.cshtml"
                                                                                                                         Write(x.Category);

#line default
#line hidden
                EndContext();
                BeginContext(1467, 1, true);
                WriteLiteral(" ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-category", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\Search.cshtml"
                                                                               WriteLiteral(x.Category);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-category", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1472, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 49 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\Search.cshtml"
  
}

#line default
#line hidden
            BeginContext(1481, 51, true);
            WriteLiteral("            </strong>\r\n          <h3 class=\"mb-0\"> ");
            EndContext();
            BeginContext(1533, 9, false);
#line 52 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\Search.cshtml"
                       Write(x.Heading);

#line default
#line hidden
            EndContext();
            BeginContext(1542, 47, true);
            WriteLiteral(" </h3>\r\n          <div class=\"mb-1 text-muted\">");
            EndContext();
            BeginContext(1590, 26, false);
#line 53 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\Search.cshtml"
                                  Write(x.Date.ToString("MMMM dd"));

#line default
#line hidden
            EndContext();
            BeginContext(1616, 4, true);
            WriteLiteral(" at ");
            EndContext();
            BeginContext(1621, 28, false);
#line 53 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\Search.cshtml"
                                                                 Write(x.Date.ToString("hhhh : mm"));

#line default
#line hidden
            EndContext();
            BeginContext(1649, 17, true);
            WriteLiteral(" by\r\n            ");
            EndContext();
            BeginContext(1666, 122, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4534598dd0a2cdddd3ef97f103847301250bb7ff22698", async() => {
                BeginContext(1754, 4, true);
                WriteLiteral(" By ");
                EndContext();
                BeginContext(1759, 24, false);
#line 54 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\Search.cshtml"
                                                                                                   Write(x.UserName.Split('@')[0]);

#line default
#line hidden
                EndContext();
                BeginContext(1783, 1, true);
                WriteLiteral(" ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-username", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\Search.cshtml"
                                                                           WriteLiteral(x.UserName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-username", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1788, 76, true);
            WriteLiteral("\r\n             </div>\r\n          \r\n          <p class=\"card-text mb-auto\">  ");
            EndContext();
            BeginContext(1865, 88, false);
#line 57 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\Search.cshtml"
                                    Write(Html.Raw(x.Description.Length>200? x.Description.Substring(0,199)+"..." : x.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1953, 20, true);
            WriteLiteral("     </p>\r\n         ");
            EndContext();
            BeginContext(1973, 139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4534598dd0a2cdddd3ef97f103847301250bb7ff26251", async() => {
                BeginContext(2092, 16, true);
                WriteLiteral("Continue reading");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\Search.cshtml"
                                                          WriteLiteral(x.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 58 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\Search.cshtml"
                                                                                WriteLiteral(x.Category);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cat"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-cat", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cat"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2112, 94, true);
            WriteLiteral("\r\n          \r\n        </div>\r\n        <div class=\"col-auto d-none d-lg-block\">\r\n          <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2206, "\"", 2231, 2);
            WriteAttributeValue("", 2212, "images/", 2212, 7, true);
#line 62 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\Search.cshtml"
WriteAttributeValue("", 2219, x.PhotoName, 2219, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2232, 106, true);
            WriteLiteral(" class=\"bd-placeholder-img\" width=\"200\" height=\"250\"></img> \r\n        </div>\r\n      </div>\r\n      </div>\r\n");
            EndContext();
#line 66 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\Search.cshtml"
    
    
  

  }

#line default
#line hidden
            BeginContext(2361, 8, true);
            WriteLiteral("  </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
