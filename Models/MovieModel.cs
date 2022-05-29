using System.ComponentModel.DataAnnotations;

namespace yeeflix_project.Models;

public class MovieModel
{
    [Key]
    public string MOVIE_ID { get; set; } = "";

    [Required]
    [MaxLength(300)]
    public string TITLE {get;set;} = "";

    [MaxLength(1000)]
    public string OVERVIEW { get; set; } = "";

    public string POSTER_PATH { get; set; } = "";

    public string RUNTIME { get; set; } = "";
    public int VOTES_COUNT { get; set; }

    public DateTime CREATE_DATE { get; set; } = DateTime.Now;
    public DateTime LAST_UPDATE { get; set; } = DateTime.Now;
}
