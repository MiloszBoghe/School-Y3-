using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using StarWarsUniverseClone.Data.Repositories.Api;

namespace StarWarsUniverseClone.Tests
{
    [TestFixture]
    public class MovieApiRepositoryTests
    {
        private MovieApiRepository _repo;

        [SetUp]
        public void SetUp()
        {
            _repo = new MovieApiRepository();
        }

        [Test]
        public void GetAllMovies()
        {
            //Act
            var movies = _repo.GetAllMovies();
            
            //Assert
            Assert.AreEqual(6,movies.Count);
        }
    }
}
