using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAccounting.Models
{
    public class CalendarRecord
    {
        public int Id { get; set; }
        public DateTime EventDate { get; set; }
        public string EventTime { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
