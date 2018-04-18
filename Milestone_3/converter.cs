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

            // Get variable from form
            name = textBox_NameC.Text;
            number = textBox_NumberC.Text;
            Inventory item = new Inventory(name, number);
            MessageBox.Show(string.Format("The new Part added is {0}, {1}, and there are a total of {2} Parts",
                                            item.Name, item.Number, item.Quantity));
        }
    }
}
