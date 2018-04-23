using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_1
{
    public partial class converter : Form
    {
        public converter()
        {
            InitializeComponent();
        }

        private void button_BKC_Click(object sender, EventArgs e)
        {
            this.Close();

            var newwindow = new Form1();

            newwindow.Show();
        }

        private void button_AddC_Click(object sender, EventArgs e)
        {
            //Initialize variables
             string name;
             string number;
             string Quantity;

            // Get variable from form
             name = textBox_NameC.Text;
             number = textBox_NumberC.Text;
             Quantity = textBox_QuantityC.Text;
             Inventory item = new Inventory(name, number, Quantity);
             MessageBox.Show(string.Format("The new Part added is {0}, {1}, and there are a total of {2} Parts",
                                          item.Name, item.Number, item.Quantity));
            // display items added in text box
           Display.Items.Add(textBox_NameC.Text);
           Display.Items.Add(textBox_NumberC.Text);
           Display.Items.Add(textBox_QuantityC.Text);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void button_Inventory_Click(object sender, EventArgs e)
        {

           Display.Items.Add(new Inventory("Pilot", "C115", 20));
           Display.Items.Add(new Inventory("Spline", "GM20", 20));
           Display.Items.Add(new Inventory("Oil Pan", "HPB 1380", 20));

        }

        private void button_Inventory_Load (object sender, EventArgs e)
        {

        }
    }
}
