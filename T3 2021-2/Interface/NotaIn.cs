using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T3_2021_2.Models;

namespace T3_2021_2.Interface
{
    public interface NotaIn
    {
        List<Nota> getLisNotas();
        void CrearNota(string titulo, string contenido);
        Nota EditarNota(int id);
        void EditarNota(string titulo, string contenido, int idNo);
        void BorrarNota(int id);
    }
}
