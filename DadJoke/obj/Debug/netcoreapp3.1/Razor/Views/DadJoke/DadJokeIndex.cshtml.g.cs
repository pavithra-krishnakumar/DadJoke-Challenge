#pragma checksum "C:\Users\PavithraKrishnakumar\source\repos\DadJoke\DadJoke\Views\DadJoke\DadJokeIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eff4420505240323ff2dffbf822fea2f77b3b9a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DadJoke_DadJokeIndex), @"mvc.1.0.view", @"/Views/DadJoke/DadJokeIndex.cshtml")]
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
#line 1 "C:\Users\PavithraKrishnakumar\source\repos\DadJoke\DadJoke\Views\_ViewImports.cshtml"
using DadJoke;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PavithraKrishnakumar\source\repos\DadJoke\DadJoke\Views\_ViewImports.cshtml"
using DadJoke.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eff4420505240323ff2dffbf822fea2f77b3b9a2", @"/Views/DadJoke/DadJokeIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e49b46b1446b4a6f245fa36195f8c063b460688", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_DadJoke_DadJokeIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DadJokeModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome to the world of Dad Jokes!</h1>\r\n    <br />\r\n    <div class=\"form\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eff4420505240323ff2dffbf822fea2f77b3b9a23768", async() => {
                WriteLiteral("\r\n           <button formaction=\"/DadJoke/GetRandomJoke\">\r\n               Random Joke\r\n           </button>\r\n       ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\PavithraKrishnakumar\source\repos\DadJoke\DadJoke\Views\DadJoke\DadJokeIndex.cshtml"
        if (Model != null)
       {
           

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\PavithraKrishnakumar\source\repos\DadJoke\DadJoke\Views\DadJoke\DadJokeIndex.cshtml"
            if (@Model.Joke?.Length > 0)
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <b>");
#nullable restore
#line 16 "C:\Users\PavithraKrishnakumar\source\repos\DadJoke\DadJoke\Views\DadJoke\DadJokeIndex.cshtml"
             Write(Model.Joke);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n");
#nullable restore
#line 17 "C:\Users\PavithraKrishnakumar\source\repos\DadJoke\DadJoke\Views\DadJoke\DadJokeIndex.cshtml"
           }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\PavithraKrishnakumar\source\repos\DadJoke\DadJoke\Views\DadJoke\DadJokeIndex.cshtml"
             
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("       <br/>\r\n       <br/>\r\n       ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eff4420505240323ff2dffbf822fea2f77b3b9a26528", async() => {
                WriteLiteral("\r\n           <div>\r\n               ");
#nullable restore
#line 23 "C:\Users\PavithraKrishnakumar\source\repos\DadJoke\DadJoke\Views\DadJoke\DadJokeIndex.cshtml"
          Write(Html.LabelFor(model => model.Term));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n               ");
#nullable restore
#line 24 "C:\Users\PavithraKrishnakumar\source\repos\DadJoke\DadJoke\Views\DadJoke\DadJokeIndex.cshtml"
          Write(Html.TextBoxFor(model => model.Term, new { htmlAttributes = new { @id = "termInput", @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n               ");
#nullable restore
#line 25 "C:\Users\PavithraKrishnakumar\source\repos\DadJoke\DadJoke\Views\DadJoke\DadJokeIndex.cshtml"
          Write(Html.ValidationMessageFor(m => m.Term, " ", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n           </div>\r\n           <br/>\r\n           <button formaction=\"/DadJoke/GetJokesBySearchTerm\" type=\"submit\">\r\n               Go!\r\n           </button>\r\n\r\n       ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 34 "C:\Users\PavithraKrishnakumar\source\repos\DadJoke\DadJoke\Views\DadJoke\DadJokeIndex.cshtml"
     if(@Model != null){

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\PavithraKrishnakumar\source\repos\DadJoke\DadJoke\Views\DadJoke\DadJokeIndex.cshtml"
         if (@Model.ShortJokeList != null && Model.ShortJokeList.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div><b>Short Jokes</b></div>\r\n");
#nullable restore
#line 39 "C:\Users\PavithraKrishnakumar\source\repos\DadJoke\DadJoke\Views\DadJoke\DadJokeIndex.cshtml"
            foreach (var i in @Model.ShortJokeList)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\PavithraKrishnakumar\source\repos\DadJoke\DadJoke\Views\DadJoke\DadJokeIndex.cshtml"
           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\r\n");
#nullable restore
#line 43 "C:\Users\PavithraKrishnakumar\source\repos\DadJoke\DadJoke\Views\DadJoke\DadJokeIndex.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\PavithraKrishnakumar\source\repos\DadJoke\DadJoke\Views\DadJoke\DadJokeIndex.cshtml"
         if (@Model.MediumJokeList != null && Model.MediumJokeList.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div><b>Medium Jokes</b></div>\r\n");
#nullable restore
#line 49 "C:\Users\PavithraKrishnakumar\source\repos\DadJoke\DadJoke\Views\DadJoke\DadJokeIndex.cshtml"
            foreach (var i in @Model.MediumJokeList)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\PavithraKrishnakumar\source\repos\DadJoke\DadJoke\Views\DadJoke\DadJokeIndex.cshtml"
           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\r\n");
#nullable restore
#line 53 "C:\Users\PavithraKrishnakumar\source\repos\DadJoke\DadJoke\Views\DadJoke\DadJokeIndex.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\PavithraKrishnakumar\source\repos\DadJoke\DadJoke\Views\DadJoke\DadJokeIndex.cshtml"
         if (@Model.LongJokeList != null && Model.LongJokeList.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div><b>Long Jokes</b></div>\r\n");
#nullable restore
#line 59 "C:\Users\PavithraKrishnakumar\source\repos\DadJoke\DadJoke\Views\DadJoke\DadJokeIndex.cshtml"
            foreach (var i in @Model.LongJokeList)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\PavithraKrishnakumar\source\repos\DadJoke\DadJoke\Views\DadJoke\DadJokeIndex.cshtml"
           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\r\n");
#nullable restore
#line 63 "C:\Users\PavithraKrishnakumar\source\repos\DadJoke\DadJoke\Views\DadJoke\DadJokeIndex.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\PavithraKrishnakumar\source\repos\DadJoke\DadJoke\Views\DadJoke\DadJokeIndex.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DadJokeModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
