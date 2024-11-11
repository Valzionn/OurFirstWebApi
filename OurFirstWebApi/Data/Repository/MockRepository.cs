using OurFirstWebApi.Data.Interfaces;
using OurFirstWebApi.Models;

namespace OurFirstWebApi.Data.Repository
{
    public class MockRepository : IRepository
    {
        List<Student> Students = new List<Student>()
        {
                new Student { Id = 1, FirstName = "Mock-Hjörtur", LastName = "Pálmi", SSID = "111111-1119" },
                new Student { Id = 2, FirstName = "Mock-Adam", LastName = "Hart", SSID = "222222-1119" },
                new Student { Id = 3, FirstName = "Mock-AAA", LastName = "SSSS", SSID = "333333-1119" }
        };

        List<Course> Courses = new List<Course>()
        {
            new Course { Id = 1, Name= "Mock-Forritun" },
            new Course { Id = 2, Name= "Mock-Hönnun" },
            new Course { Id = 3, Name= "Mock-Gagnagrunnar"},
        };

        public MockRepository()
        {

        }

        public List<Student> GetAllStudents()
        {
            return Students;
        }

        public Student getStudentById(int id)
        {
            return Students.FirstOrDefault(x => x.Id == id);
        }

        public List<Course> GetAllCourses()
        {
            return Courses;
        }

        public Course GetCourseById(int id)
        {
            return Courses.FirstOrDefault(x => x.Id == id);
        }

        public void CreateStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public void CreateCourse(Course course)
        {
            throw new NotImplementedException();
        }

        public Course UpdateCourse(int id, Course course)
        {
            throw new NotImplementedException();
        }

        public Student UpdateStudent(int id, Student student)
        {
            throw new NotImplementedException();
        }
    }
}
