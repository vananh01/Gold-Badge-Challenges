using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Claims
{
    public class ProgramUI
    {
        private ClaimsRepository _repo = new ClaimsRepository();


        public void Run()
        {
            SeedContent();
            Menu();
        }
        
        private void SeedContent()
        {
            Claims claim1 = new Claims(1, ClaimTypes.Car, "Car accident on 465", 400.00d, new DateTime(2018, 4, 25), new DateTime(2018, 4, 27));
            Claims claim2 = new Claims(2, ClaimTypes.Home, "House fire in kitchen", 4000.00d, new DateTime(2018, 4, 11), new DateTime(2018, 4, 12));
            Claims claim3 = new Claims(3, ClaimTypes.Thef, "Stolen pancakes", 4.00d, new DateTime(2018, 4, 27), new DateTime(2018, 6, 1));
            _repo.AddNewClaim(claim1);
            _repo.AddNewClaim(claim2);
            _repo.AddNewClaim(claim3);
        }


        private bool Menu()
        {
            Console.WriteLine("What would you like to do \n" +
                "1. See All Claims \n" +
                "2. Take care of next claim \n" +
                "3. Enter a new claim \n" +
                "4. Exit");

            string input = Console.ReadLine();
            if (input == "1" || input == "one")
            {
                SeeAllClaims();
            }
            else if (input == "2" || input == "two")
            {
                TakeCareOfNextClaim();
            }
            else if (input == "3" || input == "three")
            {
                EnterNewClaim();
            }
            else if (input == "4" || input == "four")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Please select a valid option");
            }
            return true;
   
        }


        private void SeeAllClaims()
        {
            Console.Clear();
            Console.WriteLine("ClaimID   Type    Description       Amooint     DateOfAccident       Date of Claim      IsValid");
            foreach (Claims claims in _repo.GetClaims())
            {
                Console.WriteLine(claims);
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            Menu();
        }



        private void TakeCareOfNextClaim()
        {
            Console.Clear();
            var next = _repo.NextClaim();
            Console.WriteLine("Here are the details for the next claim to be handled:\n");
            Console.WriteLine($"ClaimID: {next.ClaimID} ");
            Console.WriteLine($"Type: {next.ClaimType} ");
            Console.WriteLine($"Description: {next.Description} ");
            Console.WriteLine($"ClaimAmount: {next.ClaimAmount} ");
            Console.WriteLine($"DateOfAccident: {next.DateOfIncident.ToString("MM/dd/yyyy")} ");
            Console.WriteLine($"DateOfClaim: {next.DateOfClaim.ToString("MM/dd/yyyy")}");
            Console.WriteLine($"IsValid: {next.IsValid}\n");
            Console.WriteLine("Do you want to deal with this claim now(y/n)?");
            string answer = Console.ReadLine();
            if (answer =="yes" || answer == "y")
            {
                _repo.DealWithClaim();
            }
            else
            {
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Menu();
            }
        }


        private void EnterNewClaim()
        {
            // try to figure out how to add new claim 
            Console.Clear();
            Console.WriteLine("Enter the claim id: ");
            int claimId = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the claim type: ");
            string claimType = Console.ReadLine();

            Console.WriteLine("Enter a claim description: ");
            string description = Console.ReadLine();

            Console.WriteLine("Amount of Damage: ");
            double claimAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Date Of Accident: ");
            DateTime dateOfIncident = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Date of Claim: ");
            DateTime dateOfClaim = Convert.ToDateTime(Console.ReadLine());
            try
            {
                ClaimTypes claim = ClaimTypes.Thef;
                if (claimType == "Thef" || claimType == "thef")
                {
                    claim = ClaimTypes.Thef;
                }
                else if (claimType == "Home" || claimType == "home")
                {
                    claim = ClaimTypes.Home;
                }
                else if (claimType == "Car" || claimType == "car")
                {
                    claim = ClaimTypes.Car;
                }
                Claims claims = new Claims(claimId, claimType, description, claimAmount, dateOfIncident, dateOfClaim);
               
            }
            catch
            {
                Console.WriteLine("Invalid input");
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Menu();


        }


    }
}
