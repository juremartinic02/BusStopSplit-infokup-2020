using System;
using System.Collections.Generic;
using System.Text;

//Kod zadužen za buduće klasiranje autobusa i lakše razvrstavanje

namespace BusStopSplit.Core
{
    public class TimetableEntry
    {
        public int BusId { get; set; }
        public string WorkingDay { get; set; }
        public string Saturday { get; set; }
        public string Sunday { get; set; }
        public string Remarks { get; set; }
    }
}
