using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GBCTravel.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace GBCTravel.Data
{
    public class GBCTravelContext : IdentityDbContext<IdentityUser>
    {
        public GBCTravelContext (DbContextOptions<GBCTravelContext> options)
            : base(options)
        {

        }

        public DbSet<GBCTravel.Models.Booking> Booking { get; set; } = default;
        public DbSet<GBCTravel.Models.Flight> Flight { get; set; }
        public DbSet<GBCTravel.Models.Car> Car { get; set; }

        public DbSet<GBCTravel.Models.Hotel> Hotel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Booking>().HasData(
                new Booking
                {
                    Id = 1,
                    BookingDate = DateOnly.FromDateTime(DateTime.Now),
                    price = 20,
                    bookingtype = "Car"
                }
                );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Royal Orchid Palace",
                    Location = "Thailand",
                    PricePerNight = 1800.00F,
                    ImageUrl = "https://tse4.mm.bing.net/th?id=OIP.hE1EAKib61djIy0oT6p1pwHaEo&pid=Api&P=0&h=180",
                    status = true
                },
    new Hotel
    {
        Id = 2,
        Name = "Paradise Resort",
        Location = "Maldives",
        PricePerNight = 2500.00F,
        ImageUrl = "https://tse2.mm.bing.net/th?id=OIP.nY9p3m9fkYlaNAGErx02EQHaEx&pid=Api&P=0&h=180",
        status = true
    },
    new Hotel
    {
        Id = 3,
        Name = "Sunset View Hotel",
        Location = "Bali",
        PricePerNight = 2000.00F,
        ImageUrl = "https://tse2.mm.bing.net/th?id=OIP.4rlEynHtw33lqN3HwWHe0QAAAA&pid=Api&P=0&h=180",
        status = true
    },
    new Hotel
    {
        Id = 4,
        Name = "Grand Mirage",
        Location = "Dubai",
        PricePerNight = 3000.00F,
        ImageUrl = "https://tse4.mm.bing.net/th?id=OIP.GWsjuIpVJdRUZPMQsMcFcQHaE8&pid=Api&P=0&h=180",
        status = true
    },
    new Hotel
    {
        Id = 5,
        Name = "Oceanfront Suites",
        Location = "Hawaii",
        PricePerNight = 2800.00F,
        ImageUrl = "https://tse4.mm.bing.net/th?id=OIP.HkxrmC__Yr2oPED3RPHJkwHaEN&pid=Api&P=0&h=180",
        status = true
    },
    new Hotel
    {
        Id = 6,
        Name = "Mountain Vista Inn",
        Location = "Switzerland",
        PricePerNight = 2200.00F,
        ImageUrl = "https://tse4.mm.bing.net/th?id=OIP.AQFl8i6B-Y9iBWIIaSk9uAHaE7&pid=Api&P=0&h=180",
        status = true
    },
    new Hotel
    {
        Id = 7,
        Name = "Coral Sands Resort",
        Location = "Australia",
        PricePerNight = 1900.00F,
        ImageUrl = "https://tse2.mm.bing.net/th?id=OIP.9JFne8p7tuUYC5qk2EUhcgHaEK&pid=Api&P=0&h=180",
        status = true
    },
    new Hotel
    {
        Id = 8,
        Name = "Riverfront Retreat",
        Location = "Canada",
        PricePerNight = 2100.00F,
        ImageUrl = "https://tse4.mm.bing.net/th?id=OIP.AiVqKkzPME1Noqt1GhdmSwHaE8&pid=Api&P=0&h=180",
        status = true
    },
    new Hotel
    {
        Id = 9,
        Name = "Cozy Cabin Lodge",
        Location = "Norway",
        PricePerNight = 2300.00F,
        ImageUrl = "https://tse2.mm.bing.net/th?id=OIP.Ryamq96jtDOKId2Zit8kOAHaE7&pid=Api&P=0&h=180",
        status = true
    },
    new Hotel
    {
        Id = 10,
        Name = "Sapphire Shores Hotel",
        Location = "Greece",
        PricePerNight = 2600.00F,
        ImageUrl = "https://tse1.mm.bing.net/th?id=OIP.C8vkMkOyrfmnMcDY6SZTbgHaEP&pid=Api&P=0&h=180",
        status = true
    },
    new Hotel
    {
        Id = 11,
        Name = "Silver Lagoon Resort",
        Location = "Fiji",
        PricePerNight = 2700.00F,
        ImageUrl = "https://tse4.mm.bing.net/th?id=OIP.nizjMP3ZtJd3SKjsopQnZgHaEo&pid=Api&P=0&h=180",
        status = true
    },
    new Hotel
    {
        Id = 12,
        Name = "Emerald Bay Hotel",
        Location = "Jamaica",
        PricePerNight = 2400.00F,
        ImageUrl = "https://tse2.mm.bing.net/th?id=OIP.jmrYqoE15FukY39kaMSPRAHaE8&pid=Api&P=0&h=180",
        status = true
    },
    new Hotel
    {
        Id = 13,
        Name = "Golden Sands Inn",
        Location = "Bahamas",
        PricePerNight = 3200.00F,
        ImageUrl = "https://tse3.mm.bing.net/th?id=OIP.takzeirYv2xe0_zF4cT9HwHaD7&pid=Api&P=0&h=180",
        status = true
    },
    new Hotel
    {
        Id = 14,
        Name = "Platinum Heights",
        Location = "Monaco",
        PricePerNight = 2900.00F,
        ImageUrl = "https://tse2.mm.bing.net/th?id=OIP.JCegYJ7Bsc6G6x6V7Ua52wHaE6&pid=Api&P=0&h=180",
        status = true
    },
    new Hotel
    {
        Id = 15,
        Name = "Diamond Crest Resort",
        Location = "Barbados",
        PricePerNight = 3100.00F,
        ImageUrl = "https://tse4.mm.bing.net/th?id=OIP.siWf5qBoGWFQH_gNmvjaOAAAAA&pid=Api&P=0&h=180",
        status = true
    }

                );
            modelBuilder.Entity<Flight>().HasData(
                new Flight { Id = 1, Airline = "Emirates", Origin = "DXB", Destination = "JFK", DepartureTime = DateTime.Now, ArrivalTime = DateTime.Now.AddHours(14), Price = 800.00m },
    new Flight { Id = 2, Airline = "British Airways", Origin = "LHR", Destination = "SFO", DepartureTime = DateTime.Now.AddDays(1), ArrivalTime = DateTime.Now.AddDays(1).AddHours(11), Price = 900.00m },
    new Flight { Id = 3, Airline = "American Airlines", Origin = "JFK", Destination = "ORD", DepartureTime = DateTime.Now.AddDays(2), ArrivalTime = DateTime.Now.AddDays(2).AddHours(3), Price = 300.00m },
    new Flight { Id = 4, Airline = "Qantas", Origin = "SYD", Destination = "LAX", DepartureTime = DateTime.Now.AddDays(3), ArrivalTime = DateTime.Now.AddDays(3).AddHours(13), Price = 1000.00m },
    new Flight { Id = 5, Airline = "Air Canada", Origin = "YYZ", Destination = "LHR", DepartureTime = DateTime.Now.AddDays(4), ArrivalTime = DateTime.Now.AddDays(4).AddHours(7), Price = 700.00m },
    new Flight { Id = 6, Airline = "Lufthansa", Origin = "FRA", Destination = "JFK", DepartureTime = DateTime.Now.AddDays(5), ArrivalTime = DateTime.Now.AddDays(5).AddHours(9), Price = 850.00m },
    new Flight { Id = 7, Airline = "Singapore Airlines", Origin = "SIN", Destination = "HKG", DepartureTime = DateTime.Now.AddDays(6), ArrivalTime = DateTime.Now.AddDays(6).AddHours(4), Price = 400.00m },
    new Flight { Id = 8, Airline = "Cathay Pacific", Origin = "HKG", Destination = "LAX", DepartureTime = DateTime.Now.AddDays(7), ArrivalTime = DateTime.Now.AddDays(7).AddHours(12), Price = 950.00m },
    new Flight { Id = 9, Airline = "United Airlines", Origin = "ORD", Destination = "SFO", DepartureTime = DateTime.Now.AddDays(8), ArrivalTime = DateTime.Now.AddDays(8).AddHours(5), Price = 600.00m },
    new Flight { Id = 10, Airline = "Delta Air Lines", Origin = "ATL", Destination = "LGA", DepartureTime = DateTime.Now.AddDays(9), ArrivalTime = DateTime.Now.AddDays(9).AddHours(2), Price = 250.00m },
    new Flight { Id = 11, Airline = "Southwest Airlines", Origin = "DAL", Destination = "HOU", DepartureTime = DateTime.Now.AddDays(10), ArrivalTime = DateTime.Now.AddDays(10).AddHours(1), Price = 150.00m },
    new Flight { Id = 12, Airline = "Air France", Origin = "CDG", Destination = "LAX", DepartureTime = DateTime.Now.AddDays(11), ArrivalTime = DateTime.Now.AddDays(11).AddHours(11), Price = 900.00m },
    new Flight { Id = 13, Airline = "KLM Royal Dutch Airlines", Origin = "AMS", Destination = "JFK", DepartureTime = DateTime.Now.AddDays(12), ArrivalTime = DateTime.Now.AddDays(12).AddHours(8), Price = 800.00m },
    new Flight { Id = 14, Airline = "Qatar Airways", Origin = "DOH", Destination = "LHR", DepartureTime = DateTime.Now.AddDays(13), ArrivalTime = DateTime.Now.AddDays(13).AddHours(7), Price = 700.00m },
    new Flight { Id = 15, Airline = "Virgin Atlantic", Origin = "LHR", Destination = "JFK", DepartureTime = DateTime.Now.AddDays(14), ArrivalTime = DateTime.Now.AddDays(14).AddHours(8), Price = 850.00m },
    new Flight { Id = 16, Airline = "Turkish Airlines", Origin = "IST", Destination = "SFO", DepartureTime = DateTime.Now.AddDays(15), ArrivalTime = DateTime.Now.AddDays(15).AddHours(13), Price = 950.00m },
    new Flight { Id = 17, Airline = "Swiss International Air Lines", Origin = "ZRH", Destination = "ORD", DepartureTime = DateTime.Now.AddDays(16), ArrivalTime = DateTime.Now.AddDays(16).AddHours(10), Price = 750.00m },
    new Flight { Id = 18, Airline = "Etihad Airways", Origin = "AUH", Destination = "LAX", DepartureTime = DateTime.Now.AddDays(17), ArrivalTime = DateTime.Now.AddDays(17).AddHours(15), Price = 1100.00m },
    new Flight { Id = 19, Airline = "Finnair", Origin = "HEL", Destination = "JFK", DepartureTime = DateTime.Now.AddDays(18), ArrivalTime = DateTime.Now.AddDays(18).AddHours(9), Price = 800.00m },
    new Flight { Id = 20, Airline = "Aeroflot", Origin = "SVO", Destination = "LAX", DepartureTime = DateTime.Now.AddDays(19), ArrivalTime = DateTime.Now.AddDays(19).AddHours(12), Price = 1000.00m }



                );
            modelBuilder.Entity<Car>().HasData(
                new Car { Id = 1, Brand = "Toyota", Model = "Corolla", Color = "Blue", DailyRate = 50, IsAvailable = true },
    new Car { Id = 2, Brand = "Honda", Model = "Civic", Color = "Black", DailyRate = 60, IsAvailable = true },
    new Car { Id = 3, Brand = "Ford", Model = "Focus", Color = "White", DailyRate = 55, IsAvailable = false },
    new Car { Id = 4, Brand = "Chevrolet", Model = "Malibu", Color = "Silver", DailyRate = 45, IsAvailable = true },
    new Car { Id = 5, Brand = "Nissan", Model = "Altima", Color = "Red", DailyRate = 48, IsAvailable = true },
    new Car { Id = 6, Brand = "BMW", Model = "3 Series", Color = "Gray", DailyRate = 70, IsAvailable = true },
    new Car { Id = 7, Brand = "Mercedes-Benz", Model = "C-Class", Color = "Black", DailyRate = 80, IsAvailable = false },
    new Car { Id = 8, Brand = "Audi", Model = "A4", Color = "White", DailyRate = 75, IsAvailable = true },
    new Car { Id = 9, Brand = "Volkswagen", Model = "Jetta", Color = "Blue", DailyRate = 52, IsAvailable = true },
    new Car { Id = 10, Brand = "Hyundai", Model = "Elantra", Color = "Silver", DailyRate = 47, IsAvailable = true },
    new Car { Id = 11, Brand = "Kia", Model = "Forte", Color = "White", DailyRate = 53, IsAvailable = true },
    new Car { Id = 12, Brand = "Subaru", Model = "Legacy", Color = "Blue", DailyRate = 55, IsAvailable = false },
    new Car { Id = 13, Brand = "Mazda", Model = "Mazda3", Color = "Red", DailyRate = 49, IsAvailable = true },
    new Car { Id = 14, Brand = "Lexus", Model = "IS", Color = "Black", DailyRate = 85, IsAvailable = true },
    new Car { Id = 15, Brand = "Infiniti", Model = "Q60", Color = "Gray", DailyRate = 78, IsAvailable = true },
    new Car { Id = 16, Brand = "Tesla", Model = "Model 3", Color = "White", DailyRate = 90, IsAvailable = true },
    new Car { Id = 17, Brand = "Porsche", Model = "911", Color = "Red", DailyRate = 150, IsAvailable = true },
    new Car { Id = 18, Brand = "Jaguar", Model = "XE", Color = "Blue", DailyRate = 120, IsAvailable = true },
    new Car { Id = 19, Brand = "Land Rover", Model = "Discovery", Color = "Green", DailyRate = 110, IsAvailable = true },
    new Car { Id = 20, Brand = "Volvo", Model = "S60", Color = "Silver", DailyRate = 65, IsAvailable = true },
    new Car { Id = 21, Brand = "Jeep", Model = "Wrangler", Color = "Yellow", DailyRate = 80, IsAvailable = true },
    new Car { Id = 22, Brand = "Toyota", Model = "Rav4", Color = "Black", DailyRate = 55, IsAvailable = false },
    new Car { Id = 23, Brand = "Ford", Model = "Edge", Color = "White", DailyRate = 58, IsAvailable = true },
    new Car { Id = 24, Brand = "Honda", Model = "HR-V", Color = "Silver", DailyRate = 63, IsAvailable = true },
    new Car { Id = 25, Brand = "Chevrolet", Model = "Trax", Color = "Black", DailyRate = 70, IsAvailable = true },
    new Car { Id = 26, Brand = "Subaru", Model = "Crosstrek", Color = "Green", DailyRate = 80, IsAvailable = true },
    new Car { Id = 27, Brand = "Mazda", Model = "CX-3", Color = "Blue", DailyRate = 68, IsAvailable = true },
    new Car { Id = 28, Brand = "Toyota", Model = "Tacoma", Color = "Red", DailyRate = 72, IsAvailable = true },
    new Car { Id = 29, Brand = "Ford", Model = "Expedition", Color = "Gray", DailyRate = 66, IsAvailable = true },
    new Car { Id = 30, Brand = "Hyundai", Model = "Tucson", Color = "Silver", DailyRate = 58, IsAvailable = true }
    );


        }

    }
}
