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
    public partial class Form1 : Form
    {
     

        public Form1()
        {
            InitializeComponent();
        }

        private void converter_Picture_Click(object sender, EventArgs e)
        {
            this.Hide();

            var newwindow = new converter();

            newwindow.Show();
        }

        private void transmission_Picture_Click(object sender, EventArgs e)
        {
            this.Hide();

            var newwindow = new transmission();

            newwindow.Show();
        }

        // close
        private void button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Inventory_Click(object sender, EventArgs e)
        {
            Inventory_Manager partsList = new Inventory_Manager();

            // add items
            //partsList.addItem(item1);
            //partsList.addItem(item2);
            //partsList.addItem(item3);

            // display updated list
            //Console.WriteLine("!Updated Inventory List!");
            //partsList.displayInventory();

            // remove items 
            //partsList.removeItem(item2);
            //partsList.removeItem(item3);

            // display updated list
            Console.WriteLine(" ");
            Console.WriteLine("!Updated Inventory List!");
            partsList.displayInventory();

            // restock items 
           // partsList.restockItem(item, 20);

            // display updated list
            Console.WriteLine(" ");
            Console.WriteLine("!Updated Inventory List!");
            partsList.displayInventory();
        }
    }
 }
