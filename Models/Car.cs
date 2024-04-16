using GBCTravel.Data;
using Microsoft.EntityFrameworkCore;

namespace GBCTravel.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public decimal DailyRate { get; set; }
        public bool IsAvailable { get; set; } = true;
        
    }

    
}
