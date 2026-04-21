//Grading ID: S2419
//Program 4
//Due Date: 04/16/2024
//CIS-150-199
//Description: This program will output information of menu items before changes and after changes.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuItem item1 = new MenuItem("Tres Tacos de Chorizo", 8.99, 520, 10, 50, true); //Instantiating new objects of menu items
            MenuItem item2 = new MenuItem("Beef Bulgogi", 15.99, 413, 12, 35, false);
            MenuItem item3 = new MenuItem("Japanese Karaage", 10.99, 470, 9, 40, true);
            MenuItem item4 = new MenuItem("Chicken Parmesean", 14.99, 515, 13, 30, true);
            MenuItem item5 = new MenuItem("Chicken Tikka Masala", 14.99, 480, 14, 35, false);
            MenuItem[] items = { item1, item2, item3, item4, item5 }; //Array of menu item objects
            Console.WriteLine("      Current Menu");
            Console.WriteLine("---------------------------\n");
            DisplayMenu(items);                                     // calling method to display unchanged menu
            item1.Price = 12.99;                                    // Changes made to the menu
            item2.Calories = 500;
            item3.PrepTime = 12;
            item4.TotalSales = 44;
            item5.Availability = true;
            item4.Availability = false;
            Console.WriteLine("       Edited Menu");
            Console.WriteLine("---------------------------\n");
            DisplayMenu(items);                                     // Calling method to display changed menu
        }
        public static void DisplayMenu(MenuItem[] items)            //Method that displays menu
        {

            foreach (MenuItem item in items) //foreach loop that outputs array of object's info
            {
                Console.Write(item.ToString()); //Printing the menu with overridded ToString() method
            }
        }
    }
}
