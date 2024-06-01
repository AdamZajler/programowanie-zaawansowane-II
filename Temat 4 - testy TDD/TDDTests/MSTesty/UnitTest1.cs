using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTests; 
using static TDDTests.Program;

namespace MSTesty
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculator kalkulator = new Calculator();
            int a = 20;
            int b = 10;

            // Act
            int wynik = kalkulator.Substraction(a, b);

            // Assert
            Assert.AreEqual(10, wynik);
        }
    }
}