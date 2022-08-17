using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Biblioteca.Models;
using System.Linq;
using System.Collections.Generic;

namespace Biblioteca.Controllers
{
    public class Autenticacao
    {
        public static void CheckLogin(Controller controller)
        {   
            if(string.IsNullOrEmpty(controller.HttpContext.Session.GetString("Login")))
            {
                controller.Request.HttpContext.Response.Redirect("/Home/Login");
            }
        }
     
    public static bool verificaLoginSenha(string login, string senha, Controller controller)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                verificaAdminExiste();

                senha = Criptografia.TextoCriptografado(senha);

                IQueryable<Usuario> UsuarioEncontrado = bc.Usuarios.Where(u => u.Login == login && u.Senha == senha);
                
                List<Usuario> ListaUsuarios = UsuarioEncontrado.ToList();

                if(ListaUsuarios.Count == 0)
                {
                    return false;
                }
                else
                {
                    controller.HttpContext.Session.SetString("Login", ListaUsuarios[0].Login);
                    controller.HttpContext.Session.SetInt32("Tipo", ListaUsuarios[0].Tipo);
                    return true;
                }
            }
        }

        public static void verificaUsuarioAdmin(Controller controller)
        {
            if(!(controller.HttpContext.Session.GetInt32("Tipo") == Usuario.ADMIN))
            {
                controller.Request.HttpContext.Response.Redirect("/Usuario/Permissao");
            }
        }
    
        public static void verificaAdminExiste()
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {

                IQueryable<Usuario> userAdmin = bc.Usuarios.Where(u => u.Login == "admin");

                if(userAdmin.ToList().Count == 0)
                {
                    Usuario novoAdm = new Usuario();
                    novoAdm.Nome = "Administrador";
                    novoAdm.Login = "admin";
                    novoAdm.Senha = Criptografia.TextoCriptografado("123");
                    novoAdm.Tipo = Usuario.ADMIN;

                    bc.Usuarios.Add(novoAdm);
                    bc.SaveChanges();
                }
            }
        }
    
    }
}