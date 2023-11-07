using DataAccessLayer.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_MVC_Project.Models
{
    public class CourseViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(15)]
        [MinLength(2)]
        [DisplayName("Course Name")]
        public string Name { get; set; }
        [DisplayName("Creation Date")]

        public DateTime CreationDate { get; set; } = DateTime.Now;
        public string? Description { get; set; }
        [DisplayName("Category ID")]

        public int CategoryId { get; set; }
        [DisplayName("Trainer ID")]

        public int TrainerId { get; set; }
    }
}
