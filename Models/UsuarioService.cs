using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace Biblioteca.Models
{
    public class UsuarioService
    {
        public void Inserir(Usuario u)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                u.Senha = Criptografia.GerarMD5(u.Senha);
                bc.Usuarios.Add(u);
                bc.SaveChanges();
            }
        }

        public void Atualizar(Usuario u)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                Usuario usuario = bc.Usuarios.Find(u.Id);
                usuario.Nome = u.Nome;
                usuario.Login = u.Login;
                usuario.Senha = u.Senha;
                usuario.Email = u.Email;
               
              

                bc.SaveChanges();
            }
        }

         public void Apagar(int u)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                Usuario usuario = bc.Usuarios.Find(u);
                bc.Usuarios.Remove(usuario);
                bc.SaveChanges();
            }
        }

        public ICollection<Usuario> ListarTodos(FiltrosUsuarios filtro = null)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                IQueryable<Usuario> query;
                
                if(filtro != null)
                {
                    //definindo dinamicamente a filtragem
                    switch(filtro.TipoFiltro)
                    {
                        case "Login":
                            query = bc.Usuarios.Where(u => u.Login.Contains(filtro.Filtro));
                        break;

                        case "Nome":
                            query = bc.Usuarios.Where(u => u.Nome.Contains(filtro.Filtro));
                        break;

                        default:
                            query = bc.Usuarios;
                        break;
                    }
                }
                else
                {
                    // caso filtro n??o tenha sido informado
                    query = bc.Usuarios;
                }
                
                //ordena????o padr??o
                return query.OrderBy(u => u.Nome).ToList();
            }
        }


        public Usuario ObterPorId(int id)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Usuarios.Find(id);
            }
        }
    }
}