using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknoKaucuk.Business.Collocate;
using TeknoKaucuk.Business.FibonacciSeries.Concrete;
using TeknoKaucuk.Business.MultiplicationTable.Concrete;
using TeknoKaucuk.Business.SortNumbers.Concrete;
using TeknoKaucuk.Business.SumAndMultiplyCalculation.Concrete;
using static System.Windows.Forms.LinkLabel;

namespace TeknoKaucuk
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //** Setting all labels
            SetAllLabels();
        }

        private void SetAllLabels()
        {
            string wrongMassage = "Hatali Girdi";
            SumValA_lbl.Text = wrongMassage;
            SumValB_lbl.Text = wrongMassage;
            MulVal_lbl.Text = wrongMassage;
            fbnc_lbl.Text = wrongMassage;

            multiplicationTable_lbl.Text = wrongMassage;
        }

        private void Calculation_btn_Click(object sender, EventArgs e)
        {
            //**Create instance necessary components
            SumAndCalculation sumAndCalculation =new SumAndCalculation();
            
            //**Setting input values which came from user
            sumAndCalculation.SetSumValA(SumValA_txt.Text, SumValA_lbl.Text);
            sumAndCalculation.SetSumValB(SumValB_txt.Text,SumValB_lbl.Text);
            sumAndCalculation.SetMultVal(MulVal_txt.Text, MulVal_lbl.Text);

            //**Calculation
            Conc_lbl.Text = sumAndCalculation.CalculationResult();
        }


        private void SumValA_txt_KeyUp(object sender, KeyEventArgs e)
        {
            //**Check inputs which came from user
            InputValidator inputValidator = new InputValidator();
            SumValA_lbl.Text= inputValidator.InpuValidation(SumValA_txt.Text);

        }

        private void SumValB_txt_KeyUp(object sender, KeyEventArgs e)
        {
            //**Check inputs which came from user
            InputValidator inputValidator = new InputValidator();
            SumValB_lbl.Text = inputValidator.InpuValidation(SumValB_txt.Text);
        }

        private void MulVal_txt_KeyUp(object sender, KeyEventArgs e)
        {
            //**Check inputs which came from user
            InputValidator inputValidator = new InputValidator();
            MulVal_lbl.Text = inputValidator.InpuValidation(MulVal_txt.Text);
        }

        private void collocate_btn_Click(object sender, EventArgs e)
        {
            //**Create instance necessary components
            Collocate collocate= new Collocate();

            //**Collocation process
            collocate.Collocation(collocation_dgw);

        }

        private void multiplicationTable_txt_KeyUp(object sender, KeyEventArgs e)
        {
            //**Check inputs which came from user
            InputValidator inputValidator = new InputValidator();
            multiplicationTable_lbl.Text = inputValidator.InpuValidation(multiplicationTable_txt.Text);
        }

        private void multiplicationTable_btn_Click(object sender, EventArgs e)
        {
            //**Create instance necessary components
            MultiplicationTable multiplicationTable = new MultiplicationTable();

            //**Get input value
            multiplicationTable.SetUserNumber(multiplicationTable_txt.Text,multiplicationTable_lbl.Text);
            multiplicationTable.CalculateTable();
             multiplicationTable.SetMultiplicationTable(multiplicationTable_dgw);

        }

        private void openFile_btn_Click(object sender, EventArgs e)
        {
            //**Create instance necessary components
            SortNumbers sortNumbers = new SortNumbers();

            //**Setting openFileDialog object features
            fileOpen_opn.Filter = "Text Files (*.txt)|*.txt";
            fileOpen_opn.Title = "Metin Dosyası Seçin";

            //**Reading Process and check openFileDialog state
            if (fileOpen_opn.ShowDialog() == DialogResult.OK)
            {
                sortNumbers.SetSortNumbers( File.ReadAllLines(fileOpen_opn.FileName));
                sortNumber_lbl.Text = sortNumbers.WriteToLabelSortedNumber();
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fbnc_txt_KeyUp(object sender, KeyEventArgs e)
        {
            //**Check inputs which came from user
            InputValidator inputValidator = new InputValidator();
            fbnc_lbl.Text = inputValidator.InpuValidation(fbnc_txt.Text);
        }

        private void fbnc_btn_Click(object sender, EventArgs e)
        {
            //**Create instance necessary components
            FibonacciSeries fibonacciSeries=new FibonacciSeries();
            fbncValue_lbl.Text= fibonacciSeries.GetCountFibonacciNumber(fbnc_txt.Text);
        }
    }
}
