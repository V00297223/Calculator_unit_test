using CalculatorLibrary;

namespace TestCalculator
{
    [TestClass]
    public class TestCalc
    {
        //private readonly CalculatorLib calculatorLib;

        //public TestCalc(CalculatorLib calculatorLib) {
        //    calculatorLib = calculatorLib;
        //}

            [TestMethod]
            public void TestAddPositiveNumbers()
            {
            CalculatorLib calculatorLib = new CalculatorLib();

                // Arrange
                decimal num1 = 5;
                decimal num2 = 3;
                decimal expected = 8;

                // Act
                decimal result = calculatorLib.Add(num1, num2);

                // Assert
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void TestAddNegativeNumbers()
            {
            CalculatorLib calculatorLib = new CalculatorLib();

            // Arrange
            decimal num1 = -5;
                decimal num2 = -3;
                decimal expected = -8;

                // Act
                decimal result = calculatorLib.Add(num1, num2);

                // Assert
                Assert.AreEqual(expected, result);
            }

        [TestMethod]
        public void TestAddPositiveAndNegativeNumbers()
        {
            CalculatorLib calculatorLib = new CalculatorLib();

            // Arrange
            decimal num1 = 5;
            decimal num2 = -3;
            decimal expected = 2;

            // Act
            decimal result = calculatorLib.Add(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAddZero()
        {
            CalculatorLib calculatorLib = new CalculatorLib();

            // Arrange
            decimal num1 = 5;
            decimal num2 = 0;
            decimal expected = 5;

            // Act
            decimal result = calculatorLib.Add(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestAddThrowsExceptionWhenNum2IsZero()
        {
            CalculatorLib calculatorLib = new CalculatorLib();

            // Arrange
            decimal num1 = 5;
            decimal num2 = 0;

            // Act
            decimal result = calculatorLib.Add(num1, num2);

            // Assert
            // Exception is thrown in the method, no further assertion needed
        }

        [TestMethod]
        public void TestSubtractPositiveNumbers()
        {
            CalculatorLib calculatorLib = new CalculatorLib();

            // Arrange
            decimal num1 = 5;
            decimal num2 = 3;
            decimal expected = 2;

            // Act
            decimal result = calculatorLib.Subtract(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSubtractNegativeNumbers()
        {
            CalculatorLib calculatorLib = new CalculatorLib();

            // Arrange
            decimal num1 = -5;
            decimal num2 = -3;
            decimal expected = -2;

            // Act
            decimal result = calculatorLib.Subtract(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSubtractPositiveAndNegativeNumbers()
        {
            CalculatorLib calculatorLib = new CalculatorLib();

            // Arrange
            decimal num1 = 5;
            decimal num2 = -3;
            decimal expected = 8;

            // Act
            decimal result = calculatorLib.Subtract(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSubtractZero()
        {
            CalculatorLib calculatorLib = new CalculatorLib();

            // Arrange
            decimal num1 = 5;
            decimal num2 = 0;
            decimal expected = 5;

            // Act
            decimal result = calculatorLib.Subtract(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }


    }
}