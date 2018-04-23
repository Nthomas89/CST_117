using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_1
{
    class Inventory
    {
        // Inventory fields
        private string partName;
        private string partNumber;
        private int numberOfParts;

        // Item Name
        public string Name
        {
            get { return partName; }
            set { partName = value; }
        }

        // Item Number
        public string Number
        {
            get { return partNumber; }
            set { partNumber = value; }
        }

        // Item Quantity
        public int Quantity
        {
            get { return numberOfParts; }
        }


        //Constructor without arguments
        public Inventory(string name)
        {
            partName = " ";
            partNumber = " ";
            numberOfParts++;
        }

        //Constructor with arguments
        public Inventory(string partName, string partNumber, int Quantity)
        {
            this.partName = partName;
            this.partNumber = partNumber;
            numberOfParts++;
        }

        public Inventory(string name, string number, string quantity) : this(name)
        {
            Number = number;
        }
    }
}
