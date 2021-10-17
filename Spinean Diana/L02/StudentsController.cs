using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using tema_2_Spinean.Models;
using tema_2_Spinean.Repositories;

namespace tema_2_Spinean.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : Controller
    {
        public StudentsController()
        {
        }

        public IEnumerable<Student> Get()
        {
            return StudentsRepo.Student;
        }

        [HttpGet("{Id}")]
        public Student GetStudent(int id)
        {
            return StudentsRepo.Student.FirstOrDefault(s => s.Id == id);
        }

    }
}