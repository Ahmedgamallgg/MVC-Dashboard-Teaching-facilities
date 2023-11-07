using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
    public interface IUnitOFWork 
    {
        public IAdminRepositories AdminRepositories { get; set; }
        public ICategoryRepositories CategoryRepositories { get; set; }
        public ICourseRepositories CourseRepositories { get; set; }
        public ITraineeRepositories TraineeRepositories { get; set; }
        public ITrainerRepositories TrainerRepositories { get; set; }
        


    }
}
