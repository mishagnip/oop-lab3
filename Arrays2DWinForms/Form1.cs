using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays2DWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[,] arr;

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }
        private void buttonGeneric_Click(object sender, EventArgs e)
        {
            int n = (int)numericUpDownCows.Value;
            int m = (int)numericUpDownRows.Value;
            Random rnd = new Random();
            arr = new double[n, m];
            dataGridViewMatrix.ColumnCount = m;
            dataGridViewMatrix.RowCount = n;
            for (int i = 0; i < arr.GetLength(1); i++)
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    arr[j, i] = rnd.NextDouble() * 100 % (12.951 + 28.305) - 28.305;
                    arr[j, i] = Math.Round(arr[j, i], 3);
                    dataGridViewMatrix[i, j].Value = arr[j, i];
                    dataGridViewMatrix.Rows[j].HeaderCell.Value = j.ToString();
                    dataGridViewMatrix.Columns[i].HeaderText = i.ToString();
                    dataGridViewMatrix.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
        }
        private void dataGridViewMin_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex > -1)
            {
                e.PaintBackground(e.CellBounds, true);
                using (SolidBrush br = new SolidBrush(Color.Black))
                {
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    e.Graphics.DrawString(e.RowIndex.ToString(),
                    e.CellStyle.Font, br, e.CellBounds, sf);
                }
                e.Handled = true;
            }
        }
        private void dataGridViewMatrix_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex > -1)
            {
                e.PaintBackground(e.CellBounds, true);
                using (SolidBrush br = new SolidBrush(Color.Black))
                {
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    e.Graphics.DrawString(e.RowIndex.ToString(),
                    e.CellStyle.Font, br, e.CellBounds, sf);
                }
                e.Handled = true;
            }
        }
        private void buttonRozv_Click(object sender, EventArgs e)
        {
            int l = 0;
            double min = 12.951, max = -28.305, buf;
            double[] minstr = new double[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    if (arr[i, j] < min)
                        min = arr[i, j];
                minstr[i] = min;
                min = 12.951;
                l = i+1;
            }
            dataGridViewMin.ColumnCount = l;
            dataGridViewMin.RowCount = 1;
            for (int i = 0; i < minstr.Length; i++)
            {
                dataGridViewMin[i,0].Value = minstr[i];
                if (minstr[i] > max)
                    max = minstr[i];
            }
            textBoxMax.Text = max.ToString();
            l = 0;
            for (int j = 0; j < arr.GetLength(0); j = j + 2)
            {
                for (int i = 0; i < arr.GetLength(1); i++)
                    if (arr[j, i] < 0)
                    {
                        buf = arr[j, i];
                        for (int k = i; k > l; k--)
                            arr[j, k] = arr[j, k-1];
                        arr[j, l] = buf;
                        l++;
                    }
                l = 0;
            }
            for (int i = 0; i < arr.GetLength(1); i++)
                for (int j = 0; j < arr.GetLength(0); j++)
                    dataGridViewMatrix[i, j].Value = arr[j, i];
        }
    }
}