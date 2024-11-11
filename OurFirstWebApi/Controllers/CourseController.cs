using Microsoft.AspNetCore.Mvc;
using OurFirstWebApi.Data.Interfaces;
using OurFirstWebApi.Models;

namespace OurFirstWebApi.Controllers
{
    [Route("api/courses")]
    [Controller]
    public class CourseController : ControllerBase
    {
        private readonly IRepository _repository;

        // það sem kemur inn verður notað
        //IoC inversion of control
        public CourseController(IRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public ActionResult<List<Course>> GetAllCourses()
        {
            try
            {
                return Ok(_repository.GetAllCourses());
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Course> GetCourseById(int id)
        {
            try
            {
                return Ok(_repository.GetCourseById(id));
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public IActionResult CreateCourse(Course course)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repository.CreateCourse(course);
                    return CreatedAtAction(nameof(GetCourseById), new { id = course.Id }, course);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateCourse(int id, Course course)
        {
            Course updatedCourse = _repository.UpdateCourse(id, course);

            if (updatedCourse != null)
            {
                return NotFound();
            }
        }
    }
}
 