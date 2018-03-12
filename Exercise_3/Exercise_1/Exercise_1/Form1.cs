using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Convert_Click(object sender, EventArgs e)
        {

            double F;
            double I;
            double Result;

            F = double.Parse(inputBox.Text);
            I = 12.0;

            Result = F / I;

            resultBox.Text = Result.ToString();
           

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            inputBox.Text = "";
            resultBox.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
