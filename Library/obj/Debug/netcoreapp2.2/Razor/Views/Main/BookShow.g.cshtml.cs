#pragma checksum "D:\TestExercise\Library\Views\Main\BookShow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "961ba3d5d721ebcf504e12cddfae137a67f69fdd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_BookShow), @"mvc.1.0.view", @"/Views/Main/BookShow.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Main/BookShow.cshtml", typeof(AspNetCore.Views_Main_BookShow))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"961ba3d5d721ebcf504e12cddfae137a67f69fdd", @"/Views/Main/BookShow.cshtml")]
    public class Views_Main_BookShow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "D:\TestExercise\Library\Views\Main\BookShow.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(134, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(161, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "961ba3d5d721ebcf504e12cddfae137a67f69fdd3107", async() => {
                BeginContext(167, 61, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(235, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(237, 1370, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "961ba3d5d721ebcf504e12cddfae137a67f69fdd4355", async() => {
                BeginContext(243, 327, true);
                WriteLiteral(@"
    <h3>All Books</h3>
    <table border=""1"">
        <tr>
            <td>
                Id
            </td>
            <td>
                Название книги
            </td>
            <td>
                Описание
            </td>
            <td>
                Цена
            </td>
        </tr>
");
                EndContext();
#line 32 "D:\TestExercise\Library\Views\Main\BookShow.cshtml"
          
            foreach (var book in Model.AllBooks)
            {

#line default
#line hidden
                BeginContext(647, 60, true);
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(708, 11, false);
#line 37 "D:\TestExercise\Library\Views\Main\BookShow.cshtml"
               Write(book.BookId);

#line default
#line hidden
                EndContext();
                BeginContext(719, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(787, 13, false);
#line 40 "D:\TestExercise\Library\Views\Main\BookShow.cshtml"
               Write(book.BookName);

#line default
#line hidden
                EndContext();
                BeginContext(800, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(868, 16, false);
#line 43 "D:\TestExercise\Library\Views\Main\BookShow.cshtml"
               Write(book.Description);

#line default
#line hidden
                EndContext();
                BeginContext(884, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(952, 10, false);
#line 46 "D:\TestExercise\Library\Views\Main\BookShow.cshtml"
               Write(book.Price);

#line default
#line hidden
                EndContext();
                BeginContext(962, 44, true);
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
                EndContext();
#line 49 "D:\TestExercise\Library\Views\Main\BookShow.cshtml"

            }

        

#line default
#line hidden
                BeginContext(1036, 81, true);
                WriteLiteral("    </table>\r\n\r\n    <button class=\"btn btn-info\" type=\"button\" id=\"addressSearch\"");
                EndContext();
                BeginWriteAttribute("onclick", "\r\n            onclick=\"", 1117, "\"", 1188, 3);
                WriteAttributeValue("", 1140, "location.href=\'", 1140, 15, true);
#line 56 "D:\TestExercise\Library\Views\Main\BookShow.cshtml"
WriteAttributeValue("", 1155, Url.Action("AddAuthor", "Info"), 1155, 32, false);

#line default
#line hidden
                WriteAttributeValue("", 1187, "\'", 1187, 1, true);
                EndWriteAttribute();
                BeginContext(1189, 110, true);
                WriteLiteral(">\r\n        Добавить автора\r\n    </button>\r\n\r\n    <button class=\"btn btn-info\" type=\"button\" id=\"addressSearch\"");
                EndContext();
                BeginWriteAttribute("onclick", "\r\n            onclick=\"", 1299, "\"", 1373, 3);
                WriteAttributeValue("", 1322, "location.href=\'", 1322, 15, true);
#line 61 "D:\TestExercise\Library\Views\Main\BookShow.cshtml"
WriteAttributeValue("", 1337, Url.Action("AddPublisher", "Info"), 1337, 35, false);

#line default
#line hidden
                WriteAttributeValue("", 1372, "\'", 1372, 1, true);
                EndWriteAttribute();
                BeginContext(1374, 112, true);
                WriteLiteral(">\r\n        Добавить издателя\r\n    </button>\r\n\r\n    <button class=\"btn btn-info\" type=\"button\" id=\"addressSearch\"");
                EndContext();
                BeginWriteAttribute("onclick", "\r\n            onclick=\"", 1486, "\"", 1555, 3);
                WriteAttributeValue("", 1509, "location.href=\'", 1509, 15, true);
#line 66 "D:\TestExercise\Library\Views\Main\BookShow.cshtml"
WriteAttributeValue("", 1524, Url.Action("AddBook", "Info"), 1524, 30, false);

#line default
#line hidden
                WriteAttributeValue("", 1554, "\'", 1554, 1, true);
                EndWriteAttribute();
                BeginContext(1556, 44, true);
                WriteLiteral(">\r\n        Добавить книгу\r\n    </button>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1607, 15, true);
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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
