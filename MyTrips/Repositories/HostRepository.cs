using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyTrips.Models;
using Newtonsoft.Json;

namespace MyTrips
{
    public class HostRepository : IHostRepository
    {
        private readonly ApplicationContext contexto;

        public HostRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
        }

        public IList<Host> GetHotel()
        {
            return contexto.Set<Host>().ToList();
        }
        public IList<City> GetCities()
        {
            return contexto.Set<City>().ToList();
        }


        public void SaveHost(List<Hotel> hotel)
        {
            /*foreach (var place in hotel)
            {

                if (!contexto.Set<City>().Where(c => c.Id == place.city.id).Any())
                {
                    contexto.Set<City>().Add(new City(place.city.id, place.city.name));
                }

            }

            contexto.SaveChanges();
            */
            foreach (var place in hotel)
            {
                
                if (!contexto.Set<Host>().Where(c => c.hotelName == place.hotelName).Any())
                {
                    contexto.Set<Host>().Add(new Host(place.hotelName, place.thumb, place.stars, place.location, 
                        place.city.id,place.country, place.date, place.price, place.@class, place.guest));
                }
                
            }

            contexto.SaveChanges();
        }



        public class Cities
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class Hotel
        {
            public string hotelName { get; set; }
            public string thumb { get; set; }
            public int stars { get; set; }
            public string location { get; set; }
            public Cities city { get; set; }
            public string country { get; set; }
            public string date { get; set; }
            public decimal price { get; set; }
            public string @class { get; set; }
            public int guest { get; set; }
        }
    }


}
