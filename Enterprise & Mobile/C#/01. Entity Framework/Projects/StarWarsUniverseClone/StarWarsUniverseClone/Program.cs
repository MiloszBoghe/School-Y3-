﻿using System;
using System.Globalization;
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
            var num = 1;
            foreach (var movie in movies)
            {
                Console.WriteLine("Episode " + num + " - " + movie.Title);
                Console.WriteLine("\tReleased: " + movie.ReleaseDate.ToString("dd/MM/yyyy"));
                num++;
            }

            Console.WriteLine("========================");
        }

    }

}