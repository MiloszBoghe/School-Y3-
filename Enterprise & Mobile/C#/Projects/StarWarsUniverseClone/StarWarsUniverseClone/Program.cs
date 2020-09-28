using System;
using StarWarsUniverseClone.Data;
using StarWarsUniverseClone.Data.Repositories.Db;
using StarWarsUniverseClone.Domain;

namespace StarWarsUniverseClone
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new StarWarsContext();
            var repo = new MovieDbRepository(context);
            var movies = repo.GetAllMovies();
            Console.WriteLine("=== Star Wars Movies ===");
            foreach (var movie in movies)
            {
                Console.WriteLine(movie.Title);
                Console.WriteLine(movie.ReleaseDate);
            }

            Console.WriteLine("========================");
        }
    }
}
