using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculadora.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSuma()
        {
            var s = Suma.Sum(1, 2);
            Assert.AreEqual(3,s);
        }
        [TestMethod]
        public void TestResta()
        {
            var s = Resta.Substract(3, 2);
            Assert.AreEqual(1, s);
        }
        [TestMethod]
        public void TestRestaFail()
        {
            var resultado = Resta.Substract(-2, 1);
            Assert.AreNotEqual(2, resultado);

        }
        [TestMethod]
        public void TestMultiply()
        {
            var resul = Multiplicacion.Multiply(5, 5);
            Assert.AreEqual(25, resul);

        }
/*        [TestMethod]
        public void TestDivision()
        {
            var result = Division.Div(2, 0);
            //Assert.AreEqual(, result);

        }*/
        [TestMethod]
        public void FactorialTest()
        {
            int result = Factorial.Fact(3);
            Assert.AreEqual(6, result);
        }
        [TestMethod]
        public void FactorialMockTest()
        {
            var result = Factorial.Fact(3);
            Assert.AreNotEqual(6, result);
        }
        [TestMethod]
        public void ReverseWord()
        {
            
        }
    }
}
