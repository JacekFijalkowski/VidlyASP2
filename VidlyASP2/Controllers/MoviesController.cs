﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyASP2.Models;
using VidlyASP2.ViewModels;
using System.Data.Entity;

namespace VidlyASP2.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();

            return View(movies);    
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies
                .Include(c => c.Genre  )
                .SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }


        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Save(MovieFormViewModel movieFormViewModel)
        {
            if (movieFormViewModel.Movie.Id==0)
            {
                _context.Movies.Add(movieFormViewModel.Movie);
            }
            else
            {
                var movieInDb = _context.Movies.FirstOrDefault(m => m.Id == movieFormViewModel.Movie.Id);
                movieInDb.Genre = movieFormViewModel.Movie.Genre;
                movieInDb.InStock = movieFormViewModel.Movie.InStock;
                movieInDb.Name = movieFormViewModel.Movie.Name;
                movieInDb.ReleaseDate = movieFormViewModel.Movie.ReleaseDate;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

        public ActionResult New()
        {
            var genres = _context.Genres.ToList();
            MovieFormViewModel viewModel = new MovieFormViewModel(){Genres = genres};
            return View(viewModel);
        }
        public ActionResult Edit(int id)
        {
            var genres = _context.Genres.ToList();
            var movie = _context.Movies.First(m => m.Id == id);
            var viewModel = new MovieFormViewModel(){Genres = genres, Movie = movie};
            return View(viewModel);
        }
    }
}