#pragma checksum "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserQuotes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10b2864d625ddb7d0c5cdd763e92fc3a9abb2d31"
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
#line 1 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\_ViewImports.cshtml"
using YYRA_Team_Project;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10b2864d625ddb7d0c5cdd763e92fc3a9abb2d31", @"/Pages/Users/UserQuotes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a743d50c7adb968adb67360ac8352331cb7c5eba", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Users_UserQuotes : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserQuotes.cshtml"
  
    ViewData["Title"] = "UserQuotes";
    ViewData["Username"] = Model._context.getUsername(Model._cache);
    ViewData["Role"] = Model._context.getRole(Model._cache);
    ViewData["Id"] = Model._context.getId(Model._cache);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>User Quotes</h3>\r\n\r\n    <table class=\"table table-striped\">\r\n        <thead  class=\"thead-dark\">\r\n            <tr>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 17 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserQuotes.cshtml"
               Write(Html.DisplayNameFor(model => model.Quote.UserID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 21 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserQuotes.cshtml"
               Write(Html.DisplayNameFor(model => model.Quote.Q_Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 24 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserQuotes.cshtml"
               Write(Html.DisplayNameFor(model => model.Quote.Q_Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 27 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserQuotes.cshtml"
               Write(Html.DisplayNameFor(model => model.Quote.Q_Gallons));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 30 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserQuotes.cshtml"
               Write(Html.DisplayNameFor(model => model.Quote.Q_Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 33 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserQuotes.cshtml"
               Write(Html.DisplayNameFor(model => Model.Quote.Q_Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n            </tr>\r\n        </thead>\r\n\r\n        <tbody>\r\n");
#nullable restore
#line 40 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserQuotes.cshtml"
             foreach (var quote in Model.Quotes)
            {

                if (quote.UserID == Model.CurrentID)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 48 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserQuotes.cshtml"
                       Write(Html.DisplayFor(modelItem => quote.UserID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 51 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserQuotes.cshtml"
                       Write(Html.DisplayFor(modelItem => quote.Q_Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 54 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserQuotes.cshtml"
                       Write(Html.DisplayFor(modelItem => quote.Q_Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 57 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserQuotes.cshtml"
                       Write(Html.DisplayFor(modelItem => quote.Q_Gallons));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 60 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserQuotes.cshtml"
                       Write(Html.DisplayFor(modelItem => quote.Q_Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 63 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserQuotes.cshtml"
                       Write(Html.DisplayFor(modelItem => quote.Q_Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 67 "C:\Users\qs\Documents\GitHub\PROJECT\YYRA Team Project\YYRA Team Project\Pages\Users\UserQuotes.cshtml"
                }

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
