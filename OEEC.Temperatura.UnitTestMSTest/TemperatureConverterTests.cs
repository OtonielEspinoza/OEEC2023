using Microsoft.VisualStudio.TestTools.UnitTesting;
using OEEC.Temperatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEEC.Temperatura.Tests
{
    [TestClass()]
    public class TemperatureConverterTests
    {
        [TestMethod()]
        public void CelsiusToFahrenheitTest()
        {
            // Arrange
            TemperatureConverter converter = new TemperatureConverter();
            double celsiusTemperature = 25.0;
            double expectedFahrenheit = 77.0;

            // Act
            double resultFahrenheit = converter.CelsiusToFahrenheit(celsiusTemperature);

            // Assert
            Assert.AreEqual(expectedFahrenheit, resultFahrenheit, 0.001);
        }

        [TestMethod()]
        public void FahrenheitToCelsiusTest()
        {
            TemperatureConverter converter = new TemperatureConverter();
            double fahrenheitTemperature = 77.0;
            double expectedCelsius = 25.0;

            // Act
            double resultCelsius = converter.FahrenheitToCelsius(fahrenheitTemperature);

            // Assert
            Assert.AreEqual(expectedCelsius, resultCelsius, 0.001);
        }
    }
}