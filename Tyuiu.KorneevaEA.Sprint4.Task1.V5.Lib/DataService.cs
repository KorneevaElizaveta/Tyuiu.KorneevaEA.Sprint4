﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KorneevaEA.Sprint4.Task1.V5.Lib
{
    public class DataService : ISprint4Task1V5
    {
        public int Calculate(int[] array)
        {
            int sumArray = 0;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sumArray += array[i];
                }
            }
            return sumArray;
        }
    }
}
