using CodeSharingDemo.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSharingDemo.Core.Repositories
{
    public class PersonRepository
    {
        public List<Person> GetAllPersons()
        {
            return new List<Person>()
            {
                new Person()
                {
                    FirstName = "Wesley",
                    LastName = "Hendrikx"
                },
                new Person()
                {
                    FirstName = "Kris",
                    LastName = "Hermans"
                }
            };
        }
    }
}
