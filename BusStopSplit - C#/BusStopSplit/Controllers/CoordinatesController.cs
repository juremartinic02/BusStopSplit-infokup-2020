using BusStopSplit.Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Api kontroler

namespace BusStopSplit.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoordinatesController : ControllerBase
    {
        private readonly BusHub busHub;

        public CoordinatesController(BusHub busHub)
        {
            this.busHub = busHub;
        }

        [HttpGet]
        [Route("updateForBus")]
        public async Task<string> UpdateForBus(string busId, string lat, string lng) 
        {
            await busHub.SendMessage(busId, lat, lng);

            return "message";
        }
    }
}
