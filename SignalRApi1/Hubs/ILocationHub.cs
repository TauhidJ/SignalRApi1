using SignalRApi1.Models;

namespace SignalRApi1.Hubs
{
    public interface ILocationHub
    {
        Task SendAsync (string v, LocationCoordinates coordinates);
    }
}
