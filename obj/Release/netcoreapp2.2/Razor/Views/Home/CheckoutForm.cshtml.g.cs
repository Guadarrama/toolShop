#pragma checksum "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\CheckoutForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "629d3d14110ecf77062cd07465f85fd6b3e40c8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CheckoutForm), @"mvc.1.0.view", @"/Views/Home/CheckoutForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CheckoutForm.cshtml", typeof(AspNetCore.Views_Home_CheckoutForm))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"629d3d14110ecf77062cd07465f85fd6b3e40c8f", @"/Views/Home/CheckoutForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b657e4713df1de81b83462ff2a3b1f8dc32631e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CheckoutForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/product_default.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product_default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("cartCheckout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\CheckoutForm.cshtml"
  
    ViewData["Title"] = "Checkout";

#line default
#line hidden
            BeginContext(44, 100, true);
            WriteLiteral("\r\n<h3 class=\"text-center\"> Confirm your Order </h3>\r\n\r\n<div class=\"pt-4 items-container bg-light\">\r\n");
            EndContext();
#line 8 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\CheckoutForm.cshtml"
      
            int total = 0;
            string cartString = "{";
            int track = 0;


#line default
#line hidden
            BeginContext(248, 402, true);
            WriteLiteral(@"                    <table class=""table"">
                        <thead>
                            <tr>
                                <th scope=""col"">Item</th>
                                <th scope=""col"">Price</th>
                                <th scope=""col"">Total per item</th>

                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 23 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\CheckoutForm.cshtml"
                     foreach (var item in ViewBag.ThisUser.CartItems)
                    {
                        track++;
                        if(track > 1){cartString += ", ";}
                        cartString += "\"item" + track + "\": [";
                        cartString += item.ItemInCart.ProductId.ToString() + ", ";
                        cartString += item.Amount.ToString();
                        cartString +="]";
                        total += @item.ItemInCart.Price * @item.Amount;

                        

#line default
#line hidden
            BeginContext(1194, 72, true);
            WriteLiteral("<tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1266, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "629d3d14110ecf77062cd07465f85fd6b3e40c8f7160", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1349, 82, true);
            WriteLiteral("\r\n                                <a href=\"#\" class=\"btn btn-light card-title\"><b>");
            EndContext();
            BeginContext(1432, 20, false);
#line 36 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\CheckoutForm.cshtml"
                                                                           Write(item.ItemInCart.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1452, 139, true);
            WriteLiteral("</b></a>\r\n                            </td>\r\n                            <td>\r\n                                <span class=\"product-price\">");
            EndContext();
            BeginContext(1592, 21, false);
#line 39 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\CheckoutForm.cshtml"
                                                       Write(item.ItemInCart.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1613, 17, true);
            WriteLiteral("</span> x &nbsp; ");
            EndContext();
            BeginContext(1631, 11, false);
#line 39 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\CheckoutForm.cshtml"
                                                                                              Write(item.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(1642, 91, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"product-price\">");
            EndContext();
            BeginContext(1735, 34, false);
#line 41 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\CheckoutForm.cshtml"
                                                  Write(item.ItemInCart.Price*@item.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(1770, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 43 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\CheckoutForm.cshtml"
                    }

#line default
#line hidden
            BeginContext(1831, 204, true);
            WriteLiteral("                    \r\n                            <td></td>\r\n                            <td></td>\r\n                            <td ></td>\r\n                        </tbody>\r\n                    </table>\r\n");
            EndContext();
#line 50 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\CheckoutForm.cshtml"
                cartString += "}";

#line default
#line hidden
            BeginContext(2071, 101, true);
            WriteLiteral("                <p class=\"text-center p-4\"> Order Total: <b><span class=\"product-price text-center\"> ");
            EndContext();
            BeginContext(2173, 5, false);
#line 51 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\CheckoutForm.cshtml"
                                                                                                Write(total);

#line default
#line hidden
            EndContext();
            BeginContext(2178, 17, true);
            WriteLiteral("</span></b></p>\r\n");
            EndContext();
            BeginContext(2214, 5, false);
#line 53 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\CheckoutForm.cshtml"
           Write(track);

#line default
#line hidden
            EndContext();
#line 53 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\CheckoutForm.cshtml"
                      ;

#line default
#line hidden
            BeginContext(2222, 84, true);
            WriteLiteral("                <a href=\"MyCart\" class=\"btn btn-danger\">Cancel</a>\r\n                ");
            EndContext();
            BeginContext(2306, 321, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "629d3d14110ecf77062cd07465f85fd6b3e40c8f12396", async() => {
                BeginContext(2348, 59, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"cartCount\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2407, "\"", 2421, 1);
#line 56 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\CheckoutForm.cshtml"
WriteAttributeValue("", 2415, track, 2415, 6, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2422, 58, true);
                WriteLiteral(">\r\n                    <input type=\"hidden\" name=\"cartTxt\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2480, "\"", 2499, 1);
#line 57 "C:\Users\Barron\Documents\CodingDojo\cSharp\Projects\toolShop\Views\Home\CheckoutForm.cshtml"
WriteAttributeValue("", 2488, cartString, 2488, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2500, 120, true);
                WriteLiteral(">\r\n                    <input type=\"submit\" value=\"Complete Order\" class=\"btn btn-primary text-right\">\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
            BeginContext(2627, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2636, 560, true);
            WriteLiteral(@"    </div>


    <style>
        a, form{
            display: inline-block;
        }
        .items-container{
            margin: auto;
            text-align: center;
            max-width: 700px;
        }
        .product-price:before{ content:'$'; }
        .product-price:after{ content: '.00'; }
        .product-price{
            display: inline-block;
            min-width: 5rem;
        }
        .card-img-top{
            width: 50px;
        }
        .amount-select{
            max-width: 4rem;
        }
    </style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
