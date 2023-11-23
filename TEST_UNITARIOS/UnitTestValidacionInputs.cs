using Nuñez_IgnacioNatanael_2C_TPFinal;

namespace TEST_UNITARIOS
{

    // Test de campos de entrada
    [TestClass]
    public class ValidacionesTests
    {
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

        [TestMethod]
        public void ValidarNombre_NombreInvalido_RetornaFalse()
        {
            // Arrange
            string nombre = "Juan123";

            // Act 
            bool resultado = Validaciones.ValidarNombre(nombre, null);

            // Assert
            Assert.IsFalse(resultado); // Salta cartel de aviso que esta imprementado en el codigo
        }

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

        // Resto de métodos
    }
    
}