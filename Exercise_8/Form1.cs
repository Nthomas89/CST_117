using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // methods being used

            private double fatCalories (double fatGrams)
        {
            return fatGrams * 9;
        }

            private double carbsCalories (double carbsGrams)
        {
            return carbsGrams * 4;
        }

        private void button_Calculate_Click(object sender, EventArgs e)
        {
            // variables
            double fatGrams, carbGrams, caloriesFat, caloriesCarbs;

            // fat grams
            if (double.TryParse(fatInputBox.Text, out fatGrams))
            {
                // calculate calories in fat
                caloriesFat = fatGrams * 9;

                // display
                calFatBox.Text = caloriesFat.ToString("n1");
            }
            else
            {
                // error
                MessageBox.Show("Please enter a valid number for measurement");
            }

            // Carbohydrate grams
            if (double.TryParse(carbsInputBox.Text, out carbGrams))
            {
                // calculate calories in fat
                caloriesCarbs = carbGrams * 4;

                // display
                calCarbsBox.Text = caloriesCarbs.ToString("n1");
            }
            else
            {
                // error
                MessageBox.Show("Please enter a valid number for measurement");
            }

        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            // cler boxes
            fatInputBox.Text = "";
            carbsInputBox.Text = "";
            calFatBox.Text = "";
            calCarbsBox.Text = "";
        }
    }
}
