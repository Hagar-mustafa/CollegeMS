#pragma checksum "E:\iti3months\MVC\final\College Management System\College Management System\CollegeMS\CollegeMS\Views\Department\ShowAllDepartment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "988b5d58a99b35e7c36acc87b6650697bf42ba6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_ShowAllDepartment), @"mvc.1.0.view", @"/Views/Department/ShowAllDepartment.cshtml")]
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
#line 1 "E:\iti3months\MVC\final\College Management System\College Management System\CollegeMS\CollegeMS\Views\_ViewImports.cshtml"
using CollegeMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\iti3months\MVC\final\College Management System\College Management System\CollegeMS\CollegeMS\Views\_ViewImports.cshtml"
using CollegeMS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\iti3months\MVC\final\College Management System\College Management System\CollegeMS\CollegeMS\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"988b5d58a99b35e7c36acc87b6650697bf42ba6f", @"/Views/Department/ShowAllDepartment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1006be527b5afc8e23b8aad3d69d1387fd65271e", @"/Views/_ViewImports.cshtml")]
    public class Views_Department_ShowAllDepartment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Department>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h3>Departments</h3>\r\n<table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">Name</th>\r\n            <th scope=\"col\">Details</th>\r\n        </tr>\r\n    </thead>\r\n");
#nullable restore
#line 12 "E:\iti3months\MVC\final\College Management System\College Management System\CollegeMS\CollegeMS\Views\Department\ShowAllDepartment.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 15 "E:\iti3months\MVC\final\College Management System\College Management System\CollegeMS\CollegeMS\Views\Department\ShowAllDepartment.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> <a");
            BeginWriteAttribute("onclick", " onclick=\"", 330, "\"", 358, 3);
            WriteAttributeValue("", 340, "AjaxCall(", 340, 9, true);
#nullable restore
#line 16 "E:\iti3months\MVC\final\College Management System\College Management System\CollegeMS\CollegeMS\Views\Department\ShowAllDepartment.cshtml"
WriteAttributeValue("", 349, item.Id, 349, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 357, ")", 357, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Show Student in Dept</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 18 "E:\iti3months\MVC\final\College Management System\College Management System\CollegeMS\CollegeMS\Views\Department\ShowAllDepartment.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</table>

<div style=""background-color:lightblue"" id=""div1"">
</div>

<script>
    function AjaxCall(id){
        $.ajax(
            {
                url  : ""/Department/GetStudentByID"",
                data :{""DepId"":id},
                success: function(result){
                            $(""#div1"").html(result);
                    }
            }
            );
         }
</script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Department>> Html { get; private set; }
    }
}
#pragma warning restore 1591