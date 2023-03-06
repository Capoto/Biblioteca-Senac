using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Biblioteca.Models;
using Microsoft.AspNetCore.Http;

namespace Biblioteca.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Autenticacao.CheckLogin(this);
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuario u)
        {
            
            IQueryable<Usuario> query;

            using(BibliotecaContext bc = new BibliotecaContext())
            {
             
              

            query = bc.Usuarios.Where(p => (p.Login == u.Login) && (p.Senha == Criptografia.GerarMD5(u.Senha)));  
            string k = u.Senha;
            List<Usuario> usuario = query.ToList();

            foreach(var t in usuario){
                    Console.WriteLine(Criptografia.GerarMD5(u.Senha));
           
                HttpContext.Session.SetString("user", u.Login);
                return RedirectToAction("Index");
            }
            if(u.Login == "admin" && k == "123")
            {
                HttpContext.Session.SetString("user", "admin");
                return RedirectToAction("Index");
            }
            else
            {
                ViewData["Erro"] = "Senha inválida";
                return View();
            }
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
