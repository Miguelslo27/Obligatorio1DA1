using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ABMDocente;
using ABMDocente.Clases;

namespace Obligatorio1DA1UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAltaDocente()
        {
            GestorDocentes gestorDocentes = new GestorDocentes();
            Docente docente = gestorDocentes.altaDatosDocente();

            // Test si el docente creado es del tipo Docente
            Assert.IsInstanceOfType(docente, typeof(Docente));
        }
    }
}
