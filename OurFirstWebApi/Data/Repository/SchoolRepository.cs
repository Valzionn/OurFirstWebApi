using OurFirstWebApi.Data.Interfaces;
using OurFirstWebApi.Models;

namespace OurFirstWebApi.Data.Repository
{
    public class SchoolRepository : IRepository
    {
        private readonly SchoolDbContext _dbContext;

        public SchoolRepository()
        {
            _dbContext = new SchoolDbContext();
        }

        public void CreateCourse(Course course)
        {
            using (var db = _dbContext)
            {
                db.Courses.Add(course);
                db.SaveChanges();
            }
        }

        public void CreateStudent(Student student)
        {
            using (var db = _dbContext)
            {
                db.Students.Add(student);
                db.SaveChanges();
            }
        }

        public List<Course> GetAllCourses()
        {
            using (var db = _dbContext)
            {
                return db.Courses.ToList();
            }
        }

        public List<Student> GetAllStudents()
        {
            using (var db = _dbContext)
            {
                return db.Students.ToList();
            }
        }

        public Course GetCourseById(int id)
        {
            using (var db = _dbContext)
            {
                return db.Courses.FirstOrDefault(x => x.Id == id);
            }
        }

        public Student getStudentById(int id)
        {
            using (var db = _dbContext)
            {
                return db.Students.FirstOrDefault(x => x.Id == id);
            }
        }

        public Course UpdateCourse(int id, Course course)
        {
            Course courseToUpdate;
            using (var db = _dbContext)
            {
                courseToUpdate = db.Courses.FirstOrDefault(x => x.Id == id);

                if (courseToUpdate == null)
                {
                    return null;
                }

                courseToUpdate.Name = course.Name;
                courseToUpdate.Students = course.Students;

                db.SaveChanges();
                return courseToUpdate;
            }
        }

        public Student UpdateStudent(int id, Student student)
        {
            throw new NotImplementedException();
        }
    }
}
