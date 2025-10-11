using JAVV.Manipulaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAVV.Manipulaciones.UnitTest.xUnit
{
    public class StringManipulatorTest
    {
        // xUnit no requiere un atributo [TestClass]. La clase de prueba es una clase pública simple.

        // Objeto de la clase a probar, se recomienda inicializar por prueba o como campo de solo lectura
        private readonly StringManipulator _manipulator = new StringManipulator();

        // *** Pruebas para ReverseString ***

        [Fact] // Atributo principal de xUnit para identificar una prueba unitaria
        public void ReverseString_SimpleWord_ReturnsReversedWord()
        {
            // Arrange
            string input = "Hello";
            string expected = "olleH";

            // Act
            string actual = _manipulator.ReverseString(input);

            // Assert
            // Usa Assert.Equal para comparación de cadenas
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseString_EmptyString_ReturnsEmptyString()
        {
            // Arrange
            string input = "";
            string expected = "";

            // Act
            string actual = _manipulator.ReverseString(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseString_PhraseWithSpaces_ReturnsReversedPhrase()
        {
            // Arrange
            string input = "a b c";
            string expected = "c b a";

            // Act
            string actual = _manipulator.ReverseString(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        // *** Pruebas para RemoveSpaces ***

        [Fact]
        public void RemoveSpaces_PhraseWithInternalSpaces_ReturnsConcatenatedString()
        {
            // Arrange
            string input = "texto con espacios";
            string expected = "textoconespacios";

            // Act
            string actual = _manipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveSpaces_StringWithLeadingAndTrailingSpaces_ReturnsCleanString()
        {
            // Arrange
            string input = "  ejemplo  ";
            string expected = "ejemplo";

            // Act
            string actual = _manipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveSpaces_StringWithNoSpaces_ReturnsSameString()
        {
            // Arrange
            string input = "SinEspacios";
            string expected = "SinEspacios";

            // Act
            string actual = _manipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveSpaces_OnlySpaces_ReturnsEmptyString()
        {
            // Arrange
            string input = "   ";
            string expected = "";

            // Act
            string actual = _manipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}