using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StarWarsUniverseClone.Domain;

namespace StarWarsUniverseClone.Data.Repositories.Db
{
    public class MovieDbRepository : IMovieRepository
    {
        private readonly StarWarsContext _context;
        public MovieDbRepository(StarWarsContext context)
        {
            _context = context;
        }
        public IList<Movie> GetAllMovies()
        {
           return _context.Movies.ToList();
        }
    }
}
