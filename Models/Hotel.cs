using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GBCTravel.Models
{
    public class Hotel
    {
        [Required]
        public int Id { get; set; }
        public int RoomNumber { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public float PricePerNight { get; set; }
        [Display(Name="Image Url")]
        public string? ImageUrl { get; set; }
        public bool status {  get; set; }

    }
}