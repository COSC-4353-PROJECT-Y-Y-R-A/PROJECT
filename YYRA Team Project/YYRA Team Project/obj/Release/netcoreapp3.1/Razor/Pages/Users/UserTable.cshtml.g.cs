#pragma checksum "C:\Users\gamer\Source\Repos\COSC-4353-PROJECT-Y-Y-R-A\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7431422a5b4ae38e70ac5d2ff16d14678f0d1274"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(YYRA_Team_Project.Pages.Users.Pages_Users_UserTable), @"mvc.1.0.razor-page", @"/Pages/Users/UserTable.cshtml")]
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
#line 1 "C:\Users\gamer\Source\Repos\COSC-4353-PROJECT-Y-Y-R-A\PROJECT\YYRA Team Project\YYRA Team Project\Pages\_ViewImports.cshtml"
using YYRA_Team_Project;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7431422a5b4ae38e70ac5d2ff16d14678f0d1274", @"/Pages/Users/UserTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f4e1e3b15a3e7f45a41a8ed75100a3b1fe2f3f3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Users_UserTable : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary float-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\gamer\Source\Repos\COSC-4353-PROJECT-Y-Y-R-A\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
  
    ViewData["Title"] = "Index";
    ViewData["Username"] = Model._context.getUsername(Model._cache);
    ViewData["Role"] = Model._context.getRole(Model._cache);
    ViewData["Id"] = Model._context.getId(Model._cache);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3> Welcome ");
#nullable restore
#line 11 "C:\Users\gamer\Source\Repos\COSC-4353-PROJECT-Y-Y-R-A\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
        Write(Model.Users[Model.currentID].U_Username);

#line default
#line hidden
#nullable disable
            WriteLiteral(" to Admin WebTool</h3>\r\n\r\n<div class=\"clearfix\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7431422a5b4ae38e70ac5d2ff16d14678f0d12744998", async() => {
                WriteLiteral("Create New User");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\Users\gamer\Source\Repos\COSC-4353-PROJECT-Y-Y-R-A\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
                                                                              WriteLiteral(Model.currentID);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n</div>\r\n\r\n\r\n    <table class=\"table table-striped\">\r\n        <thead class=\"thead-dark\">\r\n            <tr>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 22 "C:\Users\gamer\Source\Repos\COSC-4353-PROJECT-Y-Y-R-A\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
               Write(Html.DisplayNameFor(model => model.Users[0].U_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 25 "C:\Users\gamer\Source\Repos\COSC-4353-PROJECT-Y-Y-R-A\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
               Write(Html.DisplayNameFor(model => model.Users[0].U_Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 28 "C:\Users\gamer\Source\Repos\COSC-4353-PROJECT-Y-Y-R-A\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
               Write(Html.DisplayNameFor(model => model.Users[0].U_Pass));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 31 "C:\Users\gamer\Source\Repos\COSC-4353-PROJECT-Y-Y-R-A\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
               Write(Html.DisplayNameFor(model => model.Users[0].U_FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 34 "C:\Users\gamer\Source\Repos\COSC-4353-PROJECT-Y-Y-R-A\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
               Write(Html.DisplayNameFor(model => model.Users[0].U_Address1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 37 "C:\Users\gamer\Source\Repos\COSC-4353-PROJECT-Y-Y-R-A\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
               Write(Html.DisplayNameFor(model => model.Users[0].U_Address2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 40 "C:\Users\gamer\Source\Repos\COSC-4353-PROJECT-Y-Y-R-A\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
               Write(Html.DisplayNameFor(model => model.Users[0].U_City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 43 "C:\Users\gamer\Source\Repos\COSC-4353-PROJECT-Y-Y-R-A\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
               Write(Html.DisplayNameFor(model => model.Users[0].U_State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 46 "C:\Users\gamer\Source\Repos\COSC-4353-PROJECT-Y-Y-R-A\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
               Write(Html.DisplayNameFor(model => model.Users[0].U_Zipcode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 49 "C:\Users\gamer\Source\Repos\COSC-4353-PROJECT-Y-Y-R-A\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
               Write(Html.DisplayNameFor(model => model.Users[0].U_Role));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n            </tr>\r\n        </thead>\r\n\r\n        <tbody>\r\n");
#nullable restore
#line 56 "C:\Users\gamer\Source\Repos\COSC-4353-PROJECT-Y-Y-R-A\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
             foreach (var item in Model.Users)
            {
                if (!item.U_Role.Contains("Master"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 62 "C:\Users\gamer\Source\Repos\COSC-4353-PROJECT-Y-Y-R-A\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
                   Write(Html.DisplayFor(modelItem => item.U_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 65 "C:\Users\gamer\Source\Repos\COSC-4353-PROJECT-Y-Y-R-A\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
                   Write(Html.DisplayFor(modelItem => item.U_Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 68 "C:\Users\gamer\Source\Repos\COSC-4353-PROJECT-Y-Y-R-A\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
                   Write(Html.DisplayFor(modelItem => item.U_Pass));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 71 "C:\Users\gamer\Source\Repos\COSC-4353-PROJECT-Y-Y-R-A\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
                   Write(Html.DisplayFor(modelItem => item.U_FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 74 "C:\Users\gamer\Source\Repos\COSC-4353-PROJECT-Y-Y-R-A\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
                   Write(Html.DisplayFor(modelItem => item.U_Address1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 77 "C:\Users\gamer\Source\Repos\COSC-4353-PROJECT-Y-Y-R-A\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
                   Write(Html.DisplayFor(modelItem => item.U_Address2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 80 "C:\Users\gamer\Source\Repos\COSC-4353-PROJECT-Y-Y-R-A\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
                   Write(Html.DisplayFor(modelItem => item.U_City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 83 "C:\Users\gamer\Source\Repos\COSC-4353-PROJECT-Y-Y-R-A\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
                   Write(Html.DisplayFor(modelItem => item.U_State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 86 "C:\Users\gamer\Source\Repos\COSC-4353-PROJECT-Y-Y-R-A\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
                   Write(Html.DisplayFor(modelItem => item.U_Zipcode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 89 "C:\Users\gamer\Source\Repos\COSC-4353-PROJECT-Y-Y-R-A\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
                   Write(Html.DisplayFor(modelItem => item.U_Role));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 92 "C:\Users\gamer\Source\Repos\COSC-4353-PROJECT-Y-Y-R-A\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"

                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n   </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserTableModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UserTableModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UserTableModel>)PageContext?.ViewData;
        public UserTableModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
