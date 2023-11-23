using Nuñez_IgnacioNatanael_2C_TPFinal;

namespace TEST_UNITARIOS
{

    // Test de precios
    [TestClass]
    public class CalculadoraPreciosTests
    {

        [TestMethod]
        public void CalcularPrecioTotal_SinIdaVuelta_RetornaPrecioCorrecto()
        {
            // Arrange
            var calculadora = new CalculadoraPrecios();

            decimal precioBase = 5000;
            decimal precioXKm = 25000;
            decimal precioEquipaje = 1000;

            // Act
            decimal resultado = calculadora.CalcularPrecioTotal(precioBase, precioXKm, precioEquipaje, false);

            // Assert 
            Assert.AreEqual(31000, resultado);
        }

        // Esta me llego a fallar 
        [TestMethod]
        public void CalcularPrecioTotal_ConIdaVuelta_RetornaPrecioCorrecto()
        {
            // Arrange
            var calculadora = new CalculadoraPrecios();

            decimal precioBase = 5000;
            decimal precioXKm = 25000;
            decimal precioEquipaje = 1000;

            // Act
            decimal resultado = calculadora.CalcularPrecioTotal(precioBase,
                precioXKm, precioEquipaje, true);

            // Assert 
            Assert.AreEqual(56000, resultado);
        }
    }
}