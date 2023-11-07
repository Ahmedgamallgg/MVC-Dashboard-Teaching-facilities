using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Trainee : BaseEntity
    {
        [Required]
        [MaxLength(15)]
        [MinLength(4)]

        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(20, MinimumLength =8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;

        public bool IsActive { get; set; }

        public ICollection<TraineeCourses>? TraineeCourses { get; set; }


    }
}
