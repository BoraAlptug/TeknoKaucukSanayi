using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknoKaucuk.Business.SumAndMultiplyCalculation.Concrete
{
    internal class InputValidator
    {
        private readonly string wrongMassage="Hatali Girdi";
        public string InpuValidation(string UserValue )
        {
            double num;
            bool result=double.TryParse(UserValue, out num);
            if (result)
            {
                return null;
            }
            return wrongMassage;
        }
        public bool ValidationResult(string ValidationMessage)
        {
            if (ValidationMessage == wrongMassage)
            {
                return false;
            }
            return true;
        }

    }
}
