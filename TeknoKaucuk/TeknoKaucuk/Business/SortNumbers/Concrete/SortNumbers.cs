using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace TeknoKaucuk.Business.SortNumbers.Concrete
{
    internal class SortNumbers
    {
        private List<double> sortedNumbers;

        public void SetSortNumbers(string[] Numbers)
        {
            
            char[] whiteSpaceChars = new char[] { ' ', '\t', '\n', '\r', '\f', '\v' };
            List<double> numbers = new List<double>();
            foreach (string line in Numbers)
            {
                string[] tokens = line.Split(whiteSpaceChars, StringSplitOptions.RemoveEmptyEntries);

                foreach (string token in tokens)
                {
                    double number;
                    if (double.TryParse(token, out number))
                    {
                        numbers.Add(number);
                    }
                }
            }
            numbers.Sort();
            sortedNumbers = numbers;
        }
        public string WriteToLabelSortedNumber()
        {
            string labelNumberString="";
                        
            for(int i = 0; i < sortedNumbers.Count; i++)
            {
                labelNumberString = labelNumberString+ " | " + sortedNumbers[i].ToString();
            }
            return labelNumberString;
        }
    }
}
