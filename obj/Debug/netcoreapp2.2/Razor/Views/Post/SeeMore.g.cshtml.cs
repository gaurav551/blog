#pragma checksum "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9183b61355c1bb97cf3d86399bae255103fd2861"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_SeeMore), @"mvc.1.0.view", @"/Views/Post/SeeMore.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/SeeMore.cshtml", typeof(AspNetCore.Views_Post_SeeMore))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9183b61355c1bb97cf3d86399bae255103fd2861", @"/Views/Post/SeeMore.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07b827f7061c08fb2045185d938215d665304388", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_SeeMore : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PointUp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PointDown", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReplyComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore.cshtml"
 if(Model?.Id >= 0)
{

#line default
#line hidden
            BeginContext(77, 165, true);
            WriteLiteral("<!-- heading and Description -->\r\n<div style=\"width:70%;border:1px solid gray;padding:16px;\">\r\n<h1 style=\"text-align:center;text-transform:uppercase;color:Green;\" > ");
            EndContext();
            BeginContext(243, 13, false);
#line 8 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore.cshtml"
                                                                 Write(Model.Heading);

#line default
#line hidden
            EndContext();
            BeginContext(256, 30, true);
            WriteLiteral("</h1>\r\n <p> <i><u> Created At ");
            EndContext();
            BeginContext(287, 30, false);
#line 9 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore.cshtml"
                  Write(Model.Date.ToString("MMMM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(317, 85, true);
            WriteLiteral("; </u> </i></p>\r\n<p style=\"text-indent:50px;text-align:justify;letter-spacing:3px;\"> ");
            EndContext();
            BeginContext(403, 27, false);
#line 10 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore.cshtml"
                                                               Write(Html.Raw(Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(430, 18, true);
            WriteLiteral(" </p>\r\n<p>Points: ");
            EndContext();
            BeginContext(449, 11, false);
#line 11 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore.cshtml"
      Write(Model.Point);

#line default
#line hidden
            EndContext();
            BeginContext(460, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
            BeginContext(466, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9183b61355c1bb97cf3d86399bae255103fd28618013", async() => {
                BeginContext(537, 8, true);
                WriteLiteral("Point Up");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 12 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore.cshtml"
                                                WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(549, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(551, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9183b61355c1bb97cf3d86399bae255103fd286110549", async() => {
                BeginContext(624, 10, true);
                WriteLiteral("Point Down");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 13 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore.cshtml"
                                                  WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(638, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
            BeginContext(656, 70, true);
            WriteLiteral("<!-- Add Comment (Passing commentText and postId to Controller)  -->\r\n");
            EndContext();
            BeginContext(726, 495, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9183b61355c1bb97cf3d86399bae255103fd286113275", async() => {
                BeginContext(792, 177, true);
                WriteLiteral("\r\n<div class=\"form-group\" style=\"width:70%\">\r\n    \r\n    <input  type=\"hidden\" id=\"commentCreatedAt\" name=\"commentCreatedAt\"> \r\n    <input type=\"hidden\" name=\"postId\" id=\"postId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 969, "\"", 986, 1);
#line 24 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore.cshtml"
WriteAttributeValue("", 977, Model.Id, 977, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(987, 227, true);
                WriteLiteral("/>\r\n    <br>\r\n    \r\n    <textarea id=\"commentText\" name=\"commentText\" rows=\"2\" cols=\"104\" placeholder=\"Drop Your Views..\" required></textarea>\r\n    \r\n    <input type =\"submit\" class=\"btn btn-success\" value=\"Comment\"/>\r\n</div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1221, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1227, 90, true);
            WriteLiteral("<!-- Comment View -->\r\n<div>\r\n    <h5 style=\"color:Green;\" > Recent Comments </h5>\r\n    \r\n");
            EndContext();
#line 38 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore.cshtml"
     if(@ViewBag.Comments.Count<=0){

#line default
#line hidden
            BeginContext(1355, 28, true);
            WriteLiteral("        <p>No comments</p>\r\n");
            EndContext();
#line 40 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore.cshtml"
    } else {
       
        foreach (var comment in ViewBag.Comments)
        {
            
              


#line default
#line hidden
            BeginContext(1500, 15, true);
            WriteLiteral("           <h4>");
            EndContext();
            BeginContext(1516, 30, false);
#line 47 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore.cshtml"
          Write(comment.Username.Split('@')[0]);

#line default
#line hidden
            EndContext();
            BeginContext(1546, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
            BeginContext(1568, 14, true);
            WriteLiteral("          <p> ");
            EndContext();
            BeginContext(1583, 12, false);
#line 50 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore.cshtml"
         Write(comment.Text);

#line default
#line hidden
            EndContext();
            BeginContext(1595, 10, true);
            WriteLiteral(" <sub> <i>");
            EndContext();
            BeginContext(1606, 17, false);
#line 50 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore.cshtml"
                                Write(comment.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(1623, 20, true);
            WriteLiteral("  </i> </sub> </p>\r\n");
            EndContext();
            BeginContext(1667, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(1679, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9183b61355c1bb97cf3d86399bae255103fd286118293", async() => {
                BeginContext(1781, 7, true);
                WriteLiteral(" Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore.cshtml"
                                                                                         WriteLiteral(comment.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1792, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 54 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore.cshtml"
          
         //Reply view
         
              var replies = context.Replies.ToList();
              foreach (var reply in replies)
              {
                  if(reply.CommentId == comment.Id){
                      


#line default
#line hidden
            BeginContext(2038, 26, true);
            WriteLiteral("                      <h6>");
            EndContext();
            BeginContext(2065, 14, false);
#line 63 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore.cshtml"
                     Write(reply.Username);

#line default
#line hidden
            EndContext();
            BeginContext(2079, 32, true);
            WriteLiteral("</h6>\r\n                      <p>");
            EndContext();
            BeginContext(2112, 13, false);
#line 64 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore.cshtml"
                    Write(reply.Message);

#line default
#line hidden
            EndContext();
            BeginContext(2125, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 65 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore.cshtml"
                      
                      
                  }
              }
          
          
            // <Comment Reply Form>

#line default
#line hidden
            BeginContext(2278, 10, true);
            WriteLiteral("          ");
            EndContext();
            BeginContext(2288, 417, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9183b61355c1bb97cf3d86399bae255103fd286122525", async() => {
                BeginContext(2356, 66, true);
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"commentId\" id=\"commentId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2422, "\"", 2441, 1);
#line 73 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore.cshtml"
WriteAttributeValue("", 2430, comment.Id, 2430, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2442, 75, true);
                WriteLiteral("/>\r\n           \r\n            <input type=\"hidden\" name=\"postId\" id=\"postId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2517, "\"", 2534, 1);
#line 75 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore.cshtml"
WriteAttributeValue("", 2525, Model.Id, 2525, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2535, 163, true);
                WriteLiteral("/>\r\n            <textarea name=\"replyMessage\" id=\"replyMessage\" ></textarea>\r\n            <input type=\"submit\" class=\"btn btn-primary\" value=\"Reply\" />\r\n          ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2705, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 79 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore.cshtml"
          // </ Comment Reply Form>

#line default
#line hidden
            BeginContext(2744, 6, true);
            WriteLiteral("<hr>\r\n");
            EndContext();
#line 81 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(2768, 17, true);
            WriteLiteral("<br>\r\n   </div>\r\n");
            EndContext();
#line 85 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore.cshtml"

}
else
{

#line default
#line hidden
            BeginContext(2799, 16, true);
            WriteLiteral("    <p> No</p>\r\n");
            EndContext();
#line 90 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore.cshtml"
}

#line default
#line hidden
            BeginContext(2818, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ApplicationDbContext context { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
