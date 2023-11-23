using Nu�ez_IgnacioNatanael_2C_TPFinal;

namespace TEST_UNITARIOS
{
    /// <summary>
    /// Clase de prueba para las validaciones de inputs.
    /// </summary>
    [TestClass]
    public class ValidacionesTests
    {
        /// <summary>
        /// Prueba unitaria para validar un nombre v�lido.
        /// </summary>
        [TestMethod]
        public void ValidarNombre_NombreValido_RetornaTrue()
        {
            // Arrange
            string nombre = "Juan";

            // Act
            bool resultado = Validaciones.ValidarNombre(nombre, null);

            // Assert
            Assert.IsTrue(resultado);
        }

        /// <summary>
        /// Prueba unitaria para validar un nombre inv�lido.
        /// </summary>
        [TestMethod]
        public void ValidarNombre_NombreInvalido_RetornaFalse()
        {
            // Arrange
            string nombre = "Juan123";

            // Act 
            bool resultado = Validaciones.ValidarNombre(nombre, null);

            // Assert
            Assert.IsFalse(resultado); // Salta cartel de aviso que est� implementado en el c�digo
        }

        /// <summary>
        /// Prueba unitaria para validar un DNI v�lido.
        /// </summary>
        [TestMethod]
        public void ValidarDNI_DNIValido_RetornaTrue()
        {
            // Arrange
            string dni = "32165987";

            // Act
            bool resultado = Validaciones.ValidarDNI(dni, null);

            // Assert
            Assert.IsTrue(resultado);
        }

        // Resto de m�todos
    }
}
