using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DobandaBancaDescendenta
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
        }
        Decimal  calculatorRata(int sumaImprumutata, Decimal dobanda, int nrLuni, int lunaDorita)
        {
            Decimal sumaDatorataPeLunaFaraDob = sumaImprumutata / nrLuni;
            Decimal sumaRamasaFaraDob = sumaDatorataPeLunaFaraDob * (nrLuni - lunaDorita);
            Decimal dobandaLunara = dobanda / 12 / 100;
            Decimal rataPeLunaDorita = sumaDatorataPeLunaFaraDob + sumaRamasaFaraDob * dobandaLunara;

            return rataPeLunaDorita;
        }

    }
}