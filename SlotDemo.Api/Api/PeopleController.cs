using SlotDemo.Data.Models;
using SlotDemo.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SlotDemo.Api.Api
{
    public class PeopleController : ApiController
    {
        public List<Person> Get()
        {
            return new PersonRepository().GetAll();
        }
    }
}
