﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Category : BaseEntity
    {
        [Required]
        [MaxLength(15)]
        [MinLength(4)]
        public string Name { get; set; }

        public int ParentId { get; set; }
    }
}
