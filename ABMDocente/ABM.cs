using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace ABMDocente
{
    public class ABM : IModulo
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public object Menu { get; set; }
        public IList Acciones { get; set; }

        private List<Docente> docentes = new List<Docente>();
        public List<Docente> GetDocentes()
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

        public void BajaDocente(string ci)
        {
            Console.WriteLine("Cedula de Identidad a Baja de Docente > " + ci);

            try
            {
                // Filtro los docentes por la ci que recibo por parametro
                // Single es un metodo iterativo que recibe una funcion anonima por cada
                // elemento de la lista y retorna el elemento que cumpla con el filtro
                Docente docenteAEliminar = docentes.Single(docente => docente.Ci == ci);

                // Removemos el docenteAEliminar de la lista de docentes
                docentes.Remove(docenteAEliminar);
            }
            catch (Exception e)
            {
                Console.WriteLine("Excepcion al filtrar docente > " + e.ToString());
            }
        }

        public void ModificarDocente(string ci, Docente nuevosValores)
        {
            Console.WriteLine("Docente a modificar > " + ci);

            Docente docenteAModificar = docentes.Single(docente => docente.Ci == ci);
            int indiceDelDocenteAModificar = docentes.IndexOf(docenteAModificar);

            docentes[indiceDelDocenteAModificar].Nombre = nuevosValores.Nombre != "" ? nuevosValores.Nombre : docenteAModificar.Nombre;
            //docentes[indiceDelDocenteAModificar].Ci = nuevosValores.Ci != "" ? nuevosValores.Ci : docenteAModificar.Ci;

            //Docente docenteModificado = docentes.Single(docente => docente.Ci == ci);

            //Console.WriteLine("Nombre del docente modificado > " + docenteModificado.Nombre);
            //Console.WriteLine("Ci del docente modificado > " + docenteModificado.Ci);
        }
    }
}
