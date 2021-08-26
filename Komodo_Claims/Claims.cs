using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Claims
{
    public enum ClaimTypes { Car, Home, Thef}
    public class Claims
    {
        public int ClaimID { get; set; }
        public ClaimTypes ClaimType { get; set; }
        public string Description { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid
        {
            get
            {
                TimeSpan ifValid = DateOfClaim - DateOfIncident;
                if (ifValid.Days <= 30)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Claims() { }
        public Claims(int claimId, ClaimTypes claimType, string description, double claimAmount, DateTime dateOfIncident, DateTime dateOfClaim)
        {
            ClaimID = claimId;
            ClaimType = claimType;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;

        }

    }
}
