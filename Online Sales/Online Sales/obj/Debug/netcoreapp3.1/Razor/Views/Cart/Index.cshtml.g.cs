#pragma checksum "D:\asp.net core\OnlineSales\Online Sales\Online Sales\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c759ada37ff47766c841ecfa79c532be7f32bf2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "D:\asp.net core\OnlineSales\Online Sales\Online Sales\Views\_ViewImports.cshtml"
using Online_Sales;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\asp.net core\OnlineSales\Online Sales\Online Sales\Views\_ViewImports.cshtml"
using OnlineSalesEntity.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\asp.net core\OnlineSales\Online Sales\Online Sales\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\asp.net core\OnlineSales\Online Sales\Online Sales\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c759ada37ff47766c841ecfa79c532be7f32bf2d", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"371adce261182407f17ce7dced7c80dc61dcaf73", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Online_Sales.Models.CartModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<h1 class=""h3"">Shopping Cart</h1>
<hr>
<div class=""row"">
    <div class=""col-md-8"">
        <div class=""text-left"">
            <h4>Cart Items</h4>
        </div>
        <table class=""table table-hover"">
            <thead>
                <tr>
                    <th></th>
                    <th>Product Name</th>
                    <th>Price</th>
                    <th>Quantity</th>
                    <th>Total</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 22 "D:\asp.net core\OnlineSales\Online Sales\Online Sales\Views\Cart\Index.cshtml"
                 foreach (var item in Model.CartItems)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c759ada37ff47766c841ecfa79c532be7f32bf2d5082", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 747, "~/img/", 747, 6, true);
#nullable restore
#line 26 "D:\asp.net core\OnlineSales\Online Sales\Online Sales\Views\Cart\Index.cshtml"
AddHtmlAttributeValue("", 753, item.ImageUrl, 753, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 28 "D:\asp.net core\OnlineSales\Online Sales\Online Sales\Views\Cart\Index.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "D:\asp.net core\OnlineSales\Online Sales\Online Sales\Views\Cart\Index.cshtml"
                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "D:\asp.net core\OnlineSales\Online Sales\Online Sales\Views\Cart\Index.cshtml"
                       Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "D:\asp.net core\OnlineSales\Online Sales\Online Sales\Views\Cart\Index.cshtml"
                        Write(item.Quantity*item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                        <td>
                            <button class=""btn btn-danger btn-sm"">
                                <i class=""fa fa-times fa-fw""></i>
                            </button>
                        </td>
                    </tr>
");
#nullable restore
#line 38 "D:\asp.net core\OnlineSales\Online Sales\Online Sales\Views\Cart\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
    <div class=""col-md-4"">
        <div class=""text-left"">
            <h4>Cart Summary</h4>
        </div>
        <table class=""table"">
            <tbody>
                <tr>
                    <th>Cart Total</th>
                    <td>");
#nullable restore
#line 50 "D:\asp.net core\OnlineSales\Online Sales\Online Sales\Views\Cart\Index.cshtml"
                   Write(Model.TotalPrice().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>Shipping</th>\r\n                    <th>Free</th>\r\n                </tr>\r\n                <tr>\r\n                    <th>Order Total</th>\r\n                    <th>");
#nullable restore
#line 58 "D:\asp.net core\OnlineSales\Online Sales\Online Sales\Views\Cart\Index.cshtml"
                   Write(Model.TotalPrice().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                </tr>
            </tbody>
        </table>
        <div class=""text-center"">
            <a href=""/"" class=""btn btn-primary"">
                <i class=""fa fa-arrow-circle-left fa-fw""></i> Alışverişe Devam Et
            </a>
            <a href=""/checkout"" class=""btn btn-primary"">
                <i class=""fa fa-arrow-circle-right fa-fw""></i> Checkout
            </a>
        </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Online_Sales.Models.CartModel> Html { get; private set; }
    }
}
#pragma warning restore 1591