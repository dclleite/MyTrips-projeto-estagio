using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using static MyTrips.HostRepository;

namespace MyTrips.Models
{
    [DataContract]
    public class BaseModel
    {
        [DataMember]
        public int Id { get; protected set; }
    }

    public class Host : BaseModel
    {
        public Host()
        {

        }

        [Required]
        public string hotelName { get; private set; }
        [Required]
        public string thumb { get; private set; }
        [Required]
        public int stars { get; private set; }
        [Required]
        public string location { get; private set; }
        [ForeignKey("City")]
        public int cityId { get;private set; }
        [Required]
        public City city { get;private set; }
        [Required]
        public string country { get; private set; }
        [Required]
        public string date { get; private set; }
        [Required]
        public decimal price { get; private set; }
        [Required]
        public string @class { get; private set; }
        [Required]
        public int guest { get; private set; }

        public Host(string hotelName, string thumb, int stars, string location, int cityId, string country, string date, decimal price, string @class, int guest)
        {
            this.hotelName = hotelName;
            this.thumb = thumb;
            this.stars = stars;
            this.location = location;
            this.cityId = cityId;
            this.country = country;
            this.date = date;
            this.price = price;
            this.@class = @class;
            this.guest = guest;
        }




    }

    public class City : BaseModel
    {
        public City()
        {
        }

        public City(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        [Required]
        public string name { get; set; }


    }

    public class HotelEscolhido : BaseModel
    {
        public Hotel chosenHosting { get; private set; }

        public HotelEscolhido()
        {

        }

        public HotelEscolhido(Hotel chosenHosting)
        {
            this.chosenHosting = chosenHosting;
        }
    }

}
