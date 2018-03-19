using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_4
{
    public partial class Exercise_4 : Form
    {
        public Exercise_4()
        {
            InitializeComponent();
        }

        private void button1_Calculate_Click(object sender, EventArgs e)
        {
            int seconds;

            string text = textBox1_Number.Text;
            if (int.TryParse(text, out seconds))
            {
                //minutes
                if (seconds >= 60 || seconds < 3600)
                {
                    int minutes = seconds / 60;

                    //Test for grammatical considerations.
                    if (minutes == 1)
                    {
                        textBox2_DiplaySeconds.Text = minutes.ToString() + " minute.";
                    }
                    else
                    {
                        textBox2_DiplaySeconds.Text = minutes.ToString() + " minutes.";
                    }
                }
                //hours
                if (seconds >= 3600 || seconds < 86400)
                {
                    int hours = seconds / 3600;

                    if (hours == 1)
                    {
                        textBox3_DisplayHours.Text = hours.ToString() + " hour.";
                    }
                    else
                    {
                        textBox3_DisplayHours.Text = hours.ToString() + " hours.";
                    }

                }
                //days
                if (seconds >= 86400)
                {
                    int days = seconds / 86400;

                    if (days == 1)
                    {
                        textBox4_DisplayDays.Text = days.ToString() + " day";
                    }
                    else
                    {
                        textBox4_DisplayDays.Text = days.ToString() + " days";
                    }
                }
            }
        }
            private void MainForm_Load(object sender, EventArgs e)
            {

            }

        private void button2_Reset_Click(object sender, EventArgs e)
        {
            textBox1_Number.Text = "";
            textBox2_DiplaySeconds.Text = "";
            textBox3_DisplayHours.Text = "";
            textBox4_DisplayDays.Text = "";
        }
    }
}
