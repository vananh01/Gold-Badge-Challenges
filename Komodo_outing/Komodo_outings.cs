using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_outing
{
    public enum EventTypes { Golf, Bowling, AmusementPark, Concert }
    public class Komodo_outings
    {
        
        public EventTypes EventType { get; set; }
        public int NumOfPeople { get; set; }
        public DateTime Date { get; set; }
        public double CostPerPerson { get; set; }
        public double TotalCost { get; set; }

        public Komodo_outings() { }
        public Komodo_outings(EventTypes eventType, int numOfPeople, DateTime date, double costPerPerson, double totalCost)
        {
           
            EventType = eventType;
            NumOfPeople = numOfPeople;
            Date = date;
            CostPerPerson = costPerPerson;
            TotalCost = totalCost; 
        }
    }
}
