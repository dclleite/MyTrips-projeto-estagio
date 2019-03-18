using Microsoft.EntityFrameworkCore;
using MyTrips.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using static MyTrips.HostRepository;

namespace MyTrips
{
    class DataService : IDataService
    {
        private readonly ApplicationContext contexto;
        private readonly IHostRepository hostRepository;

        public DataService(ApplicationContext contexto, IHostRepository hostRepository)
        {
            this.contexto = contexto;
            this.hostRepository = hostRepository;
        }

        public void InicializaDB()
        {
            contexto.Database.Migrate();

            List<Hotel> hotel = GetHost();

            hostRepository.SaveHost(hotel);

        }



        private static List<Hotel> GetHost()
        {
            var Json = File.ReadAllText("trips.json");

            var hotel = JsonConvert.DeserializeObject<List<Hotel>>(Json);
            return hotel;
        }
    }

}
