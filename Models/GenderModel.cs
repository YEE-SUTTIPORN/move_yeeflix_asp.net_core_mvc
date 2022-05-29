using System.ComponentModel.DataAnnotations;

namespace yeeflix_project.Models;

public class GenderModel
{
    [Key]
    public int GENDER_ID { get; set; }
    [Required]
    [MaxLength(50)]
    public string GENDER { get; set; } = "";
}
