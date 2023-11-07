using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
    public interface ITrainerRepositories : IGenericRepositorie<Trainer>
    {
        public IEnumerable<Trainer> GetByName(string name);
    }
}
