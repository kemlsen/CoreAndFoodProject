#pragma checksum "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Category\CategoryAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "168f33191741b8cbfb598ea81eb4dfef5abedebd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_CategoryAdd), @"mvc.1.0.view", @"/Views/Category/CategoryAdd.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"168f33191741b8cbfb598ea81eb4dfef5abedebd", @"/Views/Category/CategoryAdd.cshtml")]
    #nullable restore
    public class Views_Category_CategoryAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreAndFood.Data.Models.Category>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Category\CategoryAdd.cshtml"
  
    ViewData["Title"] = "CategoryAdd";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Category Add Page</h1>\r\n<br />\r\n");
#nullable restore
#line 9 "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Category\CategoryAdd.cshtml"
 using(Html.BeginForm("CategoryAdd","Category",FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Category\CategoryAdd.cshtml"
Write(Html.LabelFor(x=>x.CategoryName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Category\CategoryAdd.cshtml"
Write(Html.TextBoxFor(x=>x.CategoryName,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Category\CategoryAdd.cshtml"
Write(Html.ValidationMessageFor(x=>x.CategoryName,"",new{@style="color:red"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Category\CategoryAdd.cshtml"
                                                                            //"" parametresi texbozın altına yazı yazar.fakat biz oranın boş olmasını istiyoruz

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 15 "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Category\CategoryAdd.cshtml"
Write(Html.LabelFor(x=>x.CategoryDescription));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Category\CategoryAdd.cshtml"
Write(Html.TextBoxFor(x=>x.CategoryDescription,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\">Save</button>\r\n");
#nullable restore
#line 19 "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Category\CategoryAdd.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreAndFood.Data.Models.Category> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
