using NUnit.Framework;
using StarWarsUniverseClone.Data.Repositories.Api;

namespace StarWarsUniverseClone.Tests
{
    public class PlanetApiRepositoryTests
    {
        private PlanetApiRepository _repo;

        [SetUp]
        public void SetUp()
        {
            _repo = new PlanetApiRepository();
        }

    }
}
