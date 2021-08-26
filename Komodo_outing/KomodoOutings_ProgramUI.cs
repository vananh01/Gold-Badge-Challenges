using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_outing
{
    public class ProgramUI
    {
        private KomodOuting_Repository _repo = new KomodOuting_Repository();

        public void Run()
        {
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
                "1. View list of all outings\n" +
                "2. Add outings to list\n" +
                "3. Calculation\n" +
                "4. Exit");

            string input = Console.ReadLine();
            if (input == "1" || input == "one")
            {
                ViewList();
            }

            else if (input == "2" || input == "two")
            {
                AddOutingsToList();
            }
            else if (input == "3" || input == "three")
            {
                Calculation();
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

        private void ViewList()
        {
            Console.Clear();
            foreach (Komodo_outings item in _repo.GetList())
            {
                Console.WriteLine($"Event Type: {item.EventType} \n" +
                    $"Number of people that attended: {item.NumOfPeople}\n" +
                    $"Date: {item.Date} \n" +
                    $"Total cost per person for the event: {item.CostPerPerson}\n" +
                    $"Total cost for the event: {item.TotalCost}");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            Choose();
        }

        private void AddOutingsToList()
        {
            // need to try to figure how to put enum in 
            Console.Clear();
            Console.WriteLine("Event Type: ");
            string eventType = Console.ReadLine();
  
            Console.WriteLine("Number of people that attended:");
            string numOfPeople = Console.ReadLine();

            Console.WriteLine("Date:");
            string date = Console.ReadLine();

            Console.WriteLine("Total cost per person for the event:");
            string costPerPerson = Console.ReadLine();

            Console.WriteLine("Total cost for the event:");
            string totalCost = Console.ReadLine();



            Komodo_outings newListAdd = new Komodo_outings(eventType, Convert.ToInt32(numOfPeople), Convert.ToDateTime(date), Convert.ToDouble(costPerPerson), Convert.ToDouble(totalCost));
            _repo.AddOutingToList(newListAdd);
            Choose();
        }

        private void Calculation()
        {


            Console.Clear();



        }
    }
}
