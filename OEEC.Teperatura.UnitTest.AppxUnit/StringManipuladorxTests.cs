using OEEC.StringManipulador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEEC.Teperatura.UnitTest.AppxUnit
{
    public class StringManipulador
    {
        [Fact]
        public void ReverseString_ShouldReverseInput()
        {
            // Arrange
            StringManipulator manipulator = new StringManipulator();
            string input = "Hello";

            // Act
            string result = manipulator.ReverseString(input);

            // Assert
            Assert.Equal("olleH", result);
        }

        [Fact]
        public void RemoveSpaces_ShouldRemoveSpaces()
        {
            // Arrange
            StringManipulator manipulator = new StringManipulator();
            string input = "Hello World";

            // Act
            string result = manipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal("HelloWorld", result);
        }
    }
}
