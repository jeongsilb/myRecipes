#pragma checksum "C:\Users\user\Desktop\3semester\300996521\Recipes\Views\Home\ViewRecipe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8b018f2f73cf7db87c1b69165be0c7af860b8a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewRecipe), @"mvc.1.0.view", @"/Views/Home/ViewRecipe.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewRecipe.cshtml", typeof(AspNetCore.Views_Home_ViewRecipe))]
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
#line 1 "C:\Users\user\Desktop\3semester\300996521\Recipes\Views\_ViewImports.cshtml"
using Recipes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8b018f2f73cf7db87c1b69165be0c7af860b8a4", @"/Views/Home/ViewRecipe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29e173501fd56e8c84d1e285cad3352f61ef97af", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewRecipe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeResponse>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReviewRecipe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(23, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\user\Desktop\3semester\300996521\Recipes\Views\Home\ViewRecipe.cshtml"
  
    ViewBag.Title = "View Recipe";

#line default
#line hidden
            BeginContext(68, 102, true);
            WriteLiteral("\r\n    \r\n    <div class=\"container\">\r\n        <div class=\"panel-heading text-center\">\r\n            <h1>");
            EndContext();
            BeginContext(171, 14, false);
#line 10 "C:\Users\user\Desktop\3semester\300996521\Recipes\Views\Home\ViewRecipe.cshtml"
           Write(Model.FoodName);

#line default
#line hidden
            EndContext();
            BeginContext(185, 148, true);
            WriteLiteral("</h1>\r\n        </div>\r\n        <div class=\"panel-group\">\r\n            <div class=\"panel panel-default\">\r\n                <div class=\"panel-heading\">");
            EndContext();
            BeginContext(334, 14, false);
#line 14 "C:\Users\user\Desktop\3semester\300996521\Recipes\Views\Home\ViewRecipe.cshtml"
                                      Write(Model.FoodName);

#line default
#line hidden
            EndContext();
            BeginContext(348, 139, true);
            WriteLiteral(" Recipe</div>\r\n            </div>\r\n\r\n            <div class=\"panel panel-primary\">\r\n                <div class=\"panel-heading\">Uplode from ");
            EndContext();
            BeginContext(488, 14, false);
#line 18 "C:\Users\user\Desktop\3semester\300996521\Recipes\Views\Home\ViewRecipe.cshtml"
                                                  Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(502, 176, true);
            WriteLiteral("</div>\r\n            </div>\r\n\r\n            <div class=\"panel panel-info\">\r\n                <div class=\"panel-heading\">Ingredients</div>\r\n                <div class=\"panel-body\">");
            EndContext();
            BeginContext(679, 17, false);
#line 23 "C:\Users\user\Desktop\3semester\300996521\Recipes\Views\Home\ViewRecipe.cshtml"
                                   Write(Model.Ingredients);

#line default
#line hidden
            EndContext();
            BeginContext(696, 174, true);
            WriteLiteral("</div>\r\n            </div>\r\n\r\n            <div class=\"panel panel-success\">\r\n                <div class=\"panel-heading\">Recipe</div>\r\n                <div class=\"panel-body\">");
            EndContext();
            BeginContext(871, 16, false);
#line 28 "C:\Users\user\Desktop\3semester\300996521\Recipes\Views\Home\ViewRecipe.cshtml"
                                   Write(Model.FoodRecipe);

#line default
#line hidden
            EndContext();
            BeginContext(887, 52, true);
            WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n        ");
            EndContext();
            BeginContext(939, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a045d27e778944efa9dfa2f4f72e3196", async() => {
                BeginContext(1002, 13, true);
                WriteLiteral("Review Recipe");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1019, 24, true);
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591