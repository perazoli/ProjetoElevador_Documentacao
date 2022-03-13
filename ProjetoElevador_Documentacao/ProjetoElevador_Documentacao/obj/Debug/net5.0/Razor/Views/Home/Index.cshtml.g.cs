#pragma checksum "C:\Users\peraz\source\repos\ProjetoElevador_Documentacao\ProjetoElevador_Documentacao\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76519723022b5e26136537d099452058dd402bdc"
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
#line 1 "C:\Users\peraz\source\repos\ProjetoElevador_Documentacao\ProjetoElevador_Documentacao\Views\_ViewImports.cshtml"
using ProjetoElevador_Documentacao;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\peraz\source\repos\ProjetoElevador_Documentacao\ProjetoElevador_Documentacao\Views\_ViewImports.cshtml"
using ProjetoElevador_Documentacao.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76519723022b5e26136537d099452058dd402bdc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4923143fe3bec400c1f93c72fde12f2bac68e920", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\peraz\source\repos\ProjetoElevador_Documentacao\ProjetoElevador_Documentacao\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Documentação Projeto Elevador</h1>
    <h2>Por: Matias Perazoli </h2>
</div>
<div>
    <h3>Inicializando o elevador</h3>
    <p>Quando iciniamos o aplicativo ele solicita a quantidade de andares e a capacidade máxima de pessoas no elevador.
    Importante: não há verificação de erro caso o número de andares e quantidade de pessoas não seja um valor inteiro válido, o aplicativo irá interromper a execução em erro.
    
    </p>
    
    <h4>Tela inicial - solicita a quantidade de andares do elevador</h4>
    <p>


    </p>
    <img src=/img/img1.jpg />
    <p>


    </p>
    <h4>Tela inicial - solicita a capacidade de pessoas do elevador</h4>
    <p>


    </p>
    <img src=/img/img3.jpg />

</div>
<div>
    <h3>Iniciando a operação do elevador</h3>
    <p>
        Depois de inicializado, o elevador apresenta o menu de opções e o andar em que ele está e a quantidade de pessoas no elevador. Sempre que iniciado, o elevador começ");
            WriteLiteral(@"a no térreo (andar 0) e vazio.



    </p>
    <img src=/img/img4.jpg />

    <h4>Opção 1 - Subir</h4>
    <p>Quando selecionada a Opção 1 - Subir de Andar, o sistema verifica se o elevador não está no último andar e se não estiver, sobre 1 andar.  </p>
    <p>Subindo de andar


    </p>
    <img src=/img/img5.jpg />
    <p> 
        Se o elevador já estiver no último andar, informa que já chegou no último andar e não sobe de andar
    </p>
    <img src=/img/img10.jpg />

    <h4>Opção 2 - Descer</h4>
    <p>
        Quando selecionada a Opção 2 - Descer, o sistema verifica se não está no térreo, se não estiver, desce 1 andar.
        Descendo de andar.
    </p>
    <img src=/img/img6.jpg />

    <p>Se o elevado já estiver no térreo, informa que já está no térreo e não desce mais</p>
    
    <img src=/img/img9.jpg />

    <h4> Opção 3 - Entrar </h4>
    <p>
        Adiciona um apessoa no elevador. O sistema verifica se o elevador não está lotado, se estiver, avisa para aguarda");
            WriteLiteral(@"r o próximo elevador.
        Se ainda houver espaço, aumenta a quantidade de pessoas em 1.
    </p>

    <img src=/img/img7.jpg />

    <p>Se o elevador estiver lotado, avisa e pede para aguardar o próximo</p>

    <img src=/img/img12.jpg />

    <h4> Opção 4 - Sair</h4>
    <p> Retira uma pessoa do elevador, se ele não estiver vazio</p>
    <p> Se o elevador não estiver vazio, diminui em 1 a quantidade de pessoas no elevaor</p>
    <img src=/img/img8.jpg />
    <p> Se estiver vazio, avisa que está vazio</p>
    <img src=/img/img11.jpg />

    <h4>Opção 5 - Encerrar</h4>
    <p>Encerra o aplicativo</p>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591