#pragma checksum "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7984956b093045022b8cc7e83bdfc18b0883be48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
#line 1 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\_ViewImports.cshtml"
using toolShop;

#line default
#line hidden
#line 2 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\_ViewImports.cshtml"
using toolShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7984956b093045022b8cc7e83bdfc18b0883be48", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b657e4713df1de81b83462ff2a3b1f8dc32631e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserCart>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/tools.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("_ tools"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/product_default.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product_default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/addItemToCart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
            BeginContext(62, 32, true);
            WriteLiteral("\r\n<div class=\"image-text\">\r\n    ");
            EndContext();
            BeginContext(94, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7984956b093045022b8cc7e83bdfc18b0883be487001", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(179, 29, true);
            WriteLiteral("\r\n    <h3 class=\"text\">Hello ");
            EndContext();
            BeginContext(209, 26, false);
#line 8 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\Dashboard.cshtml"
                      Write(ViewBag.ThisUser.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(235, 77, true);
            WriteLiteral(", welcome to The Tool Shed</h3>\r\n</div>\r\n<div class=\"pt-4 items-container\">\r\n");
            EndContext();
#line 11 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\Dashboard.cshtml"
      
        foreach(var item in ViewBag.AllProducts)
        {
            if(item.Seller.UserId != ViewBag.CurrentUserId)
            {

#line default
#line hidden
            BeginContext(457, 239, true);
            WriteLiteral("                <div class=\"card text-left\" style=\"width: 17rem;\">\r\n                    <div class=\"card-top m-2 border border-dark text-center\" style=\"width:16rem\">\r\n                        <a href=\"#\" class=\"btn btn-light card-title\"><b>");
            EndContext();
            BeginContext(697, 9, false);
#line 18 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\Dashboard.cshtml"
                                                                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(706, 34, true);
            WriteLiteral("</b></a>\r\n                        ");
            EndContext();
            BeginContext(740, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7984956b093045022b8cc7e83bdfc18b0883be489952", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(835, 84, true);
            WriteLiteral("\r\n                        <p class=\"text-left\" style=\"margin-left: 0.7rem;\">Seller: ");
            EndContext();
            BeginContext(920, 21, false);
#line 20 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\Dashboard.cshtml"
                                                                             Write(item.Seller.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(941, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(943, 20, false);
#line 20 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\Dashboard.cshtml"
                                                                                                    Write(item.Seller.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(963, 181, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n                        <div>\r\n                            <span style=\"font-size:0.7rem;\">AVAILABLE: ");
            EndContext();
            BeginContext(1145, 13, false);
#line 24 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\Dashboard.cshtml"
                                                                  Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1158, 99, true);
            WriteLiteral("</span>\r\n                            <span class=\"product-price\">\r\n                                ");
            EndContext();
            BeginContext(1258, 10, false);
#line 26 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\Dashboard.cshtml"
                           Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1268, 67, true);
            WriteLiteral("\r\n                            </span>\r\n                            ");
            EndContext();
            BeginContext(1335, 698, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7984956b093045022b8cc7e83bdfc18b0883be4813336", async() => {
                BeginContext(1379, 113, true);
                WriteLiteral("\r\n                                <select name=\"amount\" id=\"\" class=\"form-control form-control-sm cart-select\">\r\n");
                EndContext();
#line 30 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\Dashboard.cshtml"
                                 for(int i=1; @item.Quantity+1>i ;i++)
                                {

#line default
#line hidden
                BeginContext(1599, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(1635, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7984956b093045022b8cc7e83bdfc18b0883be4814230", async() => {
                    BeginContext(1655, 1, false);
#line 32 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\Dashboard.cshtml"
                                                  Write(i);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 32 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\Dashboard.cshtml"
                                       WriteLiteral(i);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1665, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 33 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\Dashboard.cshtml"
                                }

#line default
#line hidden
                BeginContext(1702, 127, true);
                WriteLiteral("                                </select>\r\n                                <input type=\"hidden\" id=\"ProductId\" name=\"ProductId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1829, "\"", 1852, 1);
#line 35 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 1837, item.ProductId, 1837, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1853, 173, true);
                WriteLiteral(">\r\n                                <input type=\"submit\" class=\"btn btn-warning cart-button\" style=\"font-size:0.8rem;\" value=\"Add to &#128722;\">\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2033, 120, true);
            WriteLiteral("\r\n\r\n                        </div>\r\n                        <p class=\"card-text mt-3 p-1\">\r\n                            ");
            EndContext();
            BeginContext(2154, 16, false);
#line 41 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\Dashboard.cshtml"
                       Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2170, 110, true);
            WriteLiteral("\r\n                        </p>\r\n                        \r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 46 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\Dashboard.cshtml"
            }

        }
    

#line default
#line hidden
            BeginContext(2315, 1215, true);
            WriteLiteral(@"</div>



<style> 
    .items-container{
        text-align: center;
    }
    .product-price:before{ content:'$'; }
    .product-price:after{ content: '.00'; }
    .product-price{
        display: inline-block;
        min-width: 10.8rem;
    }

    .card-text{
        min-height: 7rem;
        max-height: 7rem;
        min-width: 15rem;
        max-height: 15rem;
        border-radius: 0.5rem;
        background-color: #afffff;
    }
    .card-title{
        text-align: left;
        min-width: 15rem;
        max-width: 15rem;
        text-overflow: ellipsis;
        overflow: hidden;
        white-space: nowrap;
    }
    .card{
        display: inline-block;
        vertical-align: top;
    }
    .cart-select{
        width: 4rem;
        display: inline-block;
    }
    .cart-button{
        display: inline-block;
    }
    .image-text{
        height: 100px;
        overflow: hidden;
        position: relative;
        text-align: center;
        color: whi");
            WriteLiteral("te;\r\n    }\r\n    .text{\r\n        text-shadow: 2px 2px 8px black;\r\n        position: absolute;\r\n        top: 50%;\r\n        left: 50%;\r\n        transform: translate(-50%, -50%);\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserCart> Html { get; private set; }
    }
}
#pragma warning restore 1591