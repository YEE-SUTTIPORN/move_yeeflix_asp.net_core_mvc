using System.ComponentModel.DataAnnotations;

namespace yeeflix_project.Models;

public class KeywordModel
{
    [Key]
    public int KEYWORD_ID { get; set; }
    [Required]
    [MaxLength(100)]
    public string KEYWORD_NAME { get; set; } = "";
}
