#pragma checksum "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\WishLists\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb55c3c9b97283956aba02d4733baf68d66b3a40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_WishLists_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/WishLists/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/WishLists/Index.cshtml", typeof(AspNetCore.Areas_Customer_Views_WishLists_Index))]
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
#line 1 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\_ViewImports.cshtml"
using CVGS;

#line default
#line hidden
#line 2 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\_ViewImports.cshtml"
using CVGS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb55c3c9b97283956aba02d4733baf68d66b3a40", @"/Areas/Customer/Views/WishLists/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50662a4b06b34ddc6a7692a13ac4f749ea9cc64c", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_WishLists_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CVGS.Models.WishLists>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom:.5rem"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "StoreFront", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GameDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "WishLists", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Carts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToFriendCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\WishLists\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(131, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\WishLists\Index.cshtml"
 if (ViewBag.otherMemberName == null)
{

#line default
#line hidden
            BeginContext(175, 113, true);
            WriteLiteral("    <div class=\"jumbotron text-center header\">\r\n        <h1 class=\"display-4 header-text\">Your Wish List Total: $");
            EndContext();
            BeginContext(289, 21, false);
#line 10 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\WishLists\Index.cshtml"
                                                            Write(ViewBag.totalWishList);

#line default
#line hidden
            EndContext();
            BeginContext(310, 19, true);
            WriteLiteral("</h1>\r\n    </div>\r\n");
            EndContext();
#line 12 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\WishLists\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(341, 103, true);
            WriteLiteral("    <div class=\"jumbotron text-center header\">\r\n        <h1 class=\"display-4 header-text\">Wish List of ");
            EndContext();
            BeginContext(445, 23, false);
#line 16 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\WishLists\Index.cshtml"
                                                  Write(ViewBag.otherMemberName);

#line default
#line hidden
            EndContext();
            BeginContext(468, 57, true);
            WriteLiteral("</h1>\r\n        <h2 class=\"display-4 header-text\">Total: $");
            EndContext();
            BeginContext(526, 21, false);
#line 17 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\WishLists\Index.cshtml"
                                             Write(ViewBag.totalWishList);

#line default
#line hidden
            EndContext();
            BeginContext(547, 19, true);
            WriteLiteral("</h2>\r\n    </div>\r\n");
            EndContext();
#line 19 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\WishLists\Index.cshtml"
}

#line default
#line hidden
            BeginContext(569, 46, true);
            WriteLiteral("\r\n\r\n<div class=\"my-container text-center\">\r\n\r\n");
            EndContext();
#line 24 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\WishLists\Index.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
            BeginContext(658, 124, true);
            WriteLiteral("        <div class=\"card moveInLeftEffect\" style=\"width: 18rem; margin-bottom:2rem;\">\r\n            <img class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 782, "\"", 830, 1);
#line 28 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\WishLists\Index.cshtml"
WriteAttributeValue("", 788, Html.DisplayFor(m => item.Games.GameLink), 788, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(831, 126, true);
            WriteLiteral(" alt=\"Card image cap\">\r\n            <div class=\"card-body\" style=\"position:relative\">\r\n                <h5 class=\"card-title\">");
            EndContext();
            BeginContext(958, 38, false);
#line 30 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\WishLists\Index.cshtml"
                                  Write(Html.DisplayFor(m => item.Games.Title));

#line default
#line hidden
            EndContext();
            BeginContext(996, 44, true);
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">");
            EndContext();
            BeginContext(1041, 44, false);
#line 31 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\WishLists\Index.cshtml"
                                Write(Html.DisplayFor(m => item.Games.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1085, 51, true);
            WriteLiteral("</p>\r\n                <p class=\"card-text\">Rating: ");
            EndContext();
            BeginContext(1137, 39, false);
#line 32 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\WishLists\Index.cshtml"
                                        Write(Html.DisplayFor(m => item.Games.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(1176, 46, true);
            WriteLiteral("/5</p>\r\n                <p class=\"card-text\">$");
            EndContext();
            BeginContext(1223, 38, false);
#line 33 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\WishLists\Index.cshtml"
                                 Write(Html.DisplayFor(m => item.Games.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1261, 22, true);
            WriteLiteral("</p>\r\n                ");
            EndContext();
            BeginContext(1283, 149, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88f7b4481d364ecc891155e276373d0f", async() => {
                BeginContext(1421, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 34 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\WishLists\Index.cshtml"
                                                                                                      WriteLiteral(item.Games.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1432, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1450, 135, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "517c575af0dd48489d56af2edb9829a8", async() => {
                BeginContext(1575, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\WishLists\Index.cshtml"
                                                                                                WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1585, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 36 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\WishLists\Index.cshtml"
                 if (ViewBag.otherMemberName != null)
                {

#line default
#line hidden
            BeginContext(1661, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1681, 201, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c71e63ef28b4a5e88251a12f50c9438", async() => {
                BeginContext(1867, 11, true);
                WriteLiteral("Add to Cart");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-gameId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 38 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\WishLists\Index.cshtml"
                                                                                                             WriteLiteral(item.Games.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gameId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-gameId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gameId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 38 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\WishLists\Index.cshtml"
                                                                                                                                               WriteLiteral(item.ApplicationUserId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1882, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 39 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\WishLists\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1903, 40, true);
            WriteLiteral("                </div>\r\n        </div>\r\n");
            EndContext();
#line 42 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\WishLists\Index.cshtml"

    }

#line default
#line hidden
            BeginContext(1952, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CVGS.Models.WishLists>> Html { get; private set; }
    }
}
#pragma warning restore 1591
