using System.ComponentModel.DataAnnotations;

namespace yeeflix_project.Models;

public class PersonModel
{
    [Key]
    public int PERSON_ID { get; set; }
    [Required]
    [MaxLength(150)]
    public string PERSON_NAME { get; set; } = "";
}

