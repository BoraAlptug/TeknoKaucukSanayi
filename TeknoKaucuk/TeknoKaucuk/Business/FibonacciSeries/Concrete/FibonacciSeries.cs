using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknoKaucuk.Business.FibonacciSeries.Concrete
{
    internal class FibonacciSeries
    {

        public string GetCountFibonacciNumber(string limitFibonacciNumber)
        {
            
            int firstfibonacciNumber = 0, secondFibonacciNumber = 1, nextFibonacciNumber=0;
            for (int i = 0; i < int.Parse( limitFibonacciNumber); i++)
            {
                if (i <= 1)
                    nextFibonacciNumber = i;
                else
                {
                    nextFibonacciNumber = firstfibonacciNumber + secondFibonacciNumber;
                    firstfibonacciNumber = secondFibonacciNumber;
                    secondFibonacciNumber = nextFibonacciNumber;
                }
            }

            return nextFibonacciNumber.ToString();
        }
    }   
}
