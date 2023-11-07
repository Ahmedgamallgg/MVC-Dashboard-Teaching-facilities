using BusinessLogicLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Repositories
{
    public class UnitOfWork : IUnitOFWork
    {
        public UnitOfWork(IAdminRepositories adminRepositories, 
                          ICategoryRepositories categoryRepositories, 
                          ICourseRepositories courseRepositories, 
                          ITraineeRepositories traineeRepositories, 
                          ITrainerRepositories trainerRepositories)
        {
            AdminRepositories = adminRepositories;
            CategoryRepositories = categoryRepositories;
            CourseRepositories = courseRepositories;
            TraineeRepositories = traineeRepositories;
            TrainerRepositories = trainerRepositories;
        }

        public IAdminRepositories AdminRepositories { get; set; }
        public ICategoryRepositories CategoryRepositories { get; set; }
        public ICourseRepositories CourseRepositories { get; set; }
        public ITraineeRepositories TraineeRepositories { get; set; }
        public ITrainerRepositories TrainerRepositories { get; set; }
    }
}
