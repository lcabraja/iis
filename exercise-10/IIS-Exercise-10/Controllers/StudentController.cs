using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IIS_Exercise_10
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private List<Student> students;
        public StudentController(List<Student> students)
        {
            this.students = students;
        }

        [HttpGet]
        public List<Student> Get()
        {
            return students;
        }

        [HttpPost]
        public void Post(Student person)
        {
            if (person == null)
            {
                HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                return;
            }
            Console.WriteLine($"[POST] added new person ${person}");
            students.Add(person);
            HttpContext.Response.StatusCode = StatusCodes.Status201Created;
        }
    }
}
