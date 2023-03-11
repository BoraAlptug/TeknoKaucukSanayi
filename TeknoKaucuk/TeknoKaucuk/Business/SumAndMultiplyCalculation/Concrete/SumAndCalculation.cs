using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknoKaucuk.Business.SumAndMultiplyCalculation.Concrete
{
    internal class SumAndCalculation
    {
        private string _sumValA;
        private string _sumValB;
        private string _mutVal;
        private readonly string wrongMassage = "Hatali Girdi";

        public void SetSumValA(string sumValA,string massage)
        {
            if (massage != wrongMassage)
            {
                _sumValA = sumValA;
            }
            else
            {
                _sumValA = null;
            }
            
        }
        public void SetSumValB(string sumValB,string massage)
        {
            if (massage != wrongMassage)
            {
                _sumValB = sumValB;
            }
            else
            {
                _sumValB = null;
            }
        }
        public void SetMultVal(string multVal, string massage)
        {
            if (massage != wrongMassage)
            {
                _mutVal = multVal;
            }
            else
            {
                _mutVal = null;
            }
        }

        public string CalculationResult()
        {
            if (_sumValA == null || _sumValB == null || _mutVal == null )
            {
                return "";
            }
            else
            {
                double num = (double.Parse(_sumValA) + double.Parse(_sumValB)) * double.Parse(_mutVal);
                return num.ToString();
            }
            
        }
    }
}
