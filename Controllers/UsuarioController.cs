using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Cadastro()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Usuario u)
        {
            
            UsuarioService usuarioService = new UsuarioService();

            if(u.Id == 0)
            {
                usuarioService.Inserir(u);
            }
            else
            {
                usuarioService.Atualizar(u);
            }

            return RedirectToAction("Listagem");
        }

        public IActionResult Listagem(string tipoFiltro, string filtro)
        {
            Autenticacao.CheckLogin(this);
            FiltrosUsuarios objFiltro = null;
            if(!string.IsNullOrEmpty(filtro))
            {
                objFiltro = new FiltrosUsuarios();
                objFiltro.Filtro = filtro;
                objFiltro.TipoFiltro = tipoFiltro;
            }
            UsuarioService usuarioService = new UsuarioService();
            return View(usuarioService.ListarTodos(objFiltro));
        }

        public IActionResult Edicao(int id)
        {
            Autenticacao.CheckLogin(this);
            UsuarioService ls = new UsuarioService();
            Usuario u = ls.ObterPorId(id);
            return View(u);
        }

        public IActionResult Exclui(int id)
        {
            UsuarioService service = new UsuarioService();
            Usuario post = service.ObterPorId(id);

            return View(post);
        }

        [HttpPost]
        public IActionResult Exclui(int id, string decisao)
        {
            if(decisao == "s")
            {
            UsuarioService service = new UsuarioService();
            service.Apagar(id);
            }

            return RedirectToAction("Listagem");
        }
        }
}