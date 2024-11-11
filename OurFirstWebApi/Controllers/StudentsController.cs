using Microsoft.AspNetCore.Mvc;
using OurFirstWebApi.Data.Interfaces;
using OurFirstWebApi.Models;

namespace OurFirstWebApi.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IRepository _repository;

        public StudentsController(IRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public ActionResult<List<Student>> GetAllStudents()
        {
            try
            {
                return Ok(_repository.GetAllStudents());
            }
            catch
            {
                return StatusCode(500);
            }
        }


        [HttpGet]
        [Route("{id}")]
        public ActionResult<Student> GetStudentById(int id)
        {
            try
            {
                return Ok(_repository.getStudentById(id));
            }
            catch
            {
                return StatusCode(500);
            } 
        }

        //Create Student
        [HttpPost]
        public IActionResult CreateStudent([FromBody] Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repository.CreateStudent(student);
                    return CreatedAtAction(nameof(GetStudentById), new { id = student.Id }, student);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}

