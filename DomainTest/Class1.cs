using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainTest
{
    [TestClass]
    public class Class1
    {
       
        [TestMethod]
        public void deveRetornarCorretamenteValorPlano60minutos()
        {
            int minutos = 80;
            int minutosDescontados = 0;
            double atual = 0.0;
            IPlano plano = new FaleMais60();

            string origem = "011";
            string destino = "017";
            double valor = 1.70;
            Tarifa tafifa = new Tarifa(origem, destino, valor);

            if (!plano.EstaDentroDoPlano(minutos))
            {
                minutosDescontados = plano.calcularDescontoMinutosPlano(minutos);
                atual = tafifa.valorTotalComMulta(minutosDescontados);
            }
            double esperado = 37.40;          
            Assert.AreEqual(esperado, atual, 0.1);
        }
    }
}
