#pragma checksum "C:\Users\School\Desktop\web\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserQuotes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f837fcea9265bc3b8d51559ca7bf3a2ce52d922f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(YYRA_Team_Project.Pages.Users.Pages_Users_UserQuotes), @"mvc.1.0.razor-page", @"/Pages/Users/UserQuotes.cshtml")]
namespace YYRA_Team_Project.Pages.Users
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
#line 1 "C:\Users\School\Desktop\web\PROJECT\YYRA Team Project\YYRA Team Project\Pages\_ViewImports.cshtml"
using YYRA_Team_Project;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f837fcea9265bc3b8d51559ca7bf3a2ce52d922f", @"/Pages/Users/UserQuotes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f4e1e3b15a3e7f45a41a8ed75100a3b1fe2f3f3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Users_UserQuotes : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("flex-wrap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\School\Desktop\web\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserQuotes.cshtml"
  
    ViewData["Title"] = "UserQuotes";
    ViewData["Username"] = Model._context.getUsername(Model._cache);
    ViewData["Role"] = Model._context.getRole(Model._cache);
    ViewData["Id"] = Model._context.getId(Model._cache);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>User Quotes</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f837fcea9265bc3b8d51559ca7bf3a2ce52d922f3932", async() => {
                WriteLiteral("\r\n    <table class=\"table table-hover\">\r\n\r\n        <tbody class=\"bg-info align-content-center flex-row border\">\r\n");
#nullable restore
#line 17 "C:\Users\School\Desktop\web\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserQuotes.cshtml"
             foreach (var quote in Model.Quotes)
            {
                if ( quote.UserID == Model.CurrentID)

                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr class=\"border-top\">\r\n                    <td scope=\"row\">\r\n                        ");
#nullable restore
#line 24 "C:\Users\School\Desktop\web\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserQuotes.cshtml"
                   Write(Html.DisplayFor(modelItem => quote.UserID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 27 "C:\Users\School\Desktop\web\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserQuotes.cshtml"
                   Write(Html.DisplayFor(modelItem => quote.Q_Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 30 "C:\Users\School\Desktop\web\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserQuotes.cshtml"
                   Write(Html.DisplayFor(modelItem => quote.Q_Date));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 33 "C:\Users\School\Desktop\web\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserQuotes.cshtml"
                   Write(Html.DisplayFor(modelItem => quote.Q_Gallons));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 36 "C:\Users\School\Desktop\web\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserQuotes.cshtml"
                   Write(Html.DisplayFor(modelItem => quote.Q_Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 39 "C:\Users\School\Desktop\web\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserQuotes.cshtml"
                   Write(Html.DisplayFor(modelItem => quote.Q_Total));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 43 "C:\Users\School\Desktop\web\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserQuotes.cshtml"
                }

            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<YYRA_Team_Project.Pages.Users.UserQuotesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<YYRA_Team_Project.Pages.Users.UserQuotesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<YYRA_Team_Project.Pages.Users.UserQuotesModel>)PageContext?.ViewData;
        public YYRA_Team_Project.Pages.Users.UserQuotesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
