using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarWarsUniverseClone.Domain
{
    public class Planet : Resource
    {
        public string Name { get; set; }
        // Note: RotationPeriod, OrbitalPeriod and Diameter
        // return "unknown" sometimes
        // longer fix (Todo) -> change JSON deserialisation to substitute "unknown" with -1

        [JsonProperty("rotation_period")]
        public int RotationPeriod { get; set; }
        [JsonProperty("orbital_period")]
        public int OrbitalPeriod { get; set; }
        public int Diameter { get; set; }
        public string Climate { get; set; }
        [JsonIgnore] 
        public List<MoviePlanet> MoviePlanets { get; set; } = new List<MoviePlanet>();
        [JsonProperty(PropertyName = "films")] 
        public List<string> MovieUris { get; set; }
    }
}
