using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorneevaEA.Sprint4.Task0.V9.Lib;

namespace Tyuiu.KorneevaEA.Sprint4.Task0.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VallidGetMultEvenArrEl()
        {

            DataService ds = new DataService();

            int[] numArray = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };
            int x = ds.GetMultEvenArrEl(numArray);
            int WaitX = 38;
            Assert.AreEqual(x, WaitX);

        }
    }
}
