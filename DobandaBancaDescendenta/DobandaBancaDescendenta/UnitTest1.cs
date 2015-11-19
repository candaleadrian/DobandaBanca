using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DobandaBancaDescendenta
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculPtOLuna()
        {
            Assert.AreEqual(10.90, calculatorRata(100, 12, 10, 1));
        }
        [TestMethod]
        public void CalculLuna2()
        {
            Assert.AreEqual(10.8, calculatorRata(100, 12, 10, 2));
        }
        double  calculatorRata(int sumaImprumutata, Double  dobanda, int nrLuni, int lunaDorita)
        {
            Double  sumaDatorataPeLunaFaraDob = sumaImprumutata / nrLuni;
            Double sumaRamasaFaraDob = sumaDatorataPeLunaFaraDob * (nrLuni - lunaDorita);
            Double dobandaLunara = dobanda / 12 / 100;
            Double rataPeLunaDorita = sumaDatorataPeLunaFaraDob + sumaRamasaFaraDob * dobandaLunara;

            return rataPeLunaDorita;
            //return 5.8;
        }

    }
}