#pragma checksum "C:\Users\School\Desktop\web\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\FuelQuoteForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "620f8faf6afe5d2364f839f7a332ddd420863d76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(YYRA_Team_Project.Pages.Users.Pages_Users_FuelQuoteForm), @"mvc.1.0.razor-page", @"/Pages/Users/FuelQuoteForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"620f8faf6afe5d2364f839f7a332ddd420863d76", @"/Pages/Users/FuelQuoteForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f4e1e3b15a3e7f45a41a8ed75100a3b1fe2f3f3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Users_FuelQuoteForm : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\School\Desktop\web\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\FuelQuoteForm.cshtml"
  
    ViewData["Username"] = Model._context.getUsername(Model._cache);
    ViewData["Role"] = Model._context.getRole(Model._cache);
    ViewData["Id"] = Model._context.getId(Model._cache);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card-deck\">\r\n    <div class=\"card-header\" style=\"color:red;Background:white;border-style:inherit;animation:ease-in-out\">\r\n        <h1>Fuel Quote Form</h1>\r\n    </div>\r\n    <div class=\"w-25\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "620f8faf6afe5d2364f839f7a332ddd420863d764052", async() => {
                WriteLiteral("\r\n            <div>\r\n                <label>Gallons:</label>\r\n                <input type=\"text\" />\r\n                <p");
                BeginWriteAttribute("asp-validation-for", " asp-validation-for=\"", 614, "\"", 657, 1);
#nullable restore
#line 18 "C:\Users\School\Desktop\web\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\FuelQuoteForm.cshtml"
WriteAttributeValue("", 635, Model.QUOTE.Q_Address, 635, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Delivery address:</p>\r\n            \r\n                <brasp-validation-for =\"");
#nullable restore
#line 20 "C:\Users\School\Desktop\web\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\FuelQuoteForm.cshtml"
                                   Write(Model.QUOTE.Q_Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n                    Delivery date:\r\n                    <input type=\"date\" />\r\n                    <br");
                BeginWriteAttribute("asp-validation-for", " asp-validation-for=\"", 861, "\"", 902, 1);
#nullable restore
#line 23 "C:\Users\School\Desktop\web\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\FuelQuoteForm.cshtml"
WriteAttributeValue("", 882, Model.QUOTE.Q_Price, 882, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Suggested price:\r\n                    <br");
                BeginWriteAttribute("asp-validation-for", " asp-validation-for=\"", 945, "\"", 986, 1);
#nullable restore
#line 24 "C:\Users\School\Desktop\web\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\FuelQuoteForm.cshtml"
WriteAttributeValue("", 966, Model.QUOTE.Q_Total, 966, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Total amount due:\r\n\r\n\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Submit Form\" class=\"btn btn-primary\" />\r\n            </div>\r\n\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<YYRA_Team_Project.Pages.Users.FuelQuoteFormModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<YYRA_Team_Project.Pages.Users.FuelQuoteFormModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<YYRA_Team_Project.Pages.Users.FuelQuoteFormModel>)PageContext?.ViewData;
        public YYRA_Team_Project.Pages.Users.FuelQuoteFormModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
