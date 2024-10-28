using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [TestInitialize]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        public void Add_ValidNumbers_ReturnsSum()
        {
            // Preparar
            double num1 = 5;
            double num2 = 3;
            double expected = 8;

            // Actuar
            double result = _calculator.Add(num1, num2);

            // Afirmar
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Subtract_ValidNumbers_ReturnsDifference()
        {
            // Preparar
            double num1 = 5;
            double num2 = 3;
            double expected = 2;

            // Actuar
            double result = _calculator.Subtract(num1, num2);

            // Afirmar
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Multiply_ValidNumbers_ReturnsProduct()
        {
            // Preparar
            double num1 = 5;
            double num2 = 3;
            double expected = 15;

            // Actuar
            double result = _calculator.Multiply(num1, num2);

            // Afirmar
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Divide_ValidNumbers_ReturnsQuotient()
        {
            // Preparar
            double num1 = 6;
            double num2 = 2;
            double expected = 3;

            // Actuar
            double result = _calculator.Divide(num1, num2);

            // Afirmar
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            // Preparar
            double num1 = 5;
            double num2 = 0;

            // Actuar y Afirmar
            Assert.ThrowsException<DivideByZeroException>(() => _calculator.Divide(num1, num2));
        }

        // Probando suma con números negativos
        [TestMethod]
        public void Add_NegativeNumbers_ReturnsCorrectSum()
        {
            // Preparar
            double num1 = -5;
            double num2 = -3;
            double expected = -8;

            // Actuar
            double result = _calculator.Add(num1, num2);

            // Afirmar
            Assert.AreEqual(expected, result);
        }

        // Probando resta que resulta en número negativo
        [TestMethod]
        public void Subtract_ResultNegative_ReturnsCorrectDifference()
        {
            // Preparar
            double num1 = 3;
            double num2 = 5;
            double expected = -2;

            // Actuar
            double result = _calculator.Subtract(num1, num2);

            // Afirmar
            Assert.AreEqual(expected, result);
        }

        // Probando multiplicación por cero
        [TestMethod]
        public void Multiply_ByZero_ReturnsZero()
        {
            // Preparar
            double num1 = 5;
            double num2 = 0;
            double expected = 0;

            // Actuar
            double result = _calculator.Multiply(num1, num2);

            // Afirmar
            Assert.AreEqual(expected, result);
        }

        // Probando división con resultado decimal
        [TestMethod]
        public void Divide_DecimalResult_ReturnsCorrectQuotient()
        {
            // Preparar
            double num1 = 5;
            double num2 = 2;
            double expected = 2.5;

            // Actuar
            double result = _calculator.Divide(num1, num2);

            // Afirmar
            Assert.AreEqual(expected, result);
        }

        // Probando multiplicación con números negativos y positivos
        [TestMethod]
        public void Multiply_NegativeAndPositive_ReturnsNegativeProduct()
        {
            // Preparar
            double num1 = -4;
            double num2 = 3;
            double expected = -12;

            // Actuar
            double result = _calculator.Multiply(num1, num2);

            // Afirmar
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add_DecimalNumbers_ReturnsCorrectSum()
        {
            // Preparar
            double num1 = 3.14;
            double num2 = 2.86;
            double expected = 6.00;

            // Actuar
            double result = _calculator.Add(num1, num2);

            // Afirmar
            Assert.AreEqual(expected, result, 0.001, 
                "La suma de números decimales debería ser precisa");
        }
        
        [TestMethod]
        public void MultipleOperations_SimpleCalculation_ReturnsCorrectResult()
        {
            // Preparar
            // (10 + 5) * 2 = 30
            double expected = 30;

            // Actuar
            double stepOne = _calculator.Add(10, 5);     // 15
            double result = _calculator.Multiply(stepOne, 2); // 30

            // Afirmar
            Assert.AreEqual(expected, result, 
                "Las operaciones múltiples deberían calcularse correctamente");
        }

        [TestMethod]
        public void Divide_PeriodicResult_ReturnsApproximation()
        {
            // Preparar
            double num1 = 10;
            double num2 = 3;
            double expected = 3.333333; // Aproximacion a 6 decimales

            // Actuar
            double result = _calculator.Divide(num1, num2);

            // Afirmar
            Assert.AreEqual(expected, result, 0.000001,
                "La división con resultado periódico debería dar una aproximación correcta");
        }

        [TestMethod]
        public void Subtract_NegativeDecimals_ReturnsCorrectDifference()
        {
            // Preparar
            double num1 = -5.5;
            double num2 = -2.2;
            double expected = -3.3;

            // Actuar
            double result = _calculator.Subtract(num1, num2);

            // Afirmar
            Assert.AreEqual(expected, result, 0.001,
                "La resta de decimales negativos debería calcularse correctamente");
        }

        [TestMethod]
        public void Multiply_DecimalAndInteger_ReturnsCorrectProduct()
        {
            // Preparar
            double num1 = 2.5;
            double num2 = 4;
            double expected = 10.0;

            // Actuar
            double result = _calculator.Multiply(num1, num2);

            // Afirmar
            Assert.AreEqual(expected, result, 0.001,
                "La multiplicación de decimal por entero debería ser precisa");
        }
    }
}

