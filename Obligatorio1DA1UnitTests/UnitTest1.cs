using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ABMDocente;

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

            // Test si el docente creado es del tipo Docente
            Assert.IsInstanceOfType(docente, typeof(Docente));

            //
        }
    }
}
