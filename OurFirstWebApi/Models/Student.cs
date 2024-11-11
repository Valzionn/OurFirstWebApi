using System.ComponentModel.DataAnnotations;

namespace OurFirstWebApi.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(255)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(255)]
        public string SSID { get; set; }
        [Required]
        [MaxLength(255)]
        public List<Course> Courses { get; set; }
    }
}
