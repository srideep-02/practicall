using Microsoft.AspNetCore.Mvc;
using WebApplication1.model;

namespace WebApplication1.Controllers
{
    //[ApiController]
    //[Route("api")]
    //public class FirstController : ControllerBase

    [ApiController]
    [Route("api/[Controller]")]
    public class StudentController : ControllerBase
    {
        public static List<Student> students = new List<Student>();

        [HttpGet]
        public List<Student> GetStudent()
        {
            return students;
        }

        [HttpPost]
        public string AddStudent(Student student)
        {
            students.Add(student);
            return $"{student.Id} - {student.Name} Record inserted successfully";
        }

        [HttpPut]
        public string UpdateStudent(Student student)
        {
            Student studentToUpdate = students.Find(s => s.Id == student.Id);
            studentToUpdate.Name = student.Name;
            return $"{student.Id} - {student.Name} Record updated successfully";
        }

        [HttpDelete]
        public string DeleteStudent(int id)
        {
            Student studentToDelete = students.Find(s => s.Id == id);
            students.Remove(studentToDelete);
            return $"{studentToDelete.Id} - {studentToDelete.Name} Record deleted successfully";
        }
    }
}