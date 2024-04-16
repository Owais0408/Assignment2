using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GBCTravel.Data;
using GBCTravel.Models;
using Microsoft.Data.SqlClient;

namespace GBCTravel.Controllers
{
    public class CarsController : Controller
    {
        private readonly GBCTravelContext _context;

        public CarsController(GBCTravelContext context)
        {
            _context = context;
        }

        // GET: Cars
        public async Task<IActionResult> Index(string searchString, string sortOrder)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                return RedirectToAction(nameof(Search), new { searchString, sortOrder });
            }

            return View(await _context.Car.ToListAsync());

            //return View(await _context.Car.ToListAsync());
        }

        // GET: Cars/Details/5
        public async Task<IActionResult> Details(int? id)
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

        // GET: Cars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Brand,Model,Color,DailyRate,IsAvailable")] Car car)
        {
            if (ModelState.IsValid)
            {
                _context.Add(car);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(car);
        }

        // GET: Cars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Car.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }

        // POST: Cars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Brand,Model,Color,DailyRate,IsAvailable")] Car car)
        {
            if (id != car.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(car);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarExists(car.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(car);
        }

        // GET: Cars/Delete/5
        public async Task<IActionResult> Delete(int? id)
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

        // POST: Cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var car = await _context.Car.FindAsync(id);
            if (car != null)
            {
                _context.Car.Remove(car);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarExists(int id)
        {
            return _context.Car.Any(e => e.Id == id);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> carBooking(int id)
        {
            var car = await _context.Car.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }
            var booking = new Booking
            {

                bookingtype = "Car",
                BookingDate = DateOnly.FromDateTime(DateTime.Now),
                price = (double)car.DailyRate
            };

            await _context.AddAsync(booking);
            await _context.SaveChangesAsync();
            TempData["SuccessMessage"] = "Congratulation, you rented a car!";

            ViewData["Car"] = car;
            ViewData["BookingId"] = booking.Id;
            return View();

        }


        // GET: Cars/Search
        public async Task<IActionResult> Search(string searchString, string sortOrder)
        {
            ViewData["BrandSortParam"] = string.IsNullOrEmpty(sortOrder) ? "brand_desc" : "";
            ViewData["ModelSortParam"] = sortOrder == "Model" ? "model_desc" : "Model";
            ViewData["ColorSortParam"] = sortOrder == "Color" ? "color_desc" : "Color";
            ViewData["IsAvailableSortParam"] = sortOrder == "IsAvailable" ? "isAvailable_desc" : "IsAvailable";

            var cars = from c in _context.Car select c;

            if (!string.IsNullOrEmpty(searchString))
            {
                cars = cars.Where(c => c.Brand.Contains(searchString)
                                       || c.Model.Contains(searchString)
                                       || c.Color.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "brand_desc":
                    cars = cars.OrderByDescending(c => c.Brand);
                    break;
                case "Model":
                    cars = cars.OrderBy(c => c.Model);
                    break;
                case "model_desc":
                    cars = cars.OrderByDescending(c => c.Model);
                    break;
                case "Color":
                    cars = cars.OrderBy(c => c.Color);
                    break;
                case "color_desc":
                    cars = cars.OrderByDescending(c => c.Color);
                    break;
                case "IsAvailable":
                    cars = cars.OrderBy(c => c.IsAvailable);
                    break;
                case "isAvailable_desc":
                    cars = cars.OrderByDescending(c => c.IsAvailable);
                    break;
                default:
                    cars = cars.OrderBy(c => c.Brand);
                    break;
            }

            return View(await cars.ToListAsync());
        }

    }
}
