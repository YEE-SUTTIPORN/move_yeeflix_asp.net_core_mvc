using System.ComponentModel.DataAnnotations;

namespace yeeflix_project.Models;

public class LanguageModel
{
    [Key]
    public int LANGUAGE_ID { get; set; }
    [Required]
    [MaxLength(20)]
    public string LANGUAGE_CODE { get; set; } = "";
    [Required]
    [MaxLength(100)]
    public string LANGUAGE_NAME { get; set; } = "";
}
