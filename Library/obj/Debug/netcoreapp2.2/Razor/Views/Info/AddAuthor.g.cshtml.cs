#pragma checksum "D:\TestExercise\Library\Views\Info\AddAuthor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4df3b45d093ad41c4dc63e9bbb2c87343ab82a74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Info_AddAuthor), @"mvc.1.0.view", @"/Views/Info/AddAuthor.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Info/AddAuthor.cshtml", typeof(AspNetCore.Views_Info_AddAuthor))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4df3b45d093ad41c4dc63e9bbb2c87343ab82a74", @"/Views/Info/AddAuthor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e5b872f2031568e870ac0d66ca28b7c67c7349b", @"/Views/_ViewImports.cshtml")]
    public class Views_Info_AddAuthor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 26, true);
            WriteLiteral("\n    <h3>Add Author</h3>\n\n");
            EndContext();
#line 4 "D:\TestExercise\Library\Views\Info\AddAuthor.cshtml"
     using (Html.BeginForm("SaveAuthor", "Saviour"))
    {

#line default
#line hidden
            BeginContext(85, 101, true);
            WriteLiteral("        <input type=\"text\" name = \"_authorName\"/>\n        <input type=\"submit\" class=\"submit_btn\" />\n");
            EndContext();
#line 8 "D:\TestExercise\Library\Views\Info\AddAuthor.cshtml"
    }

#line default
#line hidden
            BeginContext(192, 3, true);
            WriteLiteral("\n\n\n");
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
