#pragma checksum "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\Home\ShowProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c4a01ffaf72af1a045e1c7d6997b79dbbdea71b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowProduct), @"mvc.1.0.view", @"/Views/Home/ShowProduct.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ShowProduct.cshtml", typeof(AspNetCore.Views_Home_ShowProduct))]
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
#line 1 "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\_ViewImports.cshtml"
using Auctions;

#line default
#line hidden
#line 1 "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\Home\ShowProduct.cshtml"
using Auctions.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c4a01ffaf72af1a045e1c7d6997b79dbbdea71b", @"/Views/Home/ShowProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bea55a7b78ce2fb8d02008b61d6edeba4a7a9df", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 32, true);
            WriteLiteral("\r\n<div class=\"inline\">\r\n    <h1>");
            EndContext();
            BeginContext(73, 10, false);
#line 5 "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\Home\ShowProduct.cshtml"
   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(83, 100, true);
            WriteLiteral("</h1>\r\n    <a href=\"/dashboard\">Home</a>\r\n    <a href=\"/logout\">Logout</a>\r\n</div>\r\n<h4>Created by: ");
            EndContext();
            BeginContext(184, 22, false);
#line 9 "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\Home\ShowProduct.cshtml"
           Write(Model.Seller.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(206, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 10 "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\Home\ShowProduct.cshtml"
  
    TimeSpan days = Model.EndDate - DateTime.Now;
    days.ToString();

#line default
#line hidden
            BeginContext(293, 27, true);
            WriteLiteral("\r\n<p>\r\n    Time Remaining: ");
            EndContext();
            BeginContext(321, 9, false);
#line 16 "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\Home\ShowProduct.cshtml"
               Write(days.Days);

#line default
#line hidden
            EndContext();
            BeginContext(330, 66, true);
            WriteLiteral(" day(s)</p>\r\n\r\n    <br /><label>Product Description: </label>\r\n<p>");
            EndContext();
            BeginContext(397, 17, false);
#line 19 "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\Home\ShowProduct.cshtml"
Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(414, 83, true);
            WriteLiteral("</p>\r\n\r\n\r\n<table>\r\n    <tr>\r\n        <td><label>Current Highest Bid:</label></td>\r\n");
            EndContext();
            BeginContext(509, 23, true);
            WriteLiteral("            <td><label>");
            EndContext();
            BeginContext(533, 16, false);
#line 26 "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\Home\ShowProduct.cshtml"
                  Write(Model.HighestBid);

#line default
#line hidden
            EndContext();
            BeginContext(549, 15, true);
            WriteLiteral("</label></td>\r\n");
            EndContext();
            BeginContext(575, 37, true);
            WriteLiteral("\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n");
            EndContext();
#line 32 "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\Home\ShowProduct.cshtml"
              
                if (ViewBag.HighestBid != null)
                {

#line default
#line hidden
            BeginContext(696, 30, true);
            WriteLiteral("                    <label>By ");
            EndContext();
            BeginContext(727, 33, false);
#line 35 "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\Home\ShowProduct.cshtml"
                         Write(ViewBag.HighestBid.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(760, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(762, 32, false);
#line 35 "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\Home\ShowProduct.cshtml"
                                                            Write(ViewBag.HighestBid.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(794, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
#line 36 "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\Home\ShowProduct.cshtml"
                }
            

#line default
#line hidden
            BeginContext(838, 64, true);
            WriteLiteral("        </td>\r\n    </tr>\r\n    <tr>\r\n\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(902, 262, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8284ae8564ee4429ae5ccaf3175b769d", async() => {
                BeginContext(953, 24, true);
                WriteLiteral("\r\n                <span>");
                EndContext();
                BeginContext(978, 16, false);
#line 44 "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\Home\ShowProduct.cshtml"
                 Write(ViewBag.BidError);

#line default
#line hidden
                EndContext();
                BeginContext(994, 163, true);
                WriteLiteral("</span>\r\n                <input type=\"number\" name=\"UserBid\" /><br />\r\n        </td>\r\n        <td>\r\n            <input type=\"submit\" value=\"Bid!!\" />\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 916, "/bid/", 916, 5, true);
#line 43 "D:\CodingDojo\C_Sharp\ORM\Entity\Auctions\Views\Home\ShowProduct.cshtml"
AddHtmlAttributeValue("", 921, Model.ProductId, 921, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1164, 48, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n</table>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
