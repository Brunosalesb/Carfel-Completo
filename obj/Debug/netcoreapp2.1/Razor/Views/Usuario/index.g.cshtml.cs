#pragma checksum "C:\Users\51418943800\Desktop\Carfel-Completo\Carfel-Completo-master\Views\Usuario\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a96c582eb158f8ee257182fa2d620e4ea1fde803"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_index), @"mvc.1.0.view", @"/Views/Usuario/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/index.cshtml", typeof(AspNetCore.Views_Usuario_index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a96c582eb158f8ee257182fa2d620e4ea1fde803", @"/Views/Usuario/index.cshtml")]
    public class Views_Usuario_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 24, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n\n");
            EndContext();
            BeginContext(24, 371, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1583941711b423887676f50c439feb6", async() => {
                BeginContext(30, 358, true);
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>Página Inicial</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" type=""text/css"" media=""screen"" href=""main.css"" />
    <link rel=""stylesheet"" href=""/css/index.css"">
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
            BeginContext(395, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(397, 2244, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6d195af801e4747b8632fbcb5c6a4ef", async() => {
                BeginContext(403, 2231, true);
                WriteLiteral(@"
    <header>
        <img class=""banner"" src=""/imagens/banner.png"" width=""100%"" height=""800px"" alt=""banner"">
        <div class=""barra"">
            <ul class=""links"">
                <li>
                    <a href=""/Usuario/Planos"">Planos</a>
                </li>
                <li>
                    <a href=""/Usuario/SobreNos"">Sobre Nós</a>
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
            <form action=""/Usuario/Index"" method=POST>
            <h2>check point</h2>
            <img class=""tecno4"" src=""/imagens/tecno.jpg"" width=""30%"" height=""300px"" alt=""tecnologia"">

            <div class=""texto"">
                <h3>Funcionalidade</h3><br>
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit.
                   ");
                WriteLiteral(@" <br> Dignissimos nulla quia quibusdam, harum praesentium
                    <br> perspiciatis hic nihil inventore. Iure labore odit vitae
                    <br> similique consectetur harum aspernatur optio, cum aliquam
                    <br> voluptates.
                </p>
            </div>

            <img class=""tecno4"" src=""/imagens/tecno2.jpeg"" width=""30%"" height=""300px"" alt=""segunda tecnologia"">

            <div class=""texto2"">
                <h3>Objetivo</h3><br>
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
                    <li>Carfel@gmail.com<");
                WriteLiteral("/li>\n                    <li>Facebook/Carfel</li>\n                    <li>Instragram/Carfel</li>\n                    <li>2953-1148/98826-1272</li>\n                </ul>\n    </footer>\n");
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
            BeginContext(2641, 9, true);
            WriteLiteral("\n\n</html>");
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