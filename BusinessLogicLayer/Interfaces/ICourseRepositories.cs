using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
    public interface ICourseRepositories : IGenericRepositorie<Course>
    {
        public IEnumerable<Course> SearchByName(string? name);
    }
}
