using Microsoft.AspNetCore.SignalR;
using SignalRApi1.Models;
using SignalRApi1.Hubs;

namespace SignalRApi1.Hubs
{
    public class LocationHub : Hub<ILocationHub>
    {
        public async Task SendLocation(LocationCoordinates coordinates)
        {
            
            await Clients.All.SendAsync("ReceiveLocation", coordinates);
        }
    }
}
