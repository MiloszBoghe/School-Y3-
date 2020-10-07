using CodeSharingDemo.Core.Models;
using CodeSharingDemo.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSharingDemo.Core.Services
{
    public class PersonService
    {
        public List<Person> GetAllPersons()
        {
            var repo = new PersonRepository();
            return repo.GetAllPersons();
        }
    }
}
