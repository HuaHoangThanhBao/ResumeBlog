#pragma checksum "F:\Du-An\Net\Resume\BlogResume\BlogResume\Views\Home\Blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d61dfbbebcea5ae31d7f86f9b24bd860ec0f1dfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Blog), @"mvc.1.0.view", @"/Views/Home/Blog.cshtml")]
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
#line 1 "F:\Du-An\Net\Resume\BlogResume\BlogResume\Views\_ViewImports.cshtml"
using BlogResume;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Du-An\Net\Resume\BlogResume\BlogResume\Views\_ViewImports.cshtml"
using BlogResume.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d61dfbbebcea5ae31d7f86f9b24bd860ec0f1dfa", @"/Views/Home/Blog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1968cc7dfc0f84dccbdd5b8718f6c215f3ba5916", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Blog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/blog.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/single_blog_1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/post_1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d61dfbbebcea5ae31d7f86f9b24bd860ec0f1dfa4811", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<!--Main Container-->
<main id=""main"">
    <div class=""container-fluid"">
        <div class=""banner-container"">
            <div class=""banner-wrapper"">
                <div class=""banner-box"">
                    <div class=""banner-side"">
                        <h1 class=""pad-top-20 c-white"">
                            Blog
                        </h1>
                    </div>
                </div>
            </div>
        </div>
    </div>
</main>
<!--End Main Container-->


<div class=""main-container container-fluid"">
    <div class=""container-wrapper"">
        <section class=""box-container"">
            <div class=""box-cover"">
                <div class=""box-wrapper"">
                    <div class=""box-col-7"">
                        <div class=""post-container"">
                            <ul class=""post-list"">
                                <li class=""post-item"">
                                    <div class=""post-header"">
                                   ");
            WriteLiteral("     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d61dfbbebcea5ae31d7f86f9b24bd860ec0f1dfa7017", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        <div class=""post-time"">
                                            <p>15</p>
                                            <p>JAN</p>
                                        </div>
                                    </div>
                                    <div class=""post-content"">
                                        <h2 class=""post-title"">Google inks pact for new 35-storey office</h2>
                                        <p class=""post-cap"">
                                            That dominion stars lights dominion divide years for
                                            fourth have don't
                                            stars is that he earth it first without heaven in place seed it second
                                            morning saying.
                                        </p>
                                    </div>
                                    <div class=""post-footer"">
                          ");
            WriteLiteral(@"              <i class=""post-icon fa fa-user"">
                                            <span class=""post-icon-txt"">
                                                H.Bao
                                            </span>
                                        </i>
                                        <i class=""post-icon fa fa-comment"">
                                            <span class=""post-icon-txt"">
                                                03 Comments
                                            </span>
                                        </i>
                                    </div>
                                </li>
                                <li class=""post-item"">
                                    <div class=""post-header"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d61dfbbebcea5ae31d7f86f9b24bd860ec0f1dfa10035", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        <div class=""post-time"">
                                            <p>15</p>
                                            <p>JAN</p>
                                        </div>
                                    </div>
                                    <div class=""post-content"">
                                        <h2 class=""post-title"">Google inks pact for new 35-storey office</h2>
                                        <p class=""post-cap"">
                                            That dominion stars lights dominion divide years for
                                            fourth have don't
                                            stars is that he earth it first without heaven in place seed it second
                                            morning saying.
                                        </p>
                                    </div>
                                    <div class=""post-footer"">
                          ");
            WriteLiteral(@"              <i class=""post-icon fa fa-user"">
                                            <span class=""post-icon-txt"">
                                                H.Bao
                                            </span>
                                        </i>
                                        <i class=""post-icon fa fa-comment"">
                                            <span class=""post-icon-txt"">
                                                03 Comments
                                            </span>
                                        </i>
                                    </div>
                                </li>
                                <li class=""post-item"">
                                    <div class=""post-header"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d61dfbbebcea5ae31d7f86f9b24bd860ec0f1dfa13054", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        <div class=""post-time"">
                                            <p>15</p>
                                            <p>JAN</p>
                                        </div>
                                    </div>
                                    <div class=""post-content"">
                                        <h2 class=""post-title"">Google inks pact for new 35-storey office</h2>
                                        <p class=""post-cap"">
                                            That dominion stars lights dominion divide years for
                                            fourth have don't
                                            stars is that he earth it first without heaven in place seed it second
                                            morning saying.
                                        </p>
                                    </div>
                                    <div class=""post-footer"">
                          ");
            WriteLiteral(@"              <i class=""post-icon fa fa-user"">
                                            <span class=""post-icon-txt"">
                                                H.Bao
                                            </span>
                                        </i>
                                        <i class=""post-icon fa fa-comment"">
                                            <span class=""post-icon-txt"">
                                                03 Comments
                                            </span>
                                        </i>
                                    </div>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class=""box-col-3"">

                        <!--Search Box-->
                        <div class=""sidebar-block"">
                            <div class=""block-header"">
                                <h3>Search</h3>
           ");
            WriteLiteral(@"                 </div>
                            <div class=""block-body"">
                                <div class=""search-box"">
                                    <input class=""search-inp"" placeholder=""Search Keyword"">
                                    <i class=""search-icon fa fa-search""></i>
                                </div>
                            </div>
                        </div>
                        <!--End Search Box-->
                        <!--Category Box-->
                        <div class=""sidebar-block"">
                            <div class=""block-header"">
                                <h3>Category</h3>
                            </div>
                            <div class=""block-body"">
                                <div class=""cat-box"">
                                    <ul class=""cat-list"">
                                        <li class=""cat-item"">
                                            <p>Resaurant food (37)</p>
                 ");
            WriteLiteral(@"                       </li>
                                        <li class=""cat-item"">
                                            <p>Resaurant food (37)</p>
                                        </li>
                                        <li class=""cat-item"">
                                            <p>Resaurant food (37)</p>
                                        </li>
                                        <li class=""cat-item"">
                                            <p>Resaurant food (37)</p>
                                        </li>
                                        <li class=""cat-item"">
                                            <p>Resaurant food (37)</p>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <!--End Category Box-->
                        <!--Recent Post-->
                      ");
            WriteLiteral(@"  <div class=""sidebar-block"">
                            <div class=""block-header"">
                                <h3>Recent Posts</h3>
                            </div>
                            <div class=""block-body"">
                                <ul class=""block-list"">
                                    <li class=""block-item"">
                                        <a>
                                            <div class=""block-box"">
                                                <div class=""block-image"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d61dfbbebcea5ae31d7f86f9b24bd860ec0f1dfa19049", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                </div>
                                                <div class=""block-content"">
                                                    <div class=""block-content-cover"">
                                                        <h4 class=""block-heading"">From life was your fish</h4>
                                                        <p class=""block-txt"">January 12, 2019</p>
                                                    </div>
                                                </div>
                                            </div>
                                        </a>
                                    </li>
                                    <li class=""block-item"">
                                        <a>
                                            <div class=""block-box"">
                                                <div class=""block-image"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d61dfbbebcea5ae31d7f86f9b24bd860ec0f1dfa21167", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                </div>
                                                <div class=""block-content"">
                                                    <div class=""block-content-cover"">
                                                        <h4 class=""block-heading"">From life was your fish</h4>
                                                        <p class=""block-txt"">January 12, 2019</p>
                                                    </div>
                                                </div>
                                            </div>
                                        </a>
                                    </li>
                                    <li class=""block-item"">
                                        <a>
                                            <div class=""block-box"">
                                                <div class=""block-image"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d61dfbbebcea5ae31d7f86f9b24bd860ec0f1dfa23285", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                </div>
                                                <div class=""block-content"">
                                                    <div class=""block-content-cover"">
                                                        <h4 class=""block-heading"">
                                                            From life was your fish holy shit
                                                        </h4>
                                                        <p class=""block-txt"">January 12, 2019</p>
                                                    </div>
                                                </div>
                                            </div>
                                        </a>
                                    </li>
                                    <li class=""block-item"">
                                        <a>
                                            <div class=""block-box"">
                             ");
            WriteLiteral("                   <div class=\"block-image\">\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d61dfbbebcea5ae31d7f86f9b24bd860ec0f1dfa25566", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                </div>
                                                <div class=""block-content"">
                                                    <div class=""block-content-cover"">
                                                        <h4 class=""block-heading"">
                                                            From life was your fish holy shit
                                                        </h4>
                                                        <p class=""block-txt"">January 12, 2019</p>
                                                    </div>
                                                </div>
                                            </div>
                                        </a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                        <!--End Recent Post-->
                        <!--Tags Box-->
        ");
            WriteLiteral(@"                <div class=""sidebar-block"">
                            <div class=""block-header"">
                                <h3>Tags</h3>
                            </div>
                            <div class=""block-body"">
                                <div class=""tag-box"">
                                    <ul class=""tag-list"">
                                        <li class=""tag-item"">
                                            <a class=""tag-link"">
                                                Unity
                                            </a>
                                        </li>
                                        <li class=""tag-item"">
                                            <a class=""tag-link"">
                                                Technology
                                            </a>
                                        </li>
                                        <li class=""tag-item"">
                                          ");
            WriteLiteral(@"  <a class=""tag-link"">
                                                Travel
                                            </a>
                                        </li>
                                        <li class=""tag-item"">
                                            <a class=""tag-link"">
                                                Restaurant
                                            </a>
                                        </li>
                                        <li class=""tag-item"">
                                            <a class=""tag-link"">
                                                Life style
                                            </a>
                                        </li>
                                        <li class=""tag-item"">
                                            <a class=""tag-link"">
                                                Illustration
                                            </a>
                                  ");
            WriteLiteral(@"      </li>
                                        <li class=""tag-item"">
                                            <a class=""tag-link"">
                                                Design
                                            </a>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <!--End Tags Box-->

                    </div>
                </div>
            </div>
        </section>
    </div>
</div>");
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