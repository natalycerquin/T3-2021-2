using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T3_2021_2.Interface;
using T3_2021_2.Models;

namespace T3_2021_2.servicio
{
    public class NotaServicio : NotaIn
    {
        readonly AppNotaContext mContext;

        public NotaServicio(AppNotaContext mContext)
        {
            this.mContext = mContext;
        }
       public List<Nota> getLisNotas()
       {
           return mContext.Notas.ToList();
       }

        public void CrearNota(string titulo, string contenido)
        {
            var nota = new Nota();
            nota.nombre = titulo;
            nota.descripcion = contenido;
            nota.fechaModicacion = DateTime.Now;

            mContext.Notas.Add(nota);
            mContext.SaveChanges();
        }

        public Nota EditarNota(int id)
        {
            return mContext.Notas.FirstOrDefault(o => o.Id == id);
        }

        public void EditarNota(string titulo, string contenido, int idNo)
        {
            var nota = mContext.Notas.FirstOrDefault(o => o.Id == idNo);
            nota.nombre = titulo;
            nota.descripcion = contenido;
            nota.fechaModicacion = DateTime.Now;
            mContext.SaveChanges();
        }

        public void BorrarNota(int id)
        {
            var nota = mContext.Notas.FirstOrDefault(o => o.Id == id);
            mContext.Remove(nota);
            mContext.SaveChanges();
        }
    }
}
