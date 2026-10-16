using ActividadTDDApp;
using System.ComponentModel.DataAnnotations;

namespace TestActividadTDDApp
{
    [TestClass]
    public sealed class FuncionesTest
    {
        [TestMethod]
        public void SaberNumeroNegativo()
        {
            long resultado = Funciones.CalcularFactorial(-3);

            Assert.AreEqual(-1, resultado);
        }

        [TestMethod]
        public void SaberFactorialDe0()
        {
            long resultado = Funciones.CalcularFactorial(0);

            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void CalcularFactorialCorrecto()
        {
            long resultado = Funciones.CalcularFactorial(3);

            Assert.AreEqual(6, resultado);
        }

        [TestMethod]
        public void ComprobarContrasenyaNull()
        {
            string contrasenya = null;

            bool resultado = Funciones.EsContrasenyaValida(contrasenya);

            Assert.IsFalse(resultado);
        }
        [TestMethod]
        public void ComprobarContrasenyaVacia()
        {
            string contrasenya = "";

            bool resultado = Funciones.EsContrasenyaValida(contrasenya);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void ComprobarContrasenyaCaracteres()
        {
            string contrasenya = "1234567"; 

            bool resultado = Funciones.EsContrasenyaValida(contrasenya);

            Assert.IsFalse(resultado);
        }
        [TestMethod]
        public void NoContieneContrasenyaAlmohadilla()
        {
            string contrasenya = "Contrasenya123";

            bool resultado = Funciones.EsContrasenyaValida(contrasenya);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void ContieneContrasenyaAlmohadilla()
        {
            string contrasenya = "Contrasenya123#"; 

            bool resultado = Funciones.EsContrasenyaValida(contrasenya);

            Assert.IsTrue(resultado);
        }
    }
}
