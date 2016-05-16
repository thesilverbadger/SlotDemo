using SlotDemo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotDemo.Data.Repositories
{
    public class PersonRepository
    {
        public List<Person> GetAll()
        {
            return new List<Person>()
            {
                new Person()
                {
                    PersonId = 1,
                    Firstname = "Joe",
                    Lastname = "Bloggs"
                },
                new Person()
                {
                    PersonId = 2,
                    Firstname = "Joanne",
                    Lastname = "Smith"
                }
            };
        }
    }
}
