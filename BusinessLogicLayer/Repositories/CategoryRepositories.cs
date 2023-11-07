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
    public class CategoryRepositories : GenericRepositorie<Category>, ICategoryRepositories
    {
        public CategoryRepositories(ApplicationDbContext context) : base(context)
        {
        }
    }
}
