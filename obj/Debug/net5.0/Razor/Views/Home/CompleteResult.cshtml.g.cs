#pragma checksum "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "238f64f4477082864962fe15154378eb37938e4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CompleteResult), @"mvc.1.0.view", @"/Views/Home/CompleteResult.cshtml")]
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
#line 1 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\_ViewImports.cshtml"
using SaloonHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\_ViewImports.cshtml"
using SaloonHelper.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"238f64f4477082864962fe15154378eb37938e4f", @"/Views/Home/CompleteResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6d55b082ce2d00051fbfc8f28733740df5ede6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CompleteResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SaloonHelper.ViewModel.ProductPriceCalculationViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
  
    ViewData["Title"] = "Resultado";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Resultado</h1>

<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Normal Price</th>
            <th scope=""col"">Increased Price</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th scope=""row"">");
#nullable restore
#line 19 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
                       Write(Html.DisplayNameFor(model => model.InitialPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
           Write(Html.DisplayFor(Model=>Model.InitialPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
           Write(Html.DisplayFor(Model=>Model.NewInitialPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th scope=\"row\">");
#nullable restore
#line 24 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
                       Write(Html.DisplayNameFor(model => model.DezPorCento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
           Write(Html.DisplayFor(model => model.DezPorCento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
           Write(Html.DisplayFor(model => model.NewDezPorCento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th scope=\"row\">");
#nullable restore
#line 29 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
                       Write(Html.DisplayNameFor(model => model.VintePorCento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
           Write(Html.DisplayFor(model => model.VintePorCento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
           Write(Html.DisplayFor(model => model.NewVintePorCento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th scope=\"row\">");
#nullable restore
#line 34 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
                       Write(Html.DisplayNameFor(model => model.TrintaPorCento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
           Write(Html.DisplayFor(model => model.TrintaPorCento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
           Write(Html.DisplayFor(model => model.NewTrintaPorCento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th scope=\"row\">");
#nullable restore
#line 39 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
                       Write(Html.DisplayNameFor(model => model.QuarentaPorCento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 40 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
           Write(Html.DisplayFor(model => model.QuarentaPorCento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 41 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
           Write(Html.DisplayFor(model => model.NewQuarentaPorCento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th scope=\"row\">");
#nullable restore
#line 44 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
                       Write(Html.DisplayNameFor(model => model.CinquentaPorCento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 45 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
           Write(Html.DisplayFor(model => model.CinquentaPorCento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 46 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
           Write(Html.DisplayFor(model => model.NewCinquentaPorCento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th scope=\"row\">");
#nullable restore
#line 49 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
                       Write(Html.DisplayNameFor(model => model.SessentaPorCento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 50 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
           Write(Html.DisplayFor(model => model.SessentaPorCento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 51 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
           Write(Html.DisplayFor(model => model.NewSessentaPorCento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th scope=\"row\">");
#nullable restore
#line 54 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
                       Write(Html.DisplayNameFor(model => model.SetentaPorCento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 55 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
           Write(Html.DisplayFor(model => model.SetentaPorCento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 56 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
           Write(Html.DisplayFor(model => model.NewSetentaPorCento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th scope=\"row\">");
#nullable restore
#line 59 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
                       Write(Html.DisplayNameFor(model => model.OitentaPorCento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 60 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
           Write(Html.DisplayFor(model => model.OitentaPorCento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 61 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
           Write(Html.DisplayFor(model => model.NewOitentaPorCento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th scope=\"row\">");
#nullable restore
#line 64 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
                       Write(Html.DisplayNameFor(model => model.NoventaPorCento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 65 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
           Write(Html.DisplayFor(model => model.NoventaPorCento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 66 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
           Write(Html.DisplayFor(model => model.NewNoventaPorCento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th scope=\"row\">");
#nullable restore
#line 69 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
                       Write(Html.DisplayNameFor(model => model.CemPorCento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 70 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
           Write(Html.DisplayFor(model => model.CemPorCento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 71 "C:\Users\Marreco\Desktop\Exercicios-js\SaloonHelper\Views\Home\CompleteResult.cshtml"
           Write(Html.DisplayFor(model => model.NewCemPorCento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SaloonHelper.ViewModel.ProductPriceCalculationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
