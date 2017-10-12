using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace ABMDocente
{
    public class ABM: IModulo
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public object Menu { get; set; }
        public IList Acciones { get; set; }

        private List<Docente> docentes = new List<Docente>();
        public List<Docente> GetDocentes ()
        {
            return docentes;
        }

        public ABM()
        {
            Console.WriteLine("Constructor");
            Nombre = "Gestion Docente";
            Descripcion = "Alta, Baja y Modificación de Docentes";
        }

        public Docente AltaDatosDocente(string nombre, string ci, List<string> materias)
        {
            Docente d = new Docente();
            d.Nombre = nombre;
            d.Ci = ci;
            d.Materias = materias;
            docentes.Add(d);
            return d;
        }
    }
}
