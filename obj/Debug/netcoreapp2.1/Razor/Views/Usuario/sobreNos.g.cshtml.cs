#pragma checksum "C:\Users\51418943800\Desktop\Senai\Carfel-Completo\Views\Usuario\sobreNos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d6f0da1991e9d821423197f2c3f06af9a0b42b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_sobreNos), @"mvc.1.0.view", @"/Views/Usuario/sobreNos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/sobreNos.cshtml", typeof(AspNetCore.Views_Usuario_sobreNos))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d6f0da1991e9d821423197f2c3f06af9a0b42b8", @"/Views/Usuario/sobreNos.cshtml")]
    public class Views_Usuario_sobreNos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            EndContext();
            BeginContext(27, 377, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f1b09f023b846268e86e777adab120a", async() => {
                BeginContext(33, 364, true);
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>Sobre Nós</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" type=""text/css"" media=""screen"" href=""main.css"" />
    <link rel=""stylesheet"" href=""/css/sobreNos.css"">
    <script src=""main.js""></script>
");
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
            BeginContext(404, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(408, 2129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5570401cf0e14bd289038f25d52d0f77", async() => {
                BeginContext(414, 2116, true);
                WriteLiteral(@"
    <header>
        <img class=""banner"" src=""/imagens/banner.png"" width=""100%"" height=""auto"" alt=""banner"">
        <div class=""barra"">
            <ul class=""links"">
                <li>
                    <a href=""/Usuario/Index"">Home</a>
                </li>
                <li>
                    <a href=""/Usuario/Planos"">Planos</a>
                </li>
                <li>
                    <a href=""/Comentario/Suporte"">Suporte</a>
                </li>
                <li>
                    <a href=""/Usuario/Login"">Login/Cadastrar</a>
                </li>
            </ul>
        </div>
    </header>

    <main>
        <center>
            <div class=""titulo"">
                <h2>sobre nós</h2>
            </div>

            <div class=""subtitulo"">
                <h3>Como nos conhecemos</h3>
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit.
                    <br> Dignissimos nulla quia quibusdam, harum praesentium
                 ");
                WriteLiteral(@"   <br> perspiciatis hic nihil inventore. Iure labore odit vitae
                    <br> similique consectetur harum aspernatur optio, cum aliquam
                    <br> voluptates.
                </p>
                <img src=""/imagens/carfel.jpg"" width=""35%"" height=""35%"" alt=""imagem dos socios juntos"">
                <h3>Porque decidimos criar o Check Point</h3>
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit.
                    <br> Dignissimos nulla quia quibusdam, harum praesentium
                    <br> perspiciatis hic nihil inventore. Iure labore odit vitae
                    <br> similique consectetur harum aspernatur optio, cum aliquam
                    <br> voluptates.
                </p>
            </div>
        </center>
    </main>

    <footer>
        <div class=""barra-footer"">
            <ul>
                <li>Carfel@gmail.com</li>
                <li>Facebook/Carfel</li>
                <li>Instragram/Carfel</li>
             ");
                WriteLiteral("   <li>2953-1148/98826-1272</li>\r\n            </ul>\r\n    </footer>\r\n");
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
            BeginContext(2537, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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
