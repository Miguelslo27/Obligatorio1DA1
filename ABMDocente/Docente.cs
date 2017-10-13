using System.Collections.Generic;
using Interfaces;

namespace ABMDocente
{
    public class Docente: IPersona
    {
        public string Nombre { get; set; }
        public string Ci { get; set; }
        public List<string> Materias { get; set; }

        public override string ToString()
        {
            return "Nombre: " + Nombre;
        }
    }
}