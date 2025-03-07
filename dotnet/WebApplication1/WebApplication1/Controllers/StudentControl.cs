using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using WebApplication1.model;
using static WebApplication1.model.Classes;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]

    public class StudentControl : Controller
    {
        public List<Classes> studentlist = new List<Classes>();
        [HttpGet(Name = "studentdata")]
        public IActionResult GetStudent()
        {
            for (int i = 0; i < 10; i++)
            {
                Classes student = new Classes();
                student.Id = i;
                student.Name = "Student" + i;
                studentlist.Add(student);
            }
            return Ok(studentlist);
        }

        [HttpGet("{id}", Name = "GetStudentById")]
        public IActionResult GetStudentById(int id)
        {
            return Ok(studentlist[id]);
        }

    }
}