using System.ComponentModel.DataAnnotations;

namespace BlazorBasics.Models;

public class MoviesModel
{
    public int id {  get; set; }
    [Required]
    [StringLength(50)]
    public string title { get; set; }
    [Required]
    [StringLength(50)]
    public String genre { get; set; }
    [Required]
    [Range(1,10)]
    public int Rating { get; set; }
}
