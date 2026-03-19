using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar1
{
    public class Event
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public Event(DateTime date, string description)
        {
            Date = date;
            Description = description;
        }
    }

}
