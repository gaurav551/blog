#pragma checksum "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d03c4e0304b7507317d1c2c68700a8400a0a5ed2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_SeeMore1), @"mvc.1.0.view", @"/Views/Post/SeeMore1.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/SeeMore1.cshtml", typeof(AspNetCore.Views_Post_SeeMore1))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d03c4e0304b7507317d1c2c68700a8400a0a5ed2", @"/Views/Post/SeeMore1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07b827f7061c08fb2045185d938215d665304388", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_SeeMore1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PointUp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SeeMore1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("read-more-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("reply"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(53, 604, true);
            WriteLiteral(@" <section class=""blog-details-area section-padding-80"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""blog-details-content"">
                        <!--  Details  -->
                        <div class=""post-details-text"">

                            <div class=""row justify-content-center"">
                                <div class=""col-12 col-lg-10"">
                                    <div class=""post-content text-center mb-50"">
                                        <a href=""#"" class=""post-date"">");
            EndContext();
            BeginContext(658, 30, false);
#line 15 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore1.cshtml"
                                                                 Write(Model.Date.ToString("MMMM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(688, 50, true);
            WriteLiteral("</a>\r\n                                        <h2>");
            EndContext();
            BeginContext(739, 13, false);
#line 16 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore1.cshtml"
                                       Write(Model.Heading);

#line default
#line hidden
            EndContext();
            BeginContext(752, 199, true);
            WriteLiteral("</h2>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"col-12\">\r\n                                    <img class=\"mb-50\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 951, "\"", 981, 2);
            WriteAttributeValue("", 957, "/images/", 957, 8, true);
#line 20 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore1.cshtml"
WriteAttributeValue("", 965, Model.PhotoName, 965, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(982, 155, true);
            WriteLiteral(" alt=\"\">\r\n                                </div>\r\n                                <div class=\"col-12 col-lg-10\">\r\n                                    <h5> ");
            EndContext();
            BeginContext(1138, 27, false);
#line 23 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore1.cshtml"
                                    Write(Html.Raw(Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1165, 526, true);
            WriteLiteral(@" </h5>
                                    
                          
                                    <!-- Post Catagories & Post Share -->
                                    <div class=""d-flex align-items-center justify-content-between"">
                                        <!-- Post Catagories -->
                                        <div class=""post-catagories"">
                                            <ul class=""d-flex flex-wrap align-items-center"">
                                      <li>   ");
            EndContext();
            BeginContext(1691, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d03c4e0304b7507317d1c2c68700a8400a0a5ed29330", async() => {
                BeginContext(1763, 7, true);
                WriteLiteral("Likes: ");
                EndContext();
                BeginContext(1771, 11, false);
#line 31 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore1.cshtml"
                                                                                                                       Write(Model.Point);

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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 31 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore1.cshtml"
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
            BeginContext(1786, 78, true);
            WriteLiteral(" </li>\r\n\r\n                                                <li>  <a href=\"#\"> #");
            EndContext();
            BeginContext(1865, 14, false);
#line 33 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore1.cshtml"
                                                               Write(Model.Category);

#line default
#line hidden
            EndContext();
            BeginContext(1879, 1514, true);
            WriteLiteral(@"</a></li>
                                                
                                                
                                            </ul>
                                        </div>

                                        <!-- Post Share -->
                                       <div class=""uza-post-share d-flex align-items-center"">
                                            <h6 class=""mb-0 mr-3"">Share:</h6>
                                            <div class=""social-info-"">
                                                <a href=""#""><i class=""fa fa-facebook"" aria-hidden=""true""></i></a>
                                                <a href=""#""><i class=""fa fa-twitter"" aria-hidden=""true""></i></a>
                                                <a href=""#""><i class=""fa fa-google-plus"" aria-hidden=""true""></i></a>
                                                <a href=""#""><i class=""fa fa-linkedin"" aria-hidden=""true""></i></a>
                                           ");
            WriteLiteral(@"     <a href=""#""><i class=""fa fa-envelope"" aria-hidden=""true""></i></a>
                                            </div>
                                        </div>

                                    </div>
                                    <!-- Related News Area -->
                                    <div class=""related-news-area"">
                                        <h2 class=""mb-4"">Relatest Posts</h2>

                                        <div class=""row"">
");
            EndContext();
#line 57 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore1.cshtml"
                                       foreach(var posts in ViewBag.RelatedPosts)
                                                        {
                                                            
                                            

#line default
#line hidden
            BeginContext(3643, 165, true);
            WriteLiteral("                                            <div class=\"col-12 col-lg-6\">\r\n                                                <div class=\"single-blog-post bg-img mb-50\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 3808, "\"", 3866, 4);
            WriteAttributeValue("", 3816, "background-image:", 3816, 17, true);
            WriteAttributeValue(" ", 3833, "url(.~/images/", 3834, 15, true);
#line 62 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore1.cshtml"
WriteAttributeValue("", 3848, posts.PhotoName, 3848, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 3864, ");", 3864, 2, true);
            EndWriteAttribute();
            BeginContext(3867, 273, true);
            WriteLiteral(@">
                                            
                                                    <div class=""post-content"">
                                                        
                                                        <span class=""post-date""><span>");
            EndContext();
            BeginContext(4141, 30, false);
#line 66 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore1.cshtml"
                                                                                 Write(posts.Date.ToString("MMMM dd"));

#line default
#line hidden
            EndContext();
            BeginContext(4171, 96, true);
            WriteLiteral("</span>\r\n                                                        <a href=\"#\" class=\"post-title\">");
            EndContext();
            BeginContext(4268, 13, false);
#line 67 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore1.cshtml"
                                                                                  Write(posts.Heading);

#line default
#line hidden
            EndContext();
            BeginContext(4281, 65, true);
            WriteLiteral("</a>\r\n                                                        <p>");
            EndContext();
            BeginContext(4347, 100, false);
#line 68 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore1.cshtml"
                                                      Write(Html.Raw(posts.Description.Length>200? posts.Description.Substring(0,199)+"..." : posts.Description));

#line default
#line hidden
            EndContext();
            BeginContext(4447, 62, true);
            WriteLiteral("</p>\r\n                                                        ");
            EndContext();
            BeginContext(4509, 175, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d03c4e0304b7507317d1c2c68700a8400a0a5ed217330", async() => {
                BeginContext(4635, 45, true);
                WriteLiteral("Read More <i class=\"arrow_carrot-2right\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 69 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore1.cshtml"
                                                                                                         WriteLiteral(posts.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 69 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore1.cshtml"
                                                                                                                                   WriteLiteral(posts.Category);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cat"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-cat", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cat"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4684, 175, true);
            WriteLiteral("\r\n\r\n                                                       </div>\r\n                                                </div>\r\n                                            </div>\r\n");
            EndContext();
#line 74 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore1.cshtml"
                                                            
                                                        }

#line default
#line hidden
            BeginContext(4980, 678, true);
            WriteLiteral(@"                                                    </div>

                                         
                                            
                                        </div>
                                    </div> 

                                    <!-- Comments Area -->
                
                                    <div class=""comment_area mb-50 clearfix"">
                                        
                                            
                                        
                                       
                                            
                                        <h5 class=""title"">");
            EndContext();
            BeginContext(5659, 22, false);
#line 91 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore1.cshtml"
                                                     Write(ViewBag.Comments.Count);

#line default
#line hidden
            EndContext();
            BeginContext(5681, 461, true);
            WriteLiteral(@" Comments</h5>
                                        
                                        <ol>
                                        
                                            
                                               
                                                <div class=""comment-content d-flex"">
                                                    
                                                    <div class=""comment-meta"">
");
            EndContext();
#line 100 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore1.cshtml"
                                                         foreach (var item in ViewBag.Comments)
                                                        {
                                                           
                                                        

#line default
#line hidden
            BeginContext(6417, 86, true);
            WriteLiteral("                                                        <a href=\"#\" class=\"post-date\">");
            EndContext();
            BeginContext(6504, 34, false);
#line 104 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore1.cshtml"
                                                                                 Write(item.CreatedAt.ToString("MMMM dd"));

#line default
#line hidden
            EndContext();
            BeginContext(6538, 205, true);
            WriteLiteral("</a>\r\n                                                        <div class=\"comment-author\">\r\n                                                   \r\n                                                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 6743, "\"", 6772, 2);
            WriteAttributeValue("", 6749, "/images/", 6749, 8, true);
#line 107 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore1.cshtml"
WriteAttributeValue("", 6757, item.PhotoName, 6757, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6773, 83, true);
            WriteLiteral(" alt=\"commenter\">\r\n                                                    </div>  <h5>");
            EndContext();
            BeginContext(6857, 27, false);
#line 108 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore1.cshtml"
                                                           Write(item.Username.Split('@')[0]);

#line default
#line hidden
            EndContext();
            BeginContext(6884, 66, true);
            WriteLiteral("</h5>\r\n                                                        <p>");
            EndContext();
            BeginContext(6951, 9, false);
#line 109 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore1.cshtml"
                                                      Write(item.Text);

#line default
#line hidden
            EndContext();
            BeginContext(6960, 246, true);
            WriteLiteral("</p>\r\n                                                        <a href=\"#\" class=\"like\">Like</a>\r\n                                                        <a href=\"#\" class=\"reply\">Reply</a>\r\n                                                        ");
            EndContext();
            BeginContext(7206, 134, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d03c4e0304b7507317d1c2c68700a8400a0a5ed225693", async() => {
                BeginContext(7329, 7, true);
                WriteLiteral(" Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-cat", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 112 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore1.cshtml"
                                                                                                                              WriteLiteral(Model.Category);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cat"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-cat", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cat"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 112 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore1.cshtml"
                                                                                                                                                             WriteLiteral(item.Id);

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
            BeginContext(7340, 126, true);
            WriteLiteral("\r\n                                                        <br>\r\n                                                        <br>\r\n");
            EndContext();
#line 115 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore1.cshtml"
                                                        }

#line default
#line hidden
            BeginContext(7525, 525, true);
            WriteLiteral(@"                                                    </div>
                                                </div>
                           

                                         
        
                                    <!-- comment form starts Here -->
                                    <div class=""uza-contact-form"">
                                        <div class=""container"">
                                        <h2 class=""mb-4"">Leave A Comment</h2>

                                        ");
            EndContext();
            BeginContext(8050, 1138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d03c4e0304b7507317d1c2c68700a8400a0a5ed230120", async() => {
                BeginContext(8116, 283, true);
                WriteLiteral(@"
                                            <div class=""row"">
                                               <input  type=""hidden"" id=""commentCreatedAt"" name=""commentCreatedAt""> 
                                                      <input type=""hidden"" name=""postId"" id=""postId""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 8399, "\"", 8416, 1);
#line 130 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore1.cshtml"
WriteAttributeValue("", 8407, Model.Id, 8407, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8417, 458, true);
                WriteLiteral(@"/>
                                                <div class=""col-12"">
                                                    <textarea id=""commentText"" name=""commentText"" class=""form-control mb-30"" placeholder=""Comment"" required></textarea>
                                                </div>
                                            <div class=""col-12"">
                                                <input  type=""hidden"" id=""Photo"" name=""Photo""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 8875, "\"", 8899, 1);
#line 135 "C:\Users\Lenovo\Desktop\DotNet\DotNet\New\blog\Views\Post\SeeMore1.cshtml"
WriteAttributeValue("", 8883, Model.PhotoName, 8883, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8900, 281, true);
                WriteLiteral(@">
                                                    <button type=""submit"" class=""btn uza-btn btn-3 mt-15""> Post Comment</button>
                                                </div>
                                            </div>
                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9188, 309, true);
            WriteLiteral(@"
                                    </div>
                                   </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
   
   ");
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
