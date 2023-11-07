using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Trainer : BaseEntity
    {
        [Required]
        [MaxLength(15)]
        [MinLength(4)]

        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string? Description { get; set; }
        [Url]
        public string? Website { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
