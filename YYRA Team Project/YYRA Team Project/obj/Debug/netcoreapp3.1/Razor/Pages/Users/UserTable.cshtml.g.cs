#pragma checksum "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be8a83aff3facdc0b885daf3ab76bc28ed3916dd"
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
#line 1 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\_ViewImports.cshtml"
using YYRA_Team_Project;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be8a83aff3facdc0b885daf3ab76bc28ed3916dd", @"/Pages/Users/UserTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a743d50c7adb968adb67360ac8352331cb7c5eba", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Users_UserTable : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary float-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("flex-wrap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1 style=\"color:red; font-family:\'Century Gothic\'\">Welcome ");
#nullable restore
#line 8 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
                                                       Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(".[Model.currentID].U_LName to Admin WebTool</h1>\n\n<div class=\"clearfix\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be8a83aff3facdc0b885daf3ab76bc28ed3916dd5274", async() => {
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
#line 11 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
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
            WriteLiteral("\n</div>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be8a83aff3facdc0b885daf3ab76bc28ed3916dd7671", async() => {
                WriteLiteral("\n    <table class=\"table table-hover\">\n        <thead class=\" bg-primary border shadow-sm\">\n            <tr>\n                <th scope=\"col\" style=\"color:white\">\n                    ");
#nullable restore
#line 18 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
               Write(Html.DisplayNameFor(model => model.Users[0].U_ID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th scope=\"col\" style=\"color:white\">\n                    ");
#nullable restore
#line 21 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
               Write(Html.DisplayNameFor(model => model.Users[0].U_Pass));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th scope=\"col\" style=\"color:white\">\n                    ");
#nullable restore
#line 24 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
               Write(Html.DisplayNameFor(model => model.Users[0].U_FullName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th scope=\"col\" style=\"color:white\">\n                    ");
#nullable restore
#line 27 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
               Write(Html.DisplayNameFor(model => model.Users[0].U_Address1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th scope=\"col\" style=\"color:white\">\n                    ");
#nullable restore
#line 30 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
               Write(Html.DisplayNameFor(model => model.Users[0].U_Address2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th scope=\"col\" style=\"color:white\">\n                    ");
#nullable restore
#line 33 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
               Write(Html.DisplayNameFor(model => model.Users[0].U_Zipcode));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th scope=\"col\" style=\"color:white\">\n                    ");
#nullable restore
#line 36 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
               Write(Html.DisplayNameFor(model => model.Users[0].U_City));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th scope=\"col\" style=\"color:white\">\n                    ");
#nullable restore
#line 39 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
               Write(Html.DisplayNameFor(model => model.Users[0].U_State));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th scope=\"col\" style=\"color:white\">\n                    ");
#nullable restore
#line 42 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
               Write(Html.DisplayNameFor(model => model.Users[0].U_Role));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th scope=\"col\"></th>\n            </tr>\n        </thead>\n        <tbody class=\"bg-info align-content-center flex-row border\">\n");
#nullable restore
#line 48 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
             foreach (var item in Model.Users)
            {
                if (!item.U_Role.Contains("Master"))
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr class=\"border-top\">\n                <td scope=\"row\">\n                    ");
#nullable restore
#line 54 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
               Write(Html.DisplayFor(modelItem => item.U_ID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 57 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
               Write(Html.DisplayFor(modelItem => item.U_Pass));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 60 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
               Write(Html.DisplayFor(modelItem => item.U_FullName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 63 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
               Write(Html.DisplayFor(modelItem => item.U_Address1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 66 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
               Write(Html.DisplayFor(modelItem => item.U_Address2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 69 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
               Write(Html.DisplayFor(modelItem => item.U_City));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 72 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
               Write(Html.DisplayFor(modelItem => item.U_State));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 75 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
               Write(Html.DisplayFor(modelItem => item.U_Zipcode));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 78 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
               Write(Html.DisplayFor(modelItem => item.U_Role));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n");
                WriteLiteral("            </tr>\n");
#nullable restore
#line 86 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserTable.cshtml"
                }

            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\n    </table>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
