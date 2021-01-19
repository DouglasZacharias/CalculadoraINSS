using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        Calculadora.CalculadoraINSS calc = new Calculadora.CalculadoraINSS();
        [TestMethod]
        public void Teste2011()
        {
            DateTime data = Convert.ToDateTime("25/12/2011");
            Assert.AreEqual(calc.CalcularDesconto(data, 800M), 64M);
            Assert.AreEqual(calc.CalcularDesconto(data, 1200M), 108M);
            Assert.AreEqual(calc.CalcularDesconto(data, 1840M), 165.6M);
            Assert.AreEqual(calc.CalcularDesconto(data, 1900M), 209M);
            Assert.AreEqual(calc.CalcularDesconto(data, 3689M), 405.79M);
            Assert.AreEqual(calc.CalcularDesconto(data, 4000M), 405.86M);
            Assert.AreEqual(calc.CalcularDesconto(data, 5000M), 405.86M);
        }
        [TestMethod]
        public void Teste2012()
        {
            DateTime data = Convert.ToDateTime("25/12/2012");
            Assert.AreEqual(calc.CalcularDesconto(data, 800M), 56M);
            Assert.AreEqual(calc.CalcularDesconto(data, 1200M), 96M);
            Assert.AreEqual(calc.CalcularDesconto(data, 1840M), 165.6M);
            Assert.AreEqual(calc.CalcularDesconto(data, 1900M), 171M);
            Assert.AreEqual(calc.CalcularDesconto(data, 3689M), 405.79M);
            Assert.AreEqual(calc.CalcularDesconto(data, 4000M), 440M);
            Assert.AreEqual(calc.CalcularDesconto(data, 5000M), 500M);
        }
    }
}
