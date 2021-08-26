using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoOuting
{
    public enum EventType { Golf, Bowling, AmusementPark, Concert }
    public class KomodoOuting
    { 
        public EventType Event { get; set; }
        public int NumberPeople { get; set; }
        public DateTime DateOfEvent { get; set; }
        public double CostPerPerson { get; set; }
        public double CostPerEvent { get; set; }


        public KomodoOuting() { }
        public KomodoOuting(EventType event, int numberPeople, DateTime dateOfEvent, double costPerPerson, double costPerEvent)
        {
            Event = event;
            
        }


    }

}
