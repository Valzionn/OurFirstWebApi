using OurFirstWebApi.Models;

namespace OurFirstWebApi.Data.Interfaces
{
    public interface IRepository
    {
        List<Student> GetAllStudents();
        Student getStudentById(int id);
        List<Course> GetAllCourses();
        Course GetCourseById(int id);

        void CreateStudent(Student student);
        void CreateCourse(Course course);
        Course UpdateCourse(int id, Course course);
        Student UpdateStudent(int id, Student student);
    }
}
