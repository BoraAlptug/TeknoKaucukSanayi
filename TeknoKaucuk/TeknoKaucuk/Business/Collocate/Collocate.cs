using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;

namespace TeknoKaucuk.Business.Collocate
{
    internal class Collocate
    {      
        public void Collocation(DataGridView dataGridView)
        {
            int numberCount = 0;
            
            dataGridView.ColumnCount = 20;
            dataGridView.RowCount = 10;
             
            for (int i = 0; i < 10; i++)
            {
                
                
                for (int j = 0; j < 20; j++)
                {
                    numberCount++;
                    
                    if (numberCount % 15 == 0 && numberCount < 100)
                    {
                        dataGridView[j, i].Value = "zigzag";
                    }
                    else if(numberCount % 15 == 0 && numberCount > 100)
                    {
                        dataGridView[j, i].Value = "zagzig";
                    }
                    else if (numberCount % 3 == 0)
                    {
                        dataGridView[j, i].Value = "zig";
                    }
                    else if (numberCount % 5 == 0)
                    {
                        dataGridView[j, i].Value = "zag";
                    }
                    else
                    {
                        dataGridView[j, i].Value = numberCount.ToString();
                    }
 
                    
                }
            }

            
        }


    }
}
