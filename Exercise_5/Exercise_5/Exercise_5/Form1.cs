using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Calculate_Click(object sender, EventArgs e)
        {
            int numberTerms;

            if (int.TryParse(textBox1_InputTerms.Text, out numberTerms))
            {
                double pi = 4;

                if (numberTerms == 1)
                {
                    label2_Text.Text = "Approximate value of Pi after 1 term: ";
                }
                else if (numberTerms > 1 && numberTerms <= int.MaxValue)
                {
                    long denominator = 3;
                    bool addSubtract = false;

                    label2_Text.Text = "Approximate value of Pi after " + numberTerms.ToString() + " terms:";

                    for (int i = 2; i <= numberTerms; i++)
                    {
                        switch (addSubtract)
                        {
                            //subtraction
                            case false:
                                pi = pi - ((double)4 / denominator);
                                denominator += 2;
                                addSubtract = !addSubtract;
                                break;
                            //addition
                            case true:
                                pi = pi + ((double)4 / denominator);
                                denominator += 2;
                                addSubtract = !addSubtract;
                                break;

                        }
                    }
                }

                label2_Results.Text = pi.ToString();
            }
            else
            {
                //Parse has failed.
                MessageBox.Show("Invalid input, Please enter a number between 1 and " + int.MaxValue.ToString());
            }
        }
    }
}