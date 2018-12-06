using System;
using Carfel_Completo.Models;
using Carfel_Completo_master.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_Carfel_Web.Interfaces;
using Projeto_Carfel_Web.Models;
using Projeto_Carfel_Web.Repositorios;

namespace Projeto_Carfel_Web.Controllers {
    public class UsuarioController : Controller {
        
        #region pags [HttpGet]    
        [HttpGet]
        public IActionResult Index() => View();
        
        [HttpGet]
        public IActionResult Planos() => View();
        
        [HttpGet]
        public IActionResult SobreNos() => View();
        
        [HttpGet]
        public ActionResult Cadastro () => View();

        [HttpGet]
        public IActionResult Login() => View();

        #endregion
        public IUsuario UsuarioRepositorio { get; set; }

        public UsuarioController()
        {
            UsuarioRepositorio = new UsuarioRepositorioCSV();
        }
        
        [HttpPost]
        public ActionResult Cadastro (IFormCollection form) {
            UsuarioModel usuarioModel = new UsuarioModel (
                nome: form["nome"],
                email: form["email"],
                senha: form["senha"]
            );

            ViewBag.Mensagem = "Usuário Cadastrado";

            UsuarioRepositorio.Cadastrar(usuarioModel);
            return View ();
        }
        
        [HttpPost]
        public IActionResult Login(IFormCollection form){
            UsuarioModel usuario = new UsuarioModel(email: form["email"],senha: form["senha"]);

            UsuarioModel usuarioModel = UsuarioRepositorio.BuscarPorEmailESenha(usuario.Email, usuario.Senha);

            if (usuarioModel != null)
            {
                HttpContext.Session.SetString("nomeLogado", usuarioModel.Nome.ToString());
                HttpContext.Session.SetString("emailLogado", usuarioModel.Email.ToString());
                
                ViewBag.Mensagem = "Login realizado com sucesso";

                return RedirectToAction("Index","Usuario");
            }
            else
            {
                ViewBag.Mensagem = "Login não efetuado";
            }
            return View();
        }


    }
}