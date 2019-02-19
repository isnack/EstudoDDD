using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainTest
{
    [TestClass]
    public class TarifaTest
    {
        [TestMethod]
        public void deveCalcularValorDeMinutoComMulta()
        {
            string origem = "011";
            string destino = "017";
            double valor = 1.70;
            Tarifa tafifa = new Tarifa(origem,destino,valor);
            double esperado = 1.87;
            double atual = tafifa.ValorMinutoComMulta();

            Assert.AreEqual(esperado, atual,0.1);
           
        }

        [TestMethod]
        public void deveRetornarZeroSeValorForNegativo()
        {
            string origem = "011";
            string destino = "017";
            double valor = -1.70;
            Tarifa tafifa = new Tarifa(origem, destino, valor);

            double esperado = 0;
            double atual = tafifa.ValorMinutoComMulta();

            Assert.AreEqual(esperado, atual, 0.1);
        }

        [TestMethod]
        public void deveCalcularValorTotalInformandoMinutos()
        {
            string origem = "011";
            string destino = "017";
            double valor = 1.70;
            int minutos = 20;
            Tarifa tafifa = new Tarifa(origem, destino, valor);

            double esperado = 34;
            double atual = tafifa.valorTotal(minutos);

            Assert.AreEqual(esperado, atual, 0.1);
        }
        [TestMethod]
        public void deveRetornarZeroSeValorForNegativoValorTotal()
        {
            string origem = "011";
            string destino = "017";
            double valor = -1.70;
            int minutos = 20;
            Tarifa tafifa = new Tarifa(origem, destino, valor);

            double esperado = 0;
            double atual = tafifa.valorTotal(minutos);

            Assert.AreEqual(esperado, atual, 0.1);
        }

        [TestMethod]
        public void deveRetornarZeroSeMinutosForemNegativosValorTotal()
        {
            string origem = "011";
            string destino = "017";
            double valor = 1.70;
            int minutos = -20;
            Tarifa tafifa = new Tarifa(origem, destino, valor);

            double esperado = 0;
            double atual = tafifa.valorTotal(minutos);

            Assert.AreEqual(esperado, atual, 0.1);
        }
    }
}
