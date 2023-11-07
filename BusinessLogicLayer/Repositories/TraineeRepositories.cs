﻿using BusinessLogicLayer.Interfaces;
using DataAccessLayer.Context;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Repositories
{
    public class TraineeRepositories : GenericRepositorie<Trainee>, ITraineeRepositories
    {
        public TraineeRepositories(ApplicationDbContext context) : base(context)
        {
        }
    }
}
