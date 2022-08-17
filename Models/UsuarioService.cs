using System.Collections.Generic;
using System.Linq;
using System.Collections.Specialized;

namespace Biblioteca.Models
{
    public class UsuarioService
    {
        public List<Usuario> Listar()
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Usuarios.ToList();
            }
        }

        public Usuario Listar(int id)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Usuarios.Find(id);
            }
        }

        public void Inserir(Usuario usuario)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Usuarios.Add(usuario);
                bc.SaveChanges();
            }
        }

        public void Editar(Usuario usuario)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                Usuario usuarios = bc.Usuarios.Find(usuario.Id);

                usuarios.Nome = usuario.Nome;
                usuarios.Login = usuario.Login;
                if(usuarios.Senha != usuario.Senha)
                {
                    
                   usuarios.Senha = Criptografia.TextoCriptografado(usuarios.Senha);
                }
                else
                {
                    usuarios.Senha = usuario.Senha;
                }
                usuarios.Tipo = usuario.Tipo;

                bc.SaveChanges();
            }
        }

        public void Excluir(int id)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Usuarios.Remove(bc.Usuarios.Find(id));
                bc.SaveChanges();
            }
        }
    }
}