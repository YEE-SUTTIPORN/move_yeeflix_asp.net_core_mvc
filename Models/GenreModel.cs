using System.ComponentModel.DataAnnotations;

namespace yeeflix_project.Models;

public class GenreModel
{
    [Key]
    public int GENRE_ID { get; set; }
    [Required]
    [MaxLength(100)]
    public string GENRE_NAME { get; set; } = "";
}
