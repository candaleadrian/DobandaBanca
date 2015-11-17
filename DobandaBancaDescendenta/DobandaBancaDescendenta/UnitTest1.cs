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
    }
}
class Clasa
{
    int calculatorRata(int sumaImprumutata, Decimal dobanda, int nrLuni)
    {
        Decimal sumaDatorataPeLunaFaraDob = sumaImprumutata / nrLuni;

        Decimal totalDobanda = sumaImprumutata * dobanda / 100; 

        return 4;
    }
}