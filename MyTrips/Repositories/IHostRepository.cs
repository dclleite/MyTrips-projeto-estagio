using MyTrips.Models;
using System.Collections.Generic;
using static MyTrips.HostRepository;

namespace MyTrips
{
    public interface IHostRepository
    {
        void SaveHost(List<Hotel> hotel);
        IList<Host> GetHotel();
        IList<City> GetCities();
    }
}