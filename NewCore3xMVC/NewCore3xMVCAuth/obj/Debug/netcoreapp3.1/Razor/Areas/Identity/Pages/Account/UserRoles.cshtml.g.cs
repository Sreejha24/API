#pragma checksum "D:\A-SNarayan\Sheo\Tutorials\DotNetCore2020\Apps\NewCore3xMVC\NewCore3xMVCAuth\Areas\Identity\Pages\Account\UserRoles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dbf5f969890d6c860a5a1a0461995aead914102"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_UserRoles), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/UserRoles.cshtml")]
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
#line 1 "D:\A-SNarayan\Sheo\Tutorials\DotNetCore2020\Apps\NewCore3xMVC\NewCore3xMVCAuth\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\A-SNarayan\Sheo\Tutorials\DotNetCore2020\Apps\NewCore3xMVC\NewCore3xMVCAuth\Areas\Identity\Pages\_ViewImports.cshtml"
using NewCore3xMVCAuth.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\A-SNarayan\Sheo\Tutorials\DotNetCore2020\Apps\NewCore3xMVC\NewCore3xMVCAuth\Areas\Identity\Pages\_ViewImports.cshtml"
using NewCore3xMVCAuth.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\A-SNarayan\Sheo\Tutorials\DotNetCore2020\Apps\NewCore3xMVC\NewCore3xMVCAuth\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using NewCore3xMVCAuth.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dbf5f969890d6c860a5a1a0461995aead914102", @"/Areas/Identity/Pages/Account/UserRoles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f89ee2b29f133439d0f8ff3cbf92c44734324dda", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36d9ac8467e2bf69d819885068618dc19d9d3893", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_UserRoles : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\A-SNarayan\Sheo\Tutorials\DotNetCore2020\Apps\NewCore3xMVC\NewCore3xMVCAuth\Areas\Identity\Pages\Account\UserRoles.cshtml"
  
    ViewData["Title"] = "Roles";
    var roles = (IList<string>)ViewData["Roles"];
    var thisUser = (IdentityUser)ViewData["ThisUser"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Roles  for <span class=\"text-success\">");
#nullable restore
#line 9 "D:\A-SNarayan\Sheo\Tutorials\DotNetCore2020\Apps\NewCore3xMVC\NewCore3xMVCAuth\Areas\Identity\Pages\Account\UserRoles.cshtml"
                                     Write(thisUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </h2>\r\n\r\n<table class=\"table table-striped\">\r\n    <tr>\r\n        <th>Role Name</th>\r\n    </tr>\r\n");
#nullable restore
#line 15 "D:\A-SNarayan\Sheo\Tutorials\DotNetCore2020\Apps\NewCore3xMVC\NewCore3xMVCAuth\Areas\Identity\Pages\Account\UserRoles.cshtml"
     foreach (var item in roles)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr><td>");
#nullable restore
#line 17 "D:\A-SNarayan\Sheo\Tutorials\DotNetCore2020\Apps\NewCore3xMVC\NewCore3xMVCAuth\Areas\Identity\Pages\Account\UserRoles.cshtml"
           Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n");
#nullable restore
#line 18 "D:\A-SNarayan\Sheo\Tutorials\DotNetCore2020\Apps\NewCore3xMVC\NewCore3xMVCAuth\Areas\Identity\Pages\Account\UserRoles.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewCore3xMVCAuth.Areas.Identity.Pages.Account.UserRolesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NewCore3xMVCAuth.Areas.Identity.Pages.Account.UserRolesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NewCore3xMVCAuth.Areas.Identity.Pages.Account.UserRolesModel>)PageContext?.ViewData;
        public NewCore3xMVCAuth.Areas.Identity.Pages.Account.UserRolesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591