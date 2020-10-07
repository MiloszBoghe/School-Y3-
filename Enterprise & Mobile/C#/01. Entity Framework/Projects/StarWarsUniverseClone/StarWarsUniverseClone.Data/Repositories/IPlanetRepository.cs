using System;
using System.Collections.Generic;
using System.Text;
using StarWarsUniverseClone.Domain;

namespace StarWarsUniverseClone.Data.Repositories
{
    public interface IPlanetRepository
    {
        IList<Planet> GetAllPlanets();
    }
}
