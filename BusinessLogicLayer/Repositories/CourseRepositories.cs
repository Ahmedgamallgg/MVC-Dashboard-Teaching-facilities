using BusinessLogicLayer.Interfaces;
using DataAccessLayer.Context;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Repositories
{
    public class CourseRepositories : GenericRepositorie<Course>, ICourseRepositories
    {
        private readonly ApplicationDbContext _Context;

        public CourseRepositories(ApplicationDbContext context) : base(context)
        {
            _Context = context;
        }


        public IEnumerable<Course> SearchByName(string? name)
         => _Context.Courses.Where(course => course.Name.Trim().ToLower().Contains(name.Trim().ToLower()));
    }
}
