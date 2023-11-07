using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class CourseLessons : BaseEntity
    {
        [Required]
        [StringLength(10, MinimumLength =4)]
        public string Title { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int OrderNumber { get; set; }


    }
}
