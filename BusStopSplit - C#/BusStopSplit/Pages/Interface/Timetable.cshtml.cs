using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusStopSplit.Core;
using BusStopSplit.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BusStopSplit.Pages.Interface
{
    public class TimetableModel : PageModel
    {
        private readonly ITimetableData timetableData;

        public TimetableModel(ITimetableData timetableData)
        {
            this.timetableData = timetableData;
        }

        public IActionResult OnGet(int id)
        {
            this.BusId = id;
            this.Entries = timetableData.GetForBus(id);

            return Page();
        }

        public int BusId { get; set; }
        public IEnumerable<TimetableEntry> Entries { get; set; }
    }
}

