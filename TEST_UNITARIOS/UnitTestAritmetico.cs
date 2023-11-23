using Nuñez_IgnacioNatanael_2C_TPFinal;

namespace TEST_UNITARIOS
{
    /// <summary>
    /// Clase de prueba para el calculador de precios.
    /// </summary>
    [TestClass]
    public class CalculadoraPreciosTests
    {
        /// <summary>
        /// Prueba unitaria para calcular el precio total sin ida y vuelta.
        /// </summary>
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

        /// <summary>
        /// Prueba unitaria para calcular el precio total con ida y vuelta.
        /// </summary>
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
