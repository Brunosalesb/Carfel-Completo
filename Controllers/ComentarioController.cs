using System;
using System.Collections.Generic;
using Carfel_Completo.Models;
using Carfel_Completo_master.Interfaces;
using Carfel_Completo_master.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Carfel_Completo.Controllers {
    public class ComentarioController : Controller {
        
        public IComentario ComentarioRepositorio { get; set;}
        public ComentarioController()
        {
            ComentarioRepositorio = new ComentarioRepositorioCSV();
        }

        [HttpGet]
        public IActionResult Suporte(){
            List<ComentarioModel> lsComentarios = ComentarioRepositorio.ListarCSV(HttpContext.Session.GetString ("nomeLogado"));
            ViewBag.lista = lsComentarios;
            return View();
        }
        
        [HttpPost]
        public IActionResult Suporte (IFormCollection form) {
            ComentarioModel comentarioModel = new ComentarioModel (
                nomeComentario: HttpContext.Session.GetString ("nomeLogado"),
                textoComentario: form["textoComentario"],
                dataComentario: DateTime.Now,
                comentarioAprovado: false
            );

            ViewBag.Mensagem = "Comentario Enviado";

            ComentarioRepositorio.CadastrarComentario (comentarioModel);

            List<ComentarioModel> lsComentarios = ComentarioRepositorio.ListarCSV(HttpContext.Session.GetString ("nomeLogado"));

            ViewBag.lista = lsComentarios;
            return View ();
        }

        [HttpGet]
        public IActionResult Aprovar(int id)
        {
            ComentarioRepositorioCSV comentario = new ComentarioRepositorioCSV();
            comentario.Aprovar(id);
            TempData["Mensagem"] = "Comentario rejeitado";
            return RedirectToAction("Suporte","Comentario");
        }

        [HttpGet]
        public IActionResult Rejeitar(int id){
            ComentarioRepositorio.Rejeitar(id);

            ViewBag.Mensagem = "Comentario Rejeitado";

            return RedirectToAction("Suporte","Comentario");
        }
    }
}