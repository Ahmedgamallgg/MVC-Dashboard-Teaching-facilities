using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class TraineeCourses
    {
        
        public int TraineeId { get; set; }
        public Trainee Trainee { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }


        public DateTime RegistrationDate { get; set; } = DateTime.Now;
    }
}
