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
    public class TrainerRepositories : GenericRepositorie<Trainer>, ITrainerRepositories
    {
        private readonly ApplicationDbContext _Context;

        public TrainerRepositories(ApplicationDbContext context) : base(context)
        {
            _Context = context;
        }

        public IEnumerable<Trainer> GetByName(string name)
        {
            return _Context.Trainers.Where(tr => tr.Name.Trim().ToLower().Contains(name.Trim().ToLower()));
        }
    }
}
