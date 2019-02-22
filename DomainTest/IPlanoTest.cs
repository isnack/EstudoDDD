using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainTest
{
    [TestClass]
    public class IPlanoTest
    {
        [TestMethod]
        public void deveRetornarZeroQuandoInformaVinteMinutosNoPlanoTrintaMinutos()
        {
            IPlano plano = new FaleMais30();
            int minutos = 20;
            int esperado = 0;

            int atual = plano.calculateDiscountPlanMinutes(minutos);

            Assert.AreEqual(esperado, atual, 0.1);
        }
        [TestMethod]
        public void deveRetornarDezQuandoInformaQuarentaMinutosNoPlanoTrintaMinutos()
        {
            IPlano plano = new FaleMais30();
            int minutos = 40;
            int esperado = 10;

            int atual = plano.calculateDiscountPlanMinutes(minutos);

            Assert.AreEqual(esperado, atual, 0.1);
        }
        [TestMethod]
        public void deveRetornarZeroQuandoInformaZeroMinutosNoPlanoTrintaMinutos()
        {
            IPlano plano = new FaleMais30();
            int minutos = 0;
            int esperado = 0;

            int atual = plano.calculateDiscountPlanMinutes(minutos);

            Assert.AreEqual(esperado, atual, 0.1);
        }
        [TestMethod]
        public void deveRetornarZeroQuandoInformaValorNegativoNoPlanoTrintaMinutos()
        {
            IPlano plano = new FaleMais30();
            int minutos = -10;
            int esperado = 0;

            int atual = plano.calculateDiscountPlanMinutes(minutos);

            Assert.AreEqual(esperado, atual, 0.1);
        }
        [TestMethod]
        public void deveRetornarZeroQuandoInformaZeroMinutosNoPlanoSessentaMinutos()
        {
            IPlano plano = new FaleMais60();
            int minutos = 30;
            int esperado = 0;

            int atual = plano.calculateDiscountPlanMinutes(minutos);

            Assert.AreEqual(esperado, atual, 0.1);
        }

        [TestMethod]
        public void deveRetornarDezQuandoInformaCentoETrintaMinutosNoPlanoCentoEVinteMinutos()
        {
            IPlano plano = new FaleMais120();
            int minutos = 130;
            int esperado = 10;

            int atual = plano.calculateDiscountPlanMinutes(minutos);

            Assert.AreEqual(esperado, atual, 0.1);
        }
    }
}
