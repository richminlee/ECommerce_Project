#pragma checksum "C:\Users\leeri\Desktop\Microsoft\ECommerce_Project\ECommerceProject\Pages\Admin\IdentityUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14a1dff9d54134ccb47802c9357a0db5a28cd5bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ECommerceProject.Pages.Admin.Pages_Admin_IdentityUsers), @"mvc.1.0.razor-page", @"/Pages/Admin/IdentityUsers.cshtml")]
namespace ECommerceProject.Pages.Admin
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
#line 1 "C:\Users\leeri\Desktop\Microsoft\ECommerce_Project\ECommerceProject\Pages\_ViewImports.cshtml"
using ECommerceProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\leeri\Desktop\Microsoft\ECommerce_Project\ECommerceProject\Pages\_ViewImports.cshtml"
using ECommerceProject.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\leeri\Desktop\Microsoft\ECommerce_Project\ECommerceProject\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\leeri\Desktop\Microsoft\ECommerce_Project\ECommerceProject\Pages\_ViewImports.cshtml"
using ECommerceProject.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\leeri\Desktop\Microsoft\ECommerce_Project\ECommerceProject\Pages\Admin\IdentityUsers.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\leeri\Desktop\Microsoft\ECommerce_Project\ECommerceProject\Pages\Admin\IdentityUsers.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14a1dff9d54134ccb47802c9357a0db5a28cd5bd", @"/Pages/Admin/IdentityUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1ec5c8950f08d395a8853e8c23642a087779f4f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_IdentityUsers : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3 class=\"bg-primary text-white text-center p-2\">Admin User</h3>\r\n<table class=\"table table-sm table-striped table-bordered\">\r\n    <tbody>\r\n        <tr><th>User</th><td>");
#nullable restore
#line 9 "C:\Users\leeri\Desktop\Microsoft\ECommerce_Project\ECommerceProject\Pages\Admin\IdentityUsers.cshtml"
                        Write(Model.AdminUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n        <tr><th>Email</th><td>");
#nullable restore
#line 10 "C:\Users\leeri\Desktop\Microsoft\ECommerce_Project\ECommerceProject\Pages\Admin\IdentityUsers.cshtml"
                         Write(Model.AdminUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n        <tr><th>Phone</th><td>");
#nullable restore
#line 11 "C:\Users\leeri\Desktop\Microsoft\ECommerce_Project\ECommerceProject\Pages\Admin\IdentityUsers.cshtml"
                         Write(Model.AdminUser.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\leeri\Desktop\Microsoft\ECommerce_Project\ECommerceProject\Pages\Admin\IdentityUsers.cshtml"
           
    [Authorize]
    public class IdentityUsersModel : PageModel
    {
        private UserManager<IdentityUser> userManager;
        public IdentityUsersModel(UserManager<IdentityUser> mgr)
        {
            userManager = mgr;
        }
        public IdentityUser AdminUser { get; set; }
        public async Task OnGetAsync()
        {
            AdminUser = await userManager.FindByNameAsync("Admin");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IdentityUsersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IdentityUsersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IdentityUsersModel>)PageContext?.ViewData;
        public IdentityUsersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
