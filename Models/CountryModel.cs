using System.ComponentModel.DataAnnotations;

namespace yeeflix_project.Models;

public class CountryModel
{
    [Key]
    public int COUNTRY_ID { get; set; }
    [Required]
    [MaxLength(3)]
    public string COUNTRY_ISO_CODE { get; set; } = "";
    [Required]
    [MaxLength(100)]
    public string COUNTRY_NAME { get; set; } = "";
}
