using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorneevaEA.Sprint4.Task1.V5.Lib;

namespace Tyuiu.KorneevaEA.Sprint4.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VallidCalculate()
        {

            DataService ds = new DataService();

            int[] numArray = { 9, 6, 6, 9, 7, 8, 5, 9, 6, 6, 8, 6, 8, 6, 7 };
            int sumArray = ds.Calculate(numArray);
            int waitArray = 60;
            Assert.AreEqual(sumArray, waitArray);

        }
    }
}
