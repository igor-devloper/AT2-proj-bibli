#pragma checksum "C:\Users\igor2\igor\atividades do curso\Biblioteca - Teste\Biblioteca\Views\Usuario\ListaUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66ffc857810cbde2423b87cd814173b02a904692"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_ListaUsuarios), @"mvc.1.0.view", @"/Views/Usuario/ListaUsuarios.cshtml")]
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
#line 1 "C:\Users\igor2\igor\atividades do curso\Biblioteca - Teste\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\igor2\igor\atividades do curso\Biblioteca - Teste\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66ffc857810cbde2423b87cd814173b02a904692", @"/Views/Usuario/ListaUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_ListaUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Usuários cadastrados no sistema</h1>\r\n\r\n<p class=\"text-danger\">");
#nullable restore
#line 5 "C:\Users\igor2\igor\atividades do curso\Biblioteca - Teste\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
                  Write(ViewData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"row\">Nome</th>\r\n            <th scope=\"row\">Login</th>\r\n            <th scope=\"row\">Tipo</th>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n");
#nullable restore
#line 16 "C:\Users\igor2\igor\atividades do curso\Biblioteca - Teste\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
         foreach (Usuario u in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\igor2\igor\atividades do curso\Biblioteca - Teste\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
               Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\igor2\igor\atividades do curso\Biblioteca - Teste\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
               Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 22 "C:\Users\igor2\igor\atividades do curso\Biblioteca - Teste\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
                 if (u.Tipo == Usuario.ADMIN)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Administrador</td>\r\n");
#nullable restore
#line 25 "C:\Users\igor2\igor\atividades do curso\Biblioteca - Teste\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
                }

                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Padrão</td>\r\n");
#nullable restore
#line 30 "C:\Users\igor2\igor\atividades do curso\Biblioteca - Teste\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 721, "\"", 750, 2);
            WriteAttributeValue("", 728, "EditarUsuario?id=", 728, 17, true);
#nullable restore
#line 32 "C:\Users\igor2\igor\atividades do curso\Biblioteca - Teste\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
WriteAttributeValue("", 745, u.Id, 745, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">editar</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 791, "\"", 821, 2);
            WriteAttributeValue("", 798, "ExcluirUsuario?id=", 798, 18, true);
#nullable restore
#line 33 "C:\Users\igor2\igor\atividades do curso\Biblioteca - Teste\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
WriteAttributeValue("", 816, u.Id, 816, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">excluir</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 35 "C:\Users\igor2\igor\atividades do curso\Biblioteca - Teste\Biblioteca\Views\Usuario\ListaUsuarios.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<a href=\"/Usuario/CadastrarUsuario\">Registrar novo usuário</a");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
