using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ABMDocente;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testAltaDatosDocente()
        {
            Docente docente = new Docente();
            Console.WriteLine(typeof docente);

            //Assert.IsInstanceOfType(docente, "Docente");
        }
    }
}
