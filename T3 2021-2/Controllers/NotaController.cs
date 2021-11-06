using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T3_2021_2.Models;

namespace T3_2021_2.Controllers
{
    public class NotaController : Controller
    {

        private AppNotaContext mContext;



        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Crear(string titulo, string contenido)
        {
            Nota nota = new Nota();
            nota.nombre = titulo;
            nota.descripcion = contenido;
            nota.fechaModicacion = DateTime.Now;

            mContext.Notas.Add(nota);
            mContext.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
        [HttpGet]

        public IActionResult Editar(int id)
        { 
            ViewBag.NotaComoTal = mContext.Notas.Where(o => o.Id == id).FirstOrDefault();
            return View();
        }

        [HttpPost]

        public IActionResult Editar(string titulo, string contenido, int idNo)
        {
            Nota nota = mContext.Notas.Where(o => o.Id == idNo).FirstOrDefault();
            nota.nombre = titulo;
            nota.descripcion = contenido;
            nota.fechaModicacion = DateTime.Now;

           // _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
        public IActionResult Borrar(int id)
        {
            //var nota = _context.Notas.Where(o => o.idNota == id).FirstOrDefault();

           // _context.Remove(nota);
            //_context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}
