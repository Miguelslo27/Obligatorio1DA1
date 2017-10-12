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
        [TestMethod]
        public void TestTipoModuloABMDocente()
        {
            ABM abmDocente = new ABMDocente.ABM();
            Docente docente = abmDocente.AltaDatosDocente("", "", new List<string>());

            // Test si el abm implementa la interfaz IModulo
            Assert.IsInstanceOfType(abmDocente, typeof(IModulo));

            // Test si el docente creado es del tipo Docente
            Assert.IsInstanceOfType(docente, typeof(Docente));

            // Test si abm tiene nombre y descripción
            Assert.AreEqual("Gestion Docente", abmDocente.Nombre);
            Assert.AreEqual("Alta, Baja y Modificación de Docentes", abmDocente.Descripcion);
        }

        [TestMethod]
        public void TestAltaDocente()
        {
            ABM abmDocente = new ABMDocente.ABM();
            List<string> materias = new List<string>();
            materias.Add("Aritmetica");
            materias.Add("Sistemas informaticos");
            Docente docente = abmDocente.AltaDatosDocente("Nombre del Docente", "1234", materias);

            Assert.IsInstanceOfType(docente, typeof(Docente));

            // Probar que el docente tiene un atributo nombre de tipo string
            Assert.IsInstanceOfType(docente.Nombre, typeof(string));
            Assert.AreNotEqual("Nombre cualquiera", docente.Nombre);
            Assert.AreEqual("Nombre del Docente", docente.Nombre);

            // Probar que el docente tiene un atributo CI de tipo string
            Assert.IsInstanceOfType(docente.Ci, typeof(string));
            Assert.AreNotEqual("1111", docente.Ci);
            Assert.AreEqual("1234", docente.Ci);

            List<string> materiasDiferentes = new List<string>();
            materiasDiferentes.Add("Ingles");
            materiasDiferentes.Add("Dibujo");

            // Probar que el docente tiene un atributo materias de tipo List<string>
            Assert.IsInstanceOfType(docente.Materias, typeof(List<string>));
            Assert.AreNotEqual(materiasDiferentes, docente.Materias);
            Assert.AreEqual(materias, docente.Materias);
        }
    }
}