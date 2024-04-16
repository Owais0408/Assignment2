using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GBCTravel.Models
{
    public class Flight
    {
        [Required]
        public int Id { get; set; }
        public string Airline { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }

        [DataType(DataType.Date)]
        public DateTime DepartureTime { get; set; }
        [DataType(DataType.Date)]
        public DateTime ArrivalTime { get; set; }
        public decimal Price { get; set; }
    }
}
