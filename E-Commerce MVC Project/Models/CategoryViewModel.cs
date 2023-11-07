using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_MVC_Project.Models
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(15)]
        [MinLength(4)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Parent Code")]
        public int ParentId { get; set; }
    }
}
