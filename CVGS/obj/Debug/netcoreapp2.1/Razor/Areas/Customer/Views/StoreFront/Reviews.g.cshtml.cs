#pragma checksum "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\StoreFront\Reviews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77142c8f47566c388f44aebcf22309b5bbfe90ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_StoreFront_Reviews), @"mvc.1.0.view", @"/Areas/Customer/Views/StoreFront/Reviews.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/StoreFront/Reviews.cshtml", typeof(AspNetCore.Areas_Customer_Views_StoreFront_Reviews))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77142c8f47566c388f44aebcf22309b5bbfe90ea", @"/Areas/Customer/Views/StoreFront/Reviews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50662a4b06b34ddc6a7692a13ac4f749ea9cc64c", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_StoreFront_Reviews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CVGS.Models.Reviews>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "StoreFront", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditReview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\StoreFront\Reviews.cshtml"
  
    ViewData["Title"] = "Reviews";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(131, 18, true);
            WriteLiteral("\r\n<h2>Reviews for ");
            EndContext();
            BeginContext(150, 16, false);
#line 7 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\StoreFront\Reviews.cshtml"
           Write(ViewBag.gameName);

#line default
#line hidden
            EndContext();
            BeginContext(166, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
            BeginContext(173, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a82c129ca164183a53a39780720343e", async() => {
                BeginContext(247, 13, true);
                WriteLiteral("Back to Store");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(264, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\StoreFront\Reviews.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(299, 51, true);
            WriteLiteral("<div class=\"jumbotron\">\r\n    <h4 class=\"display-4\">");
            EndContext();
            BeginContext(351, 10, false);
#line 12 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\StoreFront\Reviews.cshtml"
                     Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(361, 23, true);
            WriteLiteral("</h4>\r\n    <h5>Author: ");
            EndContext();
            BeginContext(385, 29, false);
#line 13 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\StoreFront\Reviews.cshtml"
           Write(item.ApplicationUser.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(414, 14, true);
            WriteLiteral("</h5>\r\n    <p>");
            EndContext();
            BeginContext(429, 9, false);
#line 14 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\StoreFront\Reviews.cshtml"
  Write(item.Body);

#line default
#line hidden
            EndContext();
            BeginContext(438, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 15 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\StoreFront\Reviews.cshtml"
     if (User.Identity.Name == item.ApplicationUser.UserName)
    {

#line default
#line hidden
            BeginContext(514, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(522, 123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31878e09472d4dfbb49208394363d169", async() => {
                BeginContext(625, 16, true);
                WriteLiteral("Edit Your Review");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 17 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\StoreFront\Reviews.cshtml"
                                     WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(645, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 18 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\StoreFront\Reviews.cshtml"
    }

#line default
#line hidden
            BeginContext(654, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
#line 21 "C:\Users\dk95g\Desktop\Iteration3\Construction\cvgs-iteration_3\CVGS\Areas\Customer\Views\StoreFront\Reviews.cshtml"
}

#line default
#line hidden
            BeginContext(667, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CVGS.Models.Reviews>> Html { get; private set; }
    }
}
#pragma warning restore 1591
