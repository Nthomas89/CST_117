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
    public partial class transmission : Form
    {
        public transmission()
        {
            InitializeComponent();
        }

        private void button_BKT_Click(object sender, EventArgs e)
        {
            this.Close();

            var newwindow = new Form1();

            newwindow.Show();
        }

        private void button_AddT_Click(object sender, EventArgs e)
        {
            //Initialize variables
            string name;
            string number;
            string Quantity;

            // Get variable from form
            name = textBox_NameT.Text;
            number = textBox_NumberT.Text;
            Quantity = textBox_QuantityT.Text;
            Inventory item = new Inventory(name, number, Quantity);
            MessageBox.Show(string.Format("The new Part added is {0}, {1}, and there are a total of {2} Parts",
                                            item.Name, item.Number, item.Quantity));
            // dislay items added in text box
            Display.Items.Add(textBox_NameT.Text);
            Display.Items.Add(textBox_NumberT.Text);
            Display.Items.Add(textBox_QuantityT.Text);

        }

        private void Display_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Inventory_Click(object sender, EventArgs e)
        {
            Display.Items.Add(new Inventory("Pilot", "C115", 20));
            Display.Items.Add(new Inventory("Spline", "GM20", 20));
            Display.Items.Add(new Inventory("Oil Pan", "HPB 1380", 20));
        }
    }
}
