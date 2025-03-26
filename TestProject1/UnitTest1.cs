using Microsoft.Extensions.Logging;
using Moq;
using WebApplicationTest1;
using WebApplicationTest1.Controllers;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var mockLogger = new Mock<ILogger<WeatherForecastController>>();

            // Act
            var controller = new WeatherForecastController(mockLogger.Object);

            // Act
            var result = controller.Get();

            // Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<IEnumerable<WeatherForecast>>(result);
            Assert.True(result.Count() > 1);
            Assert.NotEmpty(result);
        }
    }
}