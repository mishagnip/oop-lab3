using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays1DWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[] arr;
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void buttonGeneric_Click(object sender, EventArgs e)
        {
            int n = (int)numericUpDownCount.Value;
            Random rnd = new Random();
            arr = new double[n];
            dataGridViewArray.RowCount = 2;
            dataGridViewArray.ColumnCount = n;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.NextDouble() * 100 % (53.3 + 15.6) - 15.6;
                arr[i] = Math.Round(arr[i], 1);
                dataGridViewArray[i, 0].Value = arr[i];
                dataGridViewArray[i, 1].Value = " ";
                dataGridViewArray.Columns[i].HeaderText = i.ToString();
            }
        }

        private void buttonRozv_Click(object sender, EventArgs e)
        {
            int k = 0;
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] * 10 % 10 >= 5 || arr[i] * 10 % 10 <= -5)
                {
                    sum = sum + Math.Abs(arr[i]);
                    k++;
                }
            }
            textBoxSum.Text = sum.ToString();
            double[] arr2 = new double[(int)numericUpDownCount.Value - k];
            k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] * 10 % 10 < 5 && arr[i] * 10 % 10 >= 0 || arr[i] * -10 % 10 < 5 && arr[i] * -10 % 10 >= 0)
                {
                    arr2[k] = arr[i];
                    k++;
                }
            }
            Array.Sort(arr2);
            Array.Reverse(arr2);
            for (int i = 0; i < arr2.Length; i++)
            {
                dataGridViewArray[i, 1].Value = arr2[i];
            }
        }
    }
}