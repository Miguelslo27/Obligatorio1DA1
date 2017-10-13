using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ABMDocente;
using Interfaces;
using System.Collections.Generic;

namespace Obligatorio1DA1UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        public ABM abmDocente { get; set; }
        public List<Docente> docentes { get; set; }
        public List<Docente> misDocentes { get; set; }

        public UnitTest1()
        {
            generarDatos();
        }

        [TestMethod]
        public void TestTipoModuloABMDocente()
        {
            // Creamos el ambDocente para gestionar los docentes
            // abmDocente = new ABMDocente.ABM();
            
            // Test si el abm implementa la interfaz IModulo
            Assert.IsInstanceOfType(abmDocente, typeof(IModulo));

            // Test si abm tiene nombre y descripción
            Assert.AreEqual("Gestion Docente", abmDocente.Nombre);
            Assert.AreEqual("Alta, Baja y Modificación de Docentes", abmDocente.Descripcion);
        }

        [TestMethod]
        public void TestAltaDocente()
        {
            // Creamos el abmDocente para gestionar docentes
            // ABM abmDocente = new ABMDocente.ABM();

            // Creamos una lista de materias *por ahora strings
            List<string> materias = new List<string>();
            materias.Add("Aritmetica");
            materias.Add("Sistemas informaticos");

            // Creamos un docente utilizando el abmDocente.AltaDatosDocente
            Docente docente = abmDocente.AltaDatosDocente("Nombre del Docente", "1234", materias);

            // Validamos si el docente creado es del tipo Docente
            Assert.IsInstanceOfType(docente, typeof(Docente));

            // Validamos si el docente tiene un atributo nombre de tipo string
            // y si el nombre es igual al nombre asignado en AltaDatosDocente
            Assert.IsInstanceOfType(docente.Nombre, typeof(string));
            Assert.AreNotEqual("Nombre cualquiera", docente.Nombre);
            Assert.AreEqual("Nombre del Docente", docente.Nombre);

            // Validamos si el docente tiene un atributo CI de tipo string
            // y si la ci es igual al asignado en el AltaDatosDocente
            Assert.IsInstanceOfType(docente.Ci, typeof(string));
            Assert.AreNotEqual("1111", docente.Ci);
            Assert.AreEqual("1234", docente.Ci);

            // Creamos una lista de materias diferente de la que asignamos
            // al docente para validar que una es igual y la otra no lo es
            List<string> materiasDiferentes = new List<string>();
            materiasDiferentes.Add("Ingles");
            materiasDiferentes.Add("Dibujo");

            // Validamos que el docente tiene un atributo materias de tipo List<string>
            // y que las materias del docente son las asignadas por el metodo AltaDatosDocente
            Assert.IsInstanceOfType(docente.Materias, typeof(List<string>));
            Assert.AreNotEqual(materiasDiferentes, docente.Materias);
            Assert.AreEqual(materias, docente.Materias);
        }

        [TestMethod]
        public void TestBajaDocente()
        {
            // Creamos el abmDocente para gestionar docentes
            // ABM abmDocente = new ABMDocente.ABM();

            // Creamos una lista de docentes para realizar las validaciones
            // List<Docente> misDocentes = new List<Docente>();

            // Agrego Docentes con AltaDatosDocente para tener una lista
            //misDocentes.Add(abmDocente.AltaDatosDocente("Juan Pablo", "111", new List<string>()));
            //misDocentes.Add(abmDocente.AltaDatosDocente("Pedro Malan", "1231", new List<string>()));
            //misDocentes.Add(abmDocente.AltaDatosDocente("Horacio Gabriel", "1234", new List<string>()));
            //misDocentes.Add(abmDocente.AltaDatosDocente("Alejandro", "333", new List<string>()));
            
            //Console.WriteLine("Docentes Creados > " + abmDocente.GetDocentes().Count);
            //Console.WriteLine("Docentes en misDocentes > " + misDocentes.Count);
            //Console.WriteLine("Docentes del ABM > " + abmDocente.GetDocentes().ToString());
            //Console.WriteLine("Docentes mi lista > " + misDocentes.ToString());

            Console.WriteLine("Docentes Creados > " + docentes.Count);
            Console.WriteLine("Docentes en misDocentes > " + misDocentes.Count);
            Console.WriteLine("Docentes del ABM > " + docentes.ToString());
            Console.WriteLine("Docentes mi lista > " + misDocentes.ToString());

            // Valido que antes de eliminar un docente, ambas listas son iguales
            CollectionAssert.AreEqual(misDocentes, docentes);

            // Damos de baja al docente con CI 1234
            abmDocente.BajaDocente("1234");

            // Validamos que las listas ahora son diferentes
            CollectionAssert.AreNotEqual(misDocentes, abmDocente.GetDocentes());
        }

        [TestMethod]
        public void TestBajaDocenteConError()
        {
            // Creamos el abmDocente para gestionar docentes
            //ABM abmDocente = new ABMDocente.ABM();

            // Creamos una lista de docentes para realizar las validaciones
            //List<Docente> misDocentes = new List<Docente>();

            // Agrego Docentes con AltaDatosDocente para tener una lista
            //misDocentes.Add(abmDocente.AltaDatosDocente("Juan Pablo", "111", new List<string>()));
            //misDocentes.Add(abmDocente.AltaDatosDocente("Pedro Malan", "1231", new List<string>()));
            //misDocentes.Add(abmDocente.AltaDatosDocente("Horacio Gabriel", "1234", new List<string>()));
            //misDocentes.Add(abmDocente.AltaDatosDocente("Alejandro", "333", new List<string>()));

            // Vamos a intentar remover un docente que no existe en la lista de docentes
            abmDocente.BajaDocente("5778");

            // Validamos que las listas ahora son diferentes
            //CollectionAssert.AreEqual(misDocentes, abmDocente.GetDocentes());
            CollectionAssert.AreEqual(misDocentes, docentes);
        }

        [TestMethod]
        public void TestModificacionDocente()
        {
            // Creamos el abmDocente para gestionar docentes
            // ABM abmDocente = new ABMDocente.ABM();

            // Creamos una lista de docentes para realizar las validaciones
            // List<Docente> misDocentes = new List<Docente>();

            // Agrego Docentes con AltaDatosDocente para tener una lista
            //misDocentes.Add(abmDocente.AltaDatosDocente("Juan Pablo", "111", new List<string>()));
            //misDocentes.Add(abmDocente.AltaDatosDocente("Pedro Malan", "1231", new List<string>()));
            //misDocentes.Add(abmDocente.AltaDatosDocente("Horacio Gabriel", "1234", new List<string>()));
            //misDocentes.Add(abmDocente.AltaDatosDocente("Alejandro", "333", new List<string>()));

            // Creamos un nuevo docente para modificar
            Docente nuevosValoresDocente = new Docente();
            nuevosValoresDocente.Nombre = "Juan Daniel";

            // Modificamos el docente con CI 111 (docentes[0]) con los nuevos valores del docente
            abmDocente.ModificarDocente("111", nuevosValoresDocente);

            // Validamos que el nombre del docente modificado es igual al nuevo nombre asignado
            Assert.AreEqual("Juan Daniel", docentes[0].Nombre);
        }

        public void generarDatos()
        {
            // Creamos el abmDocente para gestionar docentes
            abmDocente = new ABMDocente.ABM();

            // Creamos una lista de docentes para realizar las validaciones
            misDocentes = new List<Docente>();

            // Agrego Docentes con AltaDatosDocente para tener una lista
            misDocentes.Add(abmDocente.AltaDatosDocente("Juan Pablo", "111", new List<string>()));
            misDocentes.Add(abmDocente.AltaDatosDocente("Pedro Malan", "1231", new List<string>()));
            misDocentes.Add(abmDocente.AltaDatosDocente("Horacio Gabriel", "1234", new List<string>()));
            misDocentes.Add(abmDocente.AltaDatosDocente("Alejandro", "333", new List<string>()));

            docentes = abmDocente.GetDocentes();
        }
    }
}