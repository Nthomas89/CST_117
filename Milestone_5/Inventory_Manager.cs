using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_1
{
    class Inventory_Manager
    {
        // Initilize inventoryManagerList
        List<Inventory> inventoryManagerList = new List<Inventory>();

        public Inventory_Manager()
        {

            inventoryManagerList.Add(new Inventory("Pilot", "C115", 20));
            inventoryManagerList.Add(new Inventory("Spline", "GM20", 20));
            inventoryManagerList.Add(new Inventory("Oil Pan", "HPB 1380", 20));

        }
        // add item method
        public void addItem(Inventory item)
        {
            this.inventoryManagerList.Add(item);
        } 
    
        // remove item method
        public void removeItem(Inventory item)
        {
            this.inventoryManagerList.Remove(item);
        }

        // restock item method
        public void restockItem(Inventory item, int quantity)
        {
            int index = 0;
            // loop
            if (quantity > 0)
            {
                // while loop to add the number of items
                while (index < quantity)
                {
                    this.inventoryManagerList.Add(item);
                    index++;
                } 
            } 
        }

        public void displayInventory()
        {
            // cycle list
            foreach (Inventory product in this.inventoryManagerList)
            {
               Console.WriteLine("Name = " + product.Name + ", Quantity = " + product.Quantity);

            } 
        }

        //Method to search for by item name
        public List<int> searchName(string objectName)
        {
            List<int> itemPosition = new List<int>();

            foreach (Inventory item in this.inventoryManagerList)

            {
                
                if (String.Equals(item.Name, objectName, StringComparison.OrdinalIgnoreCase))
                {
                 
                    itemPosition.Add(this.inventoryManagerList.IndexOf(item));
                }
            }
            return itemPosition;
        } 
      } 
   }
