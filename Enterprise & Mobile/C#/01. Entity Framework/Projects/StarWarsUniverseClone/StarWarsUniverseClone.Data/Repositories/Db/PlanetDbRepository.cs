using System.Collections.Generic;
using System.Linq;
using StarWarsUniverseClone.Domain;

namespace StarWarsUniverseClone.Data.Repositories.Db
{
    public class PlanetDbRepository
    {
        private readonly StarWarsContext _context;
        public PlanetDbRepository(StarWarsContext context)
        {
            _context = context;
        }
        public IList<Planet> GetAllPlanets()
        {
            return _context.Planets.ToList();
        }
    }
}
