#pragma checksum "D:\TestExercise\Library\Views\Info\AddBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4396f6fd27358ac584432784b55aa02b5891799b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Info_AddBook), @"mvc.1.0.view", @"/Views/Info/AddBook.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Info/AddBook.cshtml", typeof(AspNetCore.Views_Info_AddBook))]
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
#line 1 "D:\TestExercise\Library\Views\_ViewImports.cshtml"
using Library.ViewModel;

#line default
#line hidden
#line 2 "D:\TestExercise\Library\Views\_ViewImports.cshtml"
using Library.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4396f6fd27358ac584432784b55aa02b5891799b", @"/Views/Info/AddBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5500259fbb98323bb0376c096ae961c9ea687c9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Info_AddBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(113, 19, true);
            WriteLiteral("<h3>Add Book</h3>\r\n");
            EndContext();
#line 7 "D:\TestExercise\Library\Views\Info\AddBook.cshtml"
 using (Html.BeginForm("SaveBook", "Saviour"))
{

#line default
#line hidden
            BeginContext(183, 147, true);
            WriteLiteral("    <input type=\"text\" name=\"_bookName\" />\r\n    <br />\r\n    <textarea name=\"_description\"></textarea>\r\n    <br />\r\n    <select name=\"_publisher\">\r\n");
            EndContext();
#line 14 "D:\TestExercise\Library\Views\Info\AddBook.cshtml"
          
            foreach (var company in Model.AllPublishers)
            {

#line default
#line hidden
            BeginContext(415, 46, true);
            WriteLiteral("                <option>\r\n                    ");
            EndContext();
            BeginContext(462, 21, false);
#line 18 "D:\TestExercise\Library\Views\Info\AddBook.cshtml"
               Write(company.PublisherName);

#line default
#line hidden
            EndContext();
            BeginContext(483, 29, true);
            WriteLiteral("\r\n                </option>\r\n");
            EndContext();
#line 20 "D:\TestExercise\Library\Views\Info\AddBook.cshtml"
            }

        

#line default
#line hidden
            BeginContext(540, 164, true);
            WriteLiteral("    </select>\r\n    <br />\r\n    <input type=\"text\" name=\"_price\" />\r\n    <br />\r\n    <input type=\"text\" name=\"_release\" />\r\n    <br />\r\n    <input type=\"submit\" />\r\n");
            EndContext();
#line 30 "D:\TestExercise\Library\Views\Info\AddBook.cshtml"
}

#line default
#line hidden
            BeginContext(707, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
