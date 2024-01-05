using System.ComponentModel.DataAnnotations;

namespace BlazorBasics.Models
{
    public class MemoriesModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string Date { get; set; }

        [Required]
        [StringLength(50)]
        public string Location { get; set; }
    }
}
