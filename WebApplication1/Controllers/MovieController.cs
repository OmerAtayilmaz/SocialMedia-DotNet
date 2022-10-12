using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.Web.CodeGeneration;
using WebApplication1.Models;
using ILogger = Microsoft.VisualStudio.Web.CodeGeneration.ILogger;

namespace WebApplication1.Controllers
{
    public class MovieController:Controller
    {
        private readonly ILogger<HomeController> _logger;

        public MovieController(ILogger<HomeController> _logger)
        {
            this._logger = _logger;
        }

        public IActionResult movies()
        {
            Movie movie1 = new Movie(1,"Don't Look Up","image_path",4.7f,"Science");
            Movie movie2 = new Movie(2,"Never Give Up","image_path",3.7f,"Biography");
            Movie movie3 = new Movie(3,"Transporter","image_path",4.7f,"Horror");
            Movie movie4 = new Movie(4,"Exception","image_path",3.9f,"Science");
            Movie movie5 = new Movie(5,"Interceptor","image_path",5.0f,"Action");
            Movie movie6 = new Movie(6,"The Reality","image_path",4.4f,"Science");
            Movie movie7 = new Movie(7,"Interception","image_path",4.1f,"Action");
            List<Movie> movies = new List<Movie>();
            movies.Add(movie1);
            movies.Add(movie2);
            movies.Add(movie3);
            movies.Add(movie4);
            movies.Add(movie5);
            movies.Add(movie6);
            movies.Add(movie7);
            ViewData["movies"] = movies;
            return View("Movies");
        }


        public IActionResult details()
        {
            ViewData["movie"] = new Movie(1, "Don't Look Up", "image_path", 4.7f, "Science");
            return View("MovieDetail");
        }
        public JsonResult json()
        {
            Movie movie1 = new Movie(1,"Don't Look Up","image_path",4.7f,"Science");
            Movie movie2 = new Movie(2,"Never Give Up","image_path",3.7f,"Biography");
            Movie movie3 = new Movie(3,"Transporter","image_path",4.7f,"Horror");
            Movie movie4 = new Movie(4,"Exception","image_path",3.9f,"Science");
            Movie movie5 = new Movie(5,"Interceptor","image_path",5.0f,"Action");
            Movie movie6 = new Movie(6,"The Reality","image_path",4.4f,"Science");
            Movie movie7 = new Movie(7,"Interception","image_path",4.1f,"Action");
            List<Movie> movies = new List<Movie>();
            movies.Add(movie1);
            movies.Add(movie2);
            movies.Add(movie3);
            movies.Add(movie4);
            movies.Add(movie5);
            movies.Add(movie6);
            movies.Add(movie7);
            JsonResult result = Json(movies);
            return result;
        }

        [NonAction] // controller request vs. kabul etmez, sadece method gibi davranır.
        public void x()
        {
            
        }
    }
}