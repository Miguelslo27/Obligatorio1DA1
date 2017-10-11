using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ABMDocente;
using Interfaces;

namespace Obligatorio1DA1UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAltaDocente()
        {
            ABM abm = new ABM();
            Docente docente = abm.altaDatosDocente();

            // Test si el abm implementa la interfaz IModulo
            Assert.IsInstanceOfType(abm, typeof(IModulo));
            
            // Test si el docente creado es del tipo Docente
            Assert.IsInstanceOfType(docente, typeof(Docente));

            // Test si abm tiene nombre y descripción

        }
    }
}
