#pragma checksum "C:\Users\Егор\source\repos\sluCHAYno\sluCHAYno\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be53fe2e27aac64ca21f7fccb1346259ceaa9eac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Егор\source\repos\sluCHAYno\sluCHAYno\Views\_ViewImports.cshtml"
using sluCHAYno;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Егор\source\repos\sluCHAYno\sluCHAYno\Views\_ViewImports.cshtml"
using sluCHAYno.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Егор\source\repos\sluCHAYno\sluCHAYno\Views\_ViewImports.cshtml"
using sluCHAYno.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be53fe2e27aac64ca21f7fccb1346259ceaa9eac", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbccea933e169e79001d969e12bf5b36222b5812", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sluCHAYno.ViewModels.HomeVm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Егор\source\repos\sluCHAYno\sluCHAYno\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Главная";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"header-content\">\r\n    <div class=\"row\">\r\n        <div class=\"col-12 col-xl-7\">\r\n            <img class=\"header-content-img img-fluid\" src=\"img/header/image 1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 257, "\"", 263, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        </div>
        <div class=""col-12 col-xl-5"">
            <h2>слуЧАЙно</h2>
            <div class=""text"">
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quis aperiam porro tenetur beatae asperiores eaque magnam numquam distinctio quidem itaque, eius facere, dolorem eum vitae, consequatur unde modi vel sequi.</p>
            </div>
        </div>
    </div>
</div>
<div class=""cafe-menu"" id=""cafe-menu"">
    <h2>Меню</h2>
    <div class=""row"">
        <div class=""col"">
            <h3>");
#nullable restore
#line 24 "C:\Users\Егор\source\repos\sluCHAYno\sluCHAYno\Views\Home\Index.cshtml"
           Write(Html.ActionLink(@Model.MenuCategories.FirstOrDefault(x => x.Id == 1).Name, "Index", "MenuCategory", new { id = 1 }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <ul>\r\n");
#nullable restore
#line 26 "C:\Users\Егор\source\repos\sluCHAYno\sluCHAYno\Views\Home\Index.cshtml"
                 foreach (var item in Model.MenuItems.Where(x => x.CategoryId == 1))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        ");
#nullable restore
#line 29 "C:\Users\Егор\source\repos\sluCHAYno\sluCHAYno\Views\Home\Index.cshtml"
                   Write(Html.ActionLink(item.Name, "Index", "MenuItem", new { id = item.Id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n");
#nullable restore
#line 31 "C:\Users\Егор\source\repos\sluCHAYno\sluCHAYno\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n        <div class=\"col\">\r\n            <h3>");
#nullable restore
#line 35 "C:\Users\Егор\source\repos\sluCHAYno\sluCHAYno\Views\Home\Index.cshtml"
           Write(Html.ActionLink(@Model.MenuCategories.FirstOrDefault(x => x.Id == 2).Name, "Index", "MenuCategory", new { id = 2 }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <ul>\r\n");
#nullable restore
#line 37 "C:\Users\Егор\source\repos\sluCHAYno\sluCHAYno\Views\Home\Index.cshtml"
                 foreach (var item in Model.MenuItems.Where(x => x.CategoryId == 2))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        ");
#nullable restore
#line 40 "C:\Users\Егор\source\repos\sluCHAYno\sluCHAYno\Views\Home\Index.cshtml"
                   Write(Html.ActionLink(item.Name, "Index", "MenuItem", new { id = item.Id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n");
#nullable restore
#line 42 "C:\Users\Егор\source\repos\sluCHAYno\sluCHAYno\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n        <div class=\"col\">\r\n            <h3>");
#nullable restore
#line 46 "C:\Users\Егор\source\repos\sluCHAYno\sluCHAYno\Views\Home\Index.cshtml"
           Write(Html.ActionLink(@Model.MenuCategories.FirstOrDefault(x => x.Id == 3).Name, "Index", "MenuCategory", new { id = 3 }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <ul>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 1982, "\"", 1989, 0);
            EndWriteAttribute();
            WriteLiteral(">Завтраки</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2032, "\"", 2039, 0);
            EndWriteAttribute();
            WriteLiteral(">Выпечка</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2081, "\"", 2088, 0);
            EndWriteAttribute();
            WriteLiteral(">Салаты</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 2129, "\"", 2136, 0);
            EndWriteAttribute();
            WriteLiteral(@">Десерты</a></li>
            </ul>
        </div>
    </div>
</div>
<div class=""about"" id=""about"">
    <h2>О нас</h2>
    <div class=""row"">
        <div class=""col-12 col-xl-5"">
            <div class=""text"">
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Praesentium in unde necessitatibus neque soluta dicta velit impedit corrupti repellendus, quibusdam eaque dignissimos. Doloremque odit ipsam minima earum, illo, quae non?</p>
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Praesentium in unde necessitatibus neque soluta dicta velit impedit corrupti repellendus, quibusdam eaque dignissimos. Doloremque odit ipsam minima earum, illo, quae non?</p>
            </div>
        </div>
        <div class=""col-12 col-xl-7"">
            <img class=""about-img img-fluid"" src=""img/image 2.png""");
            BeginWriteAttribute("alt", " alt=\"", 3004, "\"", 3010, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"contacts\" id=\"contacts\">\r\n    <h2>Контакты</h2>\r\n    <div class=\"row\">\r\n        <div class=\"mb-5 col-lg-6\">\r\n            <img class=\"contacts-img img-fluid\" src=\"img/image 3.png\"");
            BeginWriteAttribute("alt", " alt=\"", 3240, "\"", 3246, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <div class=\"col-lg-6\">\r\n            <ul>\r\n                <li>Адрес: г. Екатеринбург, ул. 8 марта, д. 64</li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3407, "\"", 3414, 0);
            EndWriteAttribute();
            WriteLiteral(">Телефон: +7 (922) 456 45-45</a></li>\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 3476, "\"", 3483, 0);
            EndWriteAttribute();
            WriteLiteral(">E-mail: sluchayno@yandex.ru</a></li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sluCHAYno.ViewModels.HomeVm> Html { get; private set; }
    }
}
#pragma warning restore 1591