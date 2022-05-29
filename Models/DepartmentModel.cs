using System.ComponentModel.DataAnnotations;

namespace yeeflix_project.Models;

public class DepartmentModel
{
    [Key]
    public int DEPARTMENT_ID { get; set; }
    [Required]
    [MaxLength(100)]
    public string DEPARTMENT_NAME { get; set; } = "";
}
