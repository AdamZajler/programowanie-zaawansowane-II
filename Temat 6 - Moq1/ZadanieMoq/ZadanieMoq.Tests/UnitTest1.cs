using Moq;
namespace ZadanieMoq.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Substract_ShouldSendDataToWebService()
        {
            // Arrange
            Mock<IWebService> webServiceMock = new Mock<IWebService>();
            Calculator calculator = new Calculator(webServiceMock.Object);

            // Act
            int result = calculator.Substract(10, 5);

            // Assert
            Assert.AreEqual(5, result);

            // Verify that the SendData method was called with the expected argument
            webServiceMock.Verify(ws => ws.SendData("Substract operation: 10 - 5 = 5"), Times.Once);
        }
    }
}