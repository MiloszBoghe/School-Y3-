using NUnit.Framework;
using StarWarsUniverseClone.Data.Repositories.Db;

namespace StarWarsUniverseClone.Tests
{
    [TestFixture]
    public class MovieDbRepositoryTests : StarWarsDbTestBase
    {
        [Test]
        public void GetAllMoviesShouldReturnEveryMovie()
        {
            //Arrange
            var repo = new MovieDbRepository(Context);

            //Act
            var returnedMovies = repo.GetAllMovies();

            //Assert
            Assert.AreEqual(6, returnedMovies.Count);
        }
    }
}
