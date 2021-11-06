using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T3_2021_2.Interface;
using T3_2021_2.Models;

namespace T3_2021_2.Controllers
{
    public class NotaController : Controller
    {

        readonly NotaIn NotaIn;

        public NotaController(NotaIn NotaIn)
        {
            this.NotaIn = NotaIn;
        }
        public IActionResult Index()
        {
            var notas = NotaIn.getLisNotas();
            return View(notas);
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Crear(string titulo, string contenido)
        {
            NotaIn.CrearNota(titulo,contenido);

            return RedirectToAction("Index", "Nota");
        }
        [HttpGet]

        public IActionResult Editar(int id)
        {
            var nota = NotaIn.EditarNota(id);
            return View(nota);
        }

        [HttpPost] 

        public IActionResult Editar(string titulo, string contenido, int idNo)
        {
            NotaIn.EditarNota(titulo, contenido, idNo);

            return RedirectToAction("Index", "Nota");
        }
        public IActionResult Borrar(int id)
        {
            NotaIn.BorrarNota(id);

            return RedirectToAction("Index", "Nota");
        }
    }
}
