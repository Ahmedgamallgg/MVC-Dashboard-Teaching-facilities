using System.ComponentModel.DataAnnotations;

namespace E_Commerce_MVC_Project.Models
{
    public class TrainerViewModel
    {
        [Required]
        public int Id { get; set; }
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
