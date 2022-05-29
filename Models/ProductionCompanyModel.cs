using System.ComponentModel.DataAnnotations;

namespace yeeflix_project.Models;

public class ProductionCompanyModel
{
    [Key]
    public int COMPANY_ID { get; set; }
    [Required]
    [MaxLength(150)]
    public string COMPANY_NAME { get; set; } = "";
}
