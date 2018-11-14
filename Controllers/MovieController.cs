using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MOVIEInfoCURD.Models;

namespace MOVIEInfoCURD.Controllers
{
    public class MovieController : Controller
    {
        MovieDataaccessLayer objmovieDetails = new MovieDataaccessLayer();
        // GET: /<controller>/  
        public IActionResult Index()
        {
            List<Movies> lstMovieDetails = new List<Movies>();
            lstMovieDetails = objmovieDetails.GetAllMovieDetails().ToList();
            return View(lstMovieDetails);
        }
        //create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] Movies movieDetails)
        {
            if (ModelState.IsValid)
            {
                objmovieDetails.AddMovieDetails(movieDetails);
                return RedirectToAction("Index");
            }
            return View(movieDetails);
        }
        //Edit

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Movies movieDetails = objmovieDetails.GetMovieData(id);
            if (movieDetails == null)
            {
                return NotFound();
            }
            return View(movieDetails);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind]Movies EditMovieDetails)
        {
            if (id != EditMovieDetails.ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                objmovieDetails.UpdateMovieDetails(EditMovieDetails);
                return RedirectToAction("Index");
            }
            return View(EditMovieDetails);
        }
        //Details
        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Movies movieDetails = objmovieDetails.GetMovieData(id);
            if (movieDetails == null)
            {
                return NotFound();
            }
            return View(movieDetails);
        }
        //ActorDetails
        [HttpGet]
        public IActionResult ActorDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Actordetails actorDetails = objmovieDetails.GetActorDetails(id);
            if (actorDetails == null)
            {
                return NotFound();
            }
            return View(actorDetails);
        }
        //DirectorDetails
        [HttpGet]
        public IActionResult DirectorDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            DirectorDetails directorDetails = objmovieDetails.GetDirectorDetails(id);
            if (directorDetails == null)
            {
                return NotFound();
            }
            return View(directorDetails);
        }
        //Delete

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Movies deleteMovieDetails = objmovieDetails.GetMovieData(id);
            if (deleteMovieDetails == null)
            {
                return NotFound();
            }
            return View(deleteMovieDetails);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id)
        {
            objmovieDetails.DeleteMovie(id);
            return RedirectToAction("Index");
        }
    }
}