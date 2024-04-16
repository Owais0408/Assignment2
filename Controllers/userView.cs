using GBCTravel.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GBCTravel.Controllers
{
    public class userView : Controller
    {
        private readonly GBCTravelContext _context;

        public userView(GBCTravelContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> viewCars()
        {
            return View(await _context.Car.ToListAsync());
        }
        public async Task<IActionResult> carDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Car
                .FirstOrDefaultAsync(m => m.Id == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }
        public async Task<IActionResult> viewFlights()
        {
            return View(await _context.Flight.ToListAsync());
        }
        public async Task<IActionResult> flightDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flight = await _context.Flight
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flight == null)
            {
                return NotFound();
            }

            return View(flight);
        }

        public async Task<IActionResult> viewHotels()
        {
            return View(await _context.Hotel.ToListAsync());
        }
        public async Task<IActionResult> hotelDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotel = await _context.Hotel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hotel == null)
            {
                return NotFound();
            }

            return View(hotel);
        }





    }
}
