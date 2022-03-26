using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 10;
            dataGridView1.ColumnCount = 10; 
            dataGridView2.RowCount = 10; 
            dataGridView2.ColumnCount = 10;
            int[,] B = new int[10, 10]; 
            int i, j,S=0;
            Random rand = new Random();
            for (i = 0; i < 10; i++)
                for (j = 0; j < 10; j++)
                    B[i, j] = rand.Next(-100, 100);
            for (i = 0; i < 10; i++)
                for (j = 0; j < 10; j++)
                    dataGridView1.Rows[i].Cells[j].Value = B[i, j].ToString();
            for (i = 0; i < 10; i++)
                S += B[i, i];
            textBox1.Text = Convert.ToString(S);
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    if (S > 10)
                        dataGridView2.Rows[i].Cells[j].Value = (B[i, j] + 13.5).ToString();
                    if (S <= 10)
                        dataGridView2.Rows[i].Cells[j].Value = (B[i, j]* B[i, j] -1.5).ToString();
                }
            }
        }

        
    }
}
