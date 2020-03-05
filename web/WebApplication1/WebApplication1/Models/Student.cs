using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("student")]
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        public String ClassName { get; set; }
        public String Email { get; set; }
    }
}