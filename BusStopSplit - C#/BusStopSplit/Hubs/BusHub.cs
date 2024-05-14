using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

// Kreiranje Hub-a za realtime komunikaciju

namespace BusStopSplit.Hubs
{
    public class BusHub : Hub
    {
        protected IHubContext<BusHub> _context;

        public BusHub(IHubContext<BusHub> context)
        {
            this._context = context;
        }

        public async Task SendMessage(string busId, string latitude, string longitude)
        {
            await this._context.Clients.All.SendAsync("ReceiveMessage", busId, latitude, longitude);
        }
    }
}
