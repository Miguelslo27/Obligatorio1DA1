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

        public Docente altaDatosDocente()
        {
            return new Docente();
        }
    }
}
