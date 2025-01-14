﻿using System.ComponentModel.DataAnnotations;

namespace OurFirstWebApi.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        public List<Student> Students { get; set; }
    }
}
