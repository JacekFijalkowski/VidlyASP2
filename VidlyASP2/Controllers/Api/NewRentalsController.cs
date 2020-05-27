using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VidlyASP2.Dtos;
using VidlyASP2.Models;

namespace VidlyASP2.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;
        
        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }



        [HttpPost]
        public IHttpActionResult CreateNewRental(NewRentalDto newRentalDto)
        {
            var customer = _context.Customers.Single(c=>c.Id == newRentalDto.CustomerId);

            var movies = _context.Movies.Where(m=>newRentalDto.MovieIds.Contains(m.Id));

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                {
                    return BadRequest("Movie is not available.");
                }

                _context.Rentals.Add(new Rental(){
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now,
                });

                movie.NumberAvailable--;

            }
            _context.SaveChanges();

            return Ok();
        }

    }
}
