using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using MVDEMO.Models;

namespace MVDEMO.Controllers
{
    public class MoviesController : ApiController
    {
        private MovieDBContext db = new MovieDBContext();

        // GET: api/Movies
        public IQueryable<MovieDb> GetMovies()
        {
            return db.Movies;
        }

        // GET: api/Movies/5
        [ResponseType(typeof(MovieDb))]
        public async Task<IHttpActionResult> GetMovieDb(int id)
        {
            MovieDb movieDb = await db.Movies.FindAsync(id);
            if (movieDb == null)
            {
                return NotFound();
            }

            return Ok(movieDb);
        }

        // PUT: api/Movies/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutMovieDb(int id, MovieDb movieDb)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != movieDb.ID)
            {
                return BadRequest();
            }

            db.Entry(movieDb).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieDbExists(id))
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
        [ResponseType(typeof(MovieDb))]
        public async Task<IHttpActionResult> PostMovieDb(MovieDb movieDb)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Movies.Add(movieDb);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = movieDb.ID }, movieDb);
        }

        // DELETE: api/Movies/5
        [ResponseType(typeof(MovieDb))]
        public async Task<IHttpActionResult> DeleteMovieDb(int id)
        {
            MovieDb movieDb = await db.Movies.FindAsync(id);
            if (movieDb == null)
            {
                return NotFound();
            }

            db.Movies.Remove(movieDb);
            await db.SaveChangesAsync();

            return Ok(movieDb);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MovieDbExists(int id)
        {
            return db.Movies.Count(e => e.ID == id) > 0;
        }
    }
}