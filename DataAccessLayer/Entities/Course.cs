using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Course : BaseEntity
    {
        [Required]
        [MaxLength(15)]
        [MinLength(2)]

        public string Name { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public int TrainerId { get; set; }

        public Trainer? Trainer { get; set; }

        public ICollection<TraineeCourses>? TraineeCourses { get; set; }
    }
}
