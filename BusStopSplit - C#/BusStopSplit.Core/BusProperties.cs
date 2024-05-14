using System;
using System.Collections.Generic;
using System.Text;

//Kod zadužen za buduće klasiranje autobusa i lakše razvrstavanje

namespace BusStopSplit.Core
{
    public class BusProperties
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BusNetwork Network { get; set; }
        public string Timetable { get; set; }
    }
}
