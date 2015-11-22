using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using MVDEMO.Models;

namespace MVDEMO.Controllers
{
    public class MoviesController : ApiController
    {
        public ApplicationDbContext db = new ApplicationDbContext();
        
        // GET: api/Movies
        public IQueryable<Movies> GetMovies()
        {
            return db.Movies;
        }

        // GET: api/Movies/5
        [ResponseType(typeof(Movies))]
        public async Task<IHttpActionResult> GetMovies(int id)
        {
            Movies movies = await db.Movies.FindAsync(id);
            if (movies == null)
            {
                return NotFound();
            }

            return Ok(movies);
        }

        // PUT: api/Movies/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutMovies(int id, Movies movies)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != movies.ID)
            {
                return BadRequest();
            }

            db.Entry(movies).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MoviesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Movies
        [ResponseType(typeof(Movies))]
        public async Task<IHttpActionResult> PostMovies(Movies movies)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Movies.Add(movies);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = movies.ID }, movies);
        }

        // DELETE: api/Movies/5
        [ResponseType(typeof(Movies))]
        public async Task<IHttpActionResult> DeleteMovies(int id)
        {
            Movies movies = await db.Movies.FindAsync(id);
            if (movies == null)
            {
                return NotFound();
            }

            db.Movies.Remove(movies);
            await db.SaveChangesAsync();

            return Ok(movies);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MoviesExists(int id)
        {
           return db.Movies.Count(e => e.ID == id) > 0;
        }
    }
}