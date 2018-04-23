using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Project_5
{
    public partial class Numbers : Form
    {
        public Numbers()
        {
            InitializeComponent();
        }

        private void button_Luck_Click(object sender, EventArgs e)
        {

            int number;

            if (int.TryParse(textBox_Year.Text, out number) && (number <= 2018))
            {
                Lucky_Numbers textNumbers = new Lucky_Numbers();

       

                Random rand = new Random();

                for (int i = 0; i < number; ++i)
                {
                    ListBox listBox1 = new ListBox();
                    textNumbers.Text = Convert.ToString(rand.Next(0, number));
                    textNumbers.Show();
                }
            }
            else
            {
                textBox_Year.Text = "";
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 }
