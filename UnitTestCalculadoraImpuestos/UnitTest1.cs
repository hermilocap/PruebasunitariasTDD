using System;
using Calculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCalculadoraImpuestos
{
    [TestClass]
    public class UnitTest1
    {
        //patron de 3 pasos
        [TestMethod]
        public void ImpuestosTest()
        {
            //Arrange: a inializar los objetos y establecer los valore que se requieren.
            Calculadoras calculadoraImpuestos = new Calculadoras();
            // Act:invocar los metodo en los objetos inicializados
            decimal iva = calculadoraImpuestos.ObtenerIva(1550.00m);
            //Assert: La accion del método se comporta como se habia previsto.
            //monto de reserva=1550
            //1550.00*.16=248
            Assert.AreEqual(248.00m, iva);
        }
        [TestMethod]
        public void IshTest()
        {
            //Arrange: a inializar los objetos y establecer los valore que se requieren.
            Calculadoras calculadoraImpuestos = new Calculadoras();
            // Act:invocar los metodo en los objetos inicializados
            decimal ish = calculadoraImpuestos.ObtenerISH(1550.00m, 0.03m);
            //Assert: La accion del método se comporta como se habia previsto.
            //monto de reserva=1550
            //1550.00*.03=46.50
            Assert.AreEqual(46.50m, ish);
        }
    }
}