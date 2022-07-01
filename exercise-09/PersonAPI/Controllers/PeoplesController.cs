using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeoplesController : ControllerBase
    {
        private List<Person> peoples;
        public PeoplesController(List<Person> peoples)
        {
            this.peoples = peoples;
        }

        public List<Person> Get()
        {
            System.Console.WriteLine("here");
            return peoples;
        }

        [HttpGet("bydate/{date:DateTime}")]
        public List<Person> Get(DateTime date)
        {
            return peoples.Where(x => x.DateOfBirth < date).ToList();
        }

        [HttpPost]
        public void Post(Person person)
        {
            if (person == null)
            {
                HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                return;
            }
            Console.WriteLine($"[POST] added new person ${person}");
            peoples.Add(person);
            HttpContext.Response.StatusCode = StatusCodes.Status201Created;
        }
    }
}
