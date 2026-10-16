using ActividadTDDApp;

namespace TestActividadTDDApp
{
    [TestClass]
    public sealed class FuncionesTest
    {
        [TestMethod]
        public void Saber_Numero_Negativo()
        {
            long resultado = Funciones.CalcularFactorial(-3);

            Assert.AreEqual(-1, resultado);
        }

        [TestMethod]
        public void Saber_Factorial_De_0()
        {
            long resultado = Funciones.CalcularFactorial(0);

            // Assert
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void CalcularFactorialCorrecto()
        {
            long resultado = Funciones.CalcularFactorial(3);

            // Assert
            Assert.AreEqual(6, resultado);
        }
    }
}
