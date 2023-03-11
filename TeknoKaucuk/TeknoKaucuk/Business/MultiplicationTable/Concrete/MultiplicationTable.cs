using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknoKaucuk.Business.MultiplicationTable.Concrete
{
    internal class MultiplicationTable
    {
        private string _numberCount;
        private readonly string wrongMassage = "Hatali Girdi";
        private readonly string upperBoundNumber = "16";
        private int[,] mainTable;
        public void SetUserNumber(string userValue, string massage)
        {
            if (_numberCount == upperBoundNumber)
            {
                _numberCount = null;
            }
            
            else if(massage != wrongMassage)
            {
                _numberCount = userValue;
            }
            else
            {
                _numberCount = null;
            }

        }

        public void CalculateTable()
        {
            if(_numberCount != null)
            {
                int rowAndColumnNumber = int.Parse(_numberCount);
                int rowAndColumnNumberTable = rowAndColumnNumber + 1;
                int[,] mainTable = new int[rowAndColumnNumberTable, rowAndColumnNumberTable];
                for (int i = 0; i <= rowAndColumnNumber; i++)
                {
                    mainTable[i, 0] = i;
                    mainTable[0, i] = i;

                }

                for (int i = 1; i <= rowAndColumnNumber; i++)
                {
                    for (int j = 1; j <= rowAndColumnNumber; j++)
                    {
                        var a = mainTable[0, j];
                        var b = mainTable[i, 0];
                        mainTable[i, j] = mainTable[0, j] * mainTable[i, 0];
                    }
                }
                this.mainTable= mainTable;
            }
            

        }
        public void SetMultiplicationTable(DataGridView dataGridView)
        {
            if (_numberCount != null)
            {
                int rowAndColumnNumber = int.Parse(_numberCount)+1;
                dataGridView.ColumnCount = rowAndColumnNumber;
                dataGridView.RowCount = rowAndColumnNumber;

                for (int i = 0; i < rowAndColumnNumber; i++)
                {
                    for (int j = 0; j <rowAndColumnNumber; j++)
                    {
                        dataGridView[j, i].Value = mainTable[j, i].ToString();
                    }
                }
                                
            }
            
        }
    }
}
