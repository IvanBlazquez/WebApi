#pragma checksum "F:\DAM-2\PROYECTOS\CHE\ProyectoDeChe\InterfazdeBeers\Pages\Beers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88d33d69ba7251682d30bcd93b3d6c0651cc5705"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(InterfazdeBeers.Pages.Pages_Beers), @"mvc.1.0.razor-page", @"/Pages/Beers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Beers.cshtml", typeof(InterfazdeBeers.Pages.Pages_Beers), null)]
namespace InterfazdeBeers.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "F:\DAM-2\PROYECTOS\CHE\ProyectoDeChe\InterfazdeBeers\Pages\_ViewImports.cshtml"
using InterfazdeBeers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88d33d69ba7251682d30bcd93b3d6c0651cc5705", @"/Pages/Beers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3affb766d8288a287e5773f398bbf3587bceeb0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Beers : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "F:\DAM-2\PROYECTOS\CHE\ProyectoDeChe\InterfazdeBeers\Pages\Beers.cshtml"
  
    ViewData["Title"] = "List Beers";

#line default
#line hidden
            BeginContext(72, 248, true);
            WriteLiteral("<script>\r\n    <link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css\" integrity=\"sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh\" crossorigin=\"anonymous\">\r\n</script>\r\n<h1>\r\n    ");
            EndContext();
            BeginContext(321, 17, false);
#line 10 "F:\DAM-2\PROYECTOS\CHE\ProyectoDeChe\InterfazdeBeers\Pages\Beers.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(338, 393, true);
            WriteLiteral(@"
</h1>
<div>
    <table class=""table table-dark"">
        <thead>
            <tr>
                <th scope=""col"">BeerID</th>
                <th scope=""col"">Marca</th>
                <th scope=""col"">Origen</th>
                <th scope=""col"">Tipo</th>
                <th scope=""col"">Grados</th>
                <th scope=""col"">Imagen</th>
            </tr>
        </thead>
");
            EndContext();
#line 24 "F:\DAM-2\PROYECTOS\CHE\ProyectoDeChe\InterfazdeBeers\Pages\Beers.cshtml"
         foreach (var Beer in Model.Beers)
        {

#line default
#line hidden
            BeginContext(786, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(847, 8, false);
#line 28 "F:\DAM-2\PROYECTOS\CHE\ProyectoDeChe\InterfazdeBeers\Pages\Beers.cshtml"
               Write(Beer._id);

#line default
#line hidden
            EndContext();
            BeginContext(855, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(923, 10, false);
#line 31 "F:\DAM-2\PROYECTOS\CHE\ProyectoDeChe\InterfazdeBeers\Pages\Beers.cshtml"
               Write(Beer.Marca);

#line default
#line hidden
            EndContext();
            BeginContext(933, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1001, 11, false);
#line 34 "F:\DAM-2\PROYECTOS\CHE\ProyectoDeChe\InterfazdeBeers\Pages\Beers.cshtml"
               Write(Beer.Origen);

#line default
#line hidden
            EndContext();
            BeginContext(1012, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1080, 9, false);
#line 37 "F:\DAM-2\PROYECTOS\CHE\ProyectoDeChe\InterfazdeBeers\Pages\Beers.cshtml"
               Write(Beer.Tipo);

#line default
#line hidden
            EndContext();
            BeginContext(1089, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1157, 11, false);
#line 40 "F:\DAM-2\PROYECTOS\CHE\ProyectoDeChe\InterfazdeBeers\Pages\Beers.cshtml"
               Write(Beer.Grados);

#line default
#line hidden
            EndContext();
            BeginContext(1168, 71, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1239, "\"", 1257, 1);
#line 43 "F:\DAM-2\PROYECTOS\CHE\ProyectoDeChe\InterfazdeBeers\Pages\Beers.cshtml"
WriteAttributeValue("", 1245, Beer.Imagen, 1245, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1258, 69, true);
            WriteLiteral(" width=\"80\" height=\"160\" />\r\n                </td>\r\n            </tr>");
            EndContext();
#line 45 "F:\DAM-2\PROYECTOS\CHE\ProyectoDeChe\InterfazdeBeers\Pages\Beers.cshtml"
                 ;
        }

#line default
#line hidden
            BeginContext(1341, 916, true);
            WriteLiteral(@"    </table>
    <div id=""AddBeers"">
        <h1>Add Beer</h1>
        <div class=""input-group"">
            <div class=""input-group-prepend"">
                <span class=""input-group-text"">Data</span>
            </div>
            <input type=""text"" id=""marca"" aria-label=""Marca"" placeholder=""Marca"" class=""form-control"">
            <input type=""text"" id=""origen"" aria-label=""Origen"" placeholder=""Origen"" class=""form-control"">
            <input type=""text"" id=""tipo"" aria-label=""Tipo"" placeholder=""Tipo"" class=""form-control"">
            <input type=""text"" id=""grados"" aria-label=""Grados"" placeholder=""Grados"" class=""form-control"">
            <input type=""text"" id=""imagen"" aria-label=""Imagen(URL)"" placeholder=""Imagen(URL)"" class=""form-control"">
        </div>
        <button type=""button"" class=""btn btn-primary btn-lg btn-block"" id=""AddBeer"" formmethod=""post"">Add</button>
    </div>
</div>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BeersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BeersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BeersModel>)PageContext?.ViewData;
        public BeersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
