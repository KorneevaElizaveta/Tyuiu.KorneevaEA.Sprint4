using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KorneevaEA.Sprint4.Task0.V9.Lib
{
    public class DataService : ISprint4Task0V4
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int x = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    x += array[i];
                }
            }
            return x;
        }
    }
}
