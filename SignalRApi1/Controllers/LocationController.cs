using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalRApi1.Hubs;
using SignalRApi1.Models;

namespace SignalRApi1.Controllers
{
    [Route("api/location")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly IHubContext<LocationHub> _hubContext;
        public LocationController(IHubContext<LocationHub> hubContext)
        {
            _hubContext = hubContext;
        }



        [HttpPost]
        public async Task<IActionResult> PostLocation(LocationCoordinates coordinates)
        {
            await _hubContext.Clients.All.SendAsync("ReceiveLocation", coordinates);
            return Ok();
            
        }


    }
}
