using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    public class ProgramUI
    {
        private MenuRepository _repo = new MenuRepository();
        public void Run()
        {
            // ItemContent();
            while (Choose())
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }        

        public bool Choose()
        {
            Console.WriteLine("What would you like to do?\n" +
                "1. Create new menu item\n" +
                "2. Delete menu item\n" +
                "3. View menu items\n" +
                "4. Exit");

            string input = Console.ReadLine();
            if (input == "1" || input == "one") 
            {
                CreateMenuItem();
            }

            else if (input == "2" || input == "two") 
            {
                DeleteMenuItem();
            }
            else if (input == "3" || input == "three") 
            {
                ViewMenuItem();
            }
            else if (input == "4" || input == "four") 
            {
                return false;
            }
            else
            {
                Console.WriteLine("Please enter a valid option");
            }
            return true;
        }

        private void CreateMenuItem()
        {
            Console.Clear();

            Console.WriteLine("Meal Number: ");
            string mealNumber = Console.ReadLine();

            Console.WriteLine("Meal Name: ");
            string mealName = Console.ReadLine();

            Console.WriteLine("Description: ");
            string description = Console.ReadLine();

            Console.WriteLine("Ingredients: ");
            string ingredients = Console.ReadLine();

            Console.WriteLine("Price: ");
            string price = Console.ReadLine();

            Menu newMenuItem = new Menu(Convert.ToInt32(mealNumber), mealName, description, ingredients, Convert.ToDouble(price));
            _repo.AddMenuItem(newMenuItem);
            Choose();
        }
        
        
        private void DeleteMenuItem()
        {
            Console.Clear();
            
            Console.WriteLine("What item do you want to remove?");
            if (_repo.DeleteItem(int.Parse(Console.ReadLine())))
            {
                Console.WriteLine("The item deleteds");
            }
            else
            {
                Console.WriteLine("The item could not be deleted.");
            }
        }

        private void ViewMenuItem()
        {
            Console.Clear();
            foreach (Menu item in _repo.GetMenu())
            {
                Console.WriteLine($"Item number: {item.MealNumber}\n Item Name: {item.MealName}\n Description: {item.Description}\n Ingredients: {item.Ingredients}\n Price: {item.Price}\n\n\n");

            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            Choose();

        }

        /*public void ItemContent()
        {
            _repo.AddMenuItem(new Menu(1, "Pizza", "Best Pizza Ever", "Flour, pepperoni, cheese", 10.99d));
            _repo.AddMenuItem(new Menu(2, "Hamburger", "You should eat more hamburger", "ground beef, buns, cheese", 5.99d));
            _repo.AddMenuItem(new Menu(3, "Coffee", "Best coffee in Indiana", "coffee from Vietnam", 3.99d));
        }
        */
    }
}
