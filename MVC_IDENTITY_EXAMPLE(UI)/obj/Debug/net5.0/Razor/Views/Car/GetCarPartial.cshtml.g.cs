#pragma checksum "C:\Users\User\Documents\GitHub\CarDealer\MVC_IDENTITY_EXAMPLE(UI)\Views\Car\GetCarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54b524381a7a1d341a4b13d1f799fe0c7d0772d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_GetCarPartial), @"mvc.1.0.view", @"/Views/Car/GetCarPartial.cshtml")]
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
#line 1 "C:\Users\User\Documents\GitHub\CarDealer\MVC_IDENTITY_EXAMPLE(UI)\Views\_ViewImports.cshtml"
using MVC_IDENTITY_EXAMPLE_UI_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\GitHub\CarDealer\MVC_IDENTITY_EXAMPLE(UI)\Views\_ViewImports.cshtml"
using MVC_IDENTITY_EXAMPLE_UI_.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54b524381a7a1d341a4b13d1f799fe0c7d0772d5", @"/Views/Car/GetCarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f726d92a39ec41ba24f02a4fd8c85e594946c693", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_GetCarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Domain.Model.Car>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Documents\GitHub\CarDealer\MVC_IDENTITY_EXAMPLE(UI)\Views\Car\GetCarPartial.cshtml"
 foreach (var car in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-3\">\r\n        <img src=\"asd\" ");
            WriteLiteral(" />\r\n        <h2>");
#nullable restore
#line 6 "C:\Users\User\Documents\GitHub\CarDealer\MVC_IDENTITY_EXAMPLE(UI)\Views\Car\GetCarPartial.cshtml"
       Write(car.CarBrend);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 6 "C:\Users\User\Documents\GitHub\CarDealer\MVC_IDENTITY_EXAMPLE(UI)\Views\Car\GetCarPartial.cshtml"
                     Write(car.ModelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <h3>Price: ");
#nullable restore
#line 7 "C:\Users\User\Documents\GitHub\CarDealer\MVC_IDENTITY_EXAMPLE(UI)\Views\Car\GetCarPartial.cshtml"
              Write(car.CarPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</h3>\r\n        <h4>Range: ");
#nullable restore
#line 8 "C:\Users\User\Documents\GitHub\CarDealer\MVC_IDENTITY_EXAMPLE(UI)\Views\Car\GetCarPartial.cshtml"
              Write(car.RunRange);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <p>Fuel: ");
#nullable restore
#line 9 "C:\Users\User\Documents\GitHub\CarDealer\MVC_IDENTITY_EXAMPLE(UI)\Views\Car\GetCarPartial.cshtml"
            Write(car.Engine.PetrolType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Emgine: ");
#nullable restore
#line 10 "C:\Users\User\Documents\GitHub\CarDealer\MVC_IDENTITY_EXAMPLE(UI)\Views\Car\GetCarPartial.cshtml"
              Write(car.Engine.Volume);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Gear Box: ");
#nullable restore
#line 11 "C:\Users\User\Documents\GitHub\CarDealer\MVC_IDENTITY_EXAMPLE(UI)\Views\Car\GetCarPartial.cshtml"
                Write(car.GearBoxType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Driverian: ");
#nullable restore
#line 12 "C:\Users\User\Documents\GitHub\CarDealer\MVC_IDENTITY_EXAMPLE(UI)\Views\Car\GetCarPartial.cshtml"
                 Write(car.DriverianType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n");
#nullable restore
#line 14 "C:\Users\User\Documents\GitHub\CarDealer\MVC_IDENTITY_EXAMPLE(UI)\Views\Car\GetCarPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Domain.Model.Car>> Html { get; private set; }
    }
}
#pragma warning restore 1591
